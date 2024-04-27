using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedMemB
{
    public partial class frmMain : Form
    {
        Mutex mutex;
        BackgroundWorker bgw = new BackgroundWorker();

        string memName = "";
        string mutexName = "";

        public frmMain()
        {
            InitializeComponent();

            bgw.DoWork += Bgw_DoWork;
            bgw.WorkerSupportsCancellation = true;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!((BackgroundWorker)sender).CancellationPending)
            {
                while (!((BackgroundWorker)sender).CancellationPending)
                {
                    try
                    {
                        // Open the memory mapped file
                        // Receiver: Open Once, Cause We Don't Know When The Sender's Can Send Message
                        using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(memName))
                        {
                            // Once opened successfully, break out of the loop
                            break;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        printErrorLog("Shared memory file not found.");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        printErrorLog("Unauthorized access to shared memory file. Make sure you have permission to access it.");
                        
                    }
                    catch (Exception ex)
                    {
                        printErrorLog(ex.Message);
                    }

                    Thread.Sleep(100);
                }

                // Open or create the memory mapped file
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(memName))
                {
                    // Create a view accessor to write the shared data
                    using (MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor())
                    {
                        // Acquire the Mutex lock before accessing shared memory
                        mutex.WaitOne();

                        // Read Value
                        int length = accessor.ReadByte(0);

                        byte[] array = new byte[length];

                        // Write data to the shared memory
                        accessor.ReadArray(length, array, 0, array.Length);

                        // Display the shared data
                        txtConsole.Invoke(new Action(() =>
                        {
                            string decodeStr = Encoding.UTF8.GetString(array);
                            txtConsole.Text = $"{DateTime.Now}: {decodeStr} (Length: {decodeStr.Length})" + "\r\n" + txtConsole.Text;
                        }));

                        // Release the Mutex lock after accessing shared memory
                        mutex.ReleaseMutex();
                    }
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
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            txtException.Text = "";

            GetShareMemName();
            mutex = new Mutex(false, mutexName);

            btnSend.Enabled = false;
            txtShareMemName.Enabled = false;
            txtMutexName.Enabled = false;

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

            btnSend.Enabled = true;
            txtShareMemName.Enabled = true;
            txtMutexName.Enabled = true;

            bgw.CancelAsync();
        }
    }
}
