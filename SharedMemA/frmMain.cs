using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedMemA
{
    public partial class frmMain : Form
    {
        Mutex mutex;
        MemoryMappedFile mmf;   // Sender: Keep Open, Or The MMF Close Immediaty After Write Data
                                // https://bygeek.cn/2018/05/24/understand-memory-mapped-file/ (Not Persistent MMF)
        BackgroundWorker bgw = new BackgroundWorker();

        string memName = "";
        string mutexName = "";
        string sendString = "";

        public frmMain()
        {
            InitializeComponent();

            bgw.DoWork += Bgw_DoWork;
            bgw.WorkerSupportsCancellation = true;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;

            while (!((BackgroundWorker)sender).CancellationPending)
            {
                // Create a view accessor to write the shared data
                using (MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor())
                {
                    // Acquire the Mutex lock before accessing shared memory
                    mutex.WaitOne();

                    byte[] array = Encoding.UTF8.GetBytes(sendString);
                    counter++;

                    // Write data to the shared memory
                    accessor.Write(0, (byte)array.Length);
                    accessor.WriteArray((byte)array.Length, array, 0, array.Length);

                    // Release the Mutex lock after accessing shared memory
                    mutex.ReleaseMutex();
                }

                Thread.Sleep(1000); // Wait for 1 second before sending next message
            }
        }

        void printErrorLog(string message)
        {
            txtException.Invoke(new Action(() =>
            {
                txtException.Text = $"{DateTime.Now} : {message}" + "\r\n" + txtException.Text;
            }));
        }

        void GetShareMemName()
        {
            memName = txtShareMemName.Text;
            mutexName = txtMutexName.Text;
            sendString = txtInput.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            GetShareMemName();

            mmf = MemoryMappedFile.CreateNew(memName, Int16.MaxValue);
            mutex = new Mutex(false, mutexName);

            btnSend.Enabled = false;
            txtShareMemName.Enabled = false;
            txtMutexName.Enabled = false;

            lblSendNotify.Visible = true;

            try
            {
                bgw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                printErrorLog(ex.Message);

                btnPause_Click(null, null);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mmf.Dispose();

            btnSend.Enabled = true;
            txtShareMemName.Enabled = true;
            txtMutexName.Enabled = true;

            lblSendNotify.Visible = false;
            bgw.CancelAsync();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
