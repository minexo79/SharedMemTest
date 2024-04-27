namespace SharedMemA
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblSendNotify = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShareMemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMutexName = new System.Windows.Forms.TextBox();
            this.txtException = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(105, 72);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 24);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Hello World";
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.Green;
            this.btnSend.Location = new System.Drawing.Point(263, 13);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "RUN";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPause
            // 
            this.btnPause.ForeColor = System.Drawing.Color.Red;
            this.btnPause.Location = new System.Drawing.Point(347, 13);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 30);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblSendNotify
            // 
            this.lblSendNotify.AutoSize = true;
            this.lblSendNotify.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSendNotify.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSendNotify.Location = new System.Drawing.Point(262, 47);
            this.lblSendNotify.Name = "lblSendNotify";
            this.lblSendNotify.Size = new System.Drawing.Size(104, 20);
            this.lblSendNotify.TabIndex = 3;
            this.lblSendNotify.Text = "Processing...";
            this.lblSendNotify.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Send Text";
            // 
            // txtShareMemName
            // 
            this.txtShareMemName.Location = new System.Drawing.Point(105, 13);
            this.txtShareMemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtShareMemName.Name = "txtShareMemName";
            this.txtShareMemName.Size = new System.Drawing.Size(150, 24);
            this.txtShareMemName.TabIndex = 5;
            this.txtShareMemName.Text = "SharedMemory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mem Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mutex Name";
            // 
            // txtMutexName
            // 
            this.txtMutexName.Location = new System.Drawing.Point(105, 42);
            this.txtMutexName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMutexName.Name = "txtMutexName";
            this.txtMutexName.Size = new System.Drawing.Size(150, 24);
            this.txtMutexName.TabIndex = 8;
            this.txtMutexName.Text = "SharedMemMutex";
            // 
            // txtException
            // 
            this.txtException.BackColor = System.Drawing.Color.Black;
            this.txtException.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtException.ForeColor = System.Drawing.Color.Red;
            this.txtException.Location = new System.Drawing.Point(12, 103);
            this.txtException.Multiline = true;
            this.txtException.Name = "txtException";
            this.txtException.Size = new System.Drawing.Size(411, 247);
            this.txtException.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 362);
            this.Controls.Add(this.txtException);
            this.Controls.Add(this.txtMutexName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShareMemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSendNotify);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblSendNotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShareMemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMutexName;
        private System.Windows.Forms.TextBox txtException;
    }
}

