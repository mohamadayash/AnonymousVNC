namespace AnonymousVNC
{
    partial class frmScanOpenVnc
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblFinished = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.IsVnc = new System.Windows.Forms.RadioButton();
            this.IsFtp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(99, 41);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(13, 13);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "0";
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Location = new System.Drawing.Point(99, 67);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(13, 13);
            this.lblFinished.TabIndex = 3;
            this.lblFinished.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "In Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Finished";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remaining";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(99, 92);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(13, 13);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "0";
            // 
            // IsVnc
            // 
            this.IsVnc.AutoSize = true;
            this.IsVnc.Checked = true;
            this.IsVnc.Location = new System.Drawing.Point(22, 13);
            this.IsVnc.Name = "IsVnc";
            this.IsVnc.Size = new System.Drawing.Size(45, 17);
            this.IsVnc.TabIndex = 8;
            this.IsVnc.TabStop = true;
            this.IsVnc.Text = "VNC";
            this.IsVnc.UseVisualStyleBackColor = true;
            // 
            // IsFtp
            // 
            this.IsFtp.AutoSize = true;
            this.IsFtp.Location = new System.Drawing.Point(115, 13);
            this.IsFtp.Name = "IsFtp";
            this.IsFtp.Size = new System.Drawing.Size(43, 17);
            this.IsFtp.TabIndex = 9;
            this.IsFtp.Text = "FTP";
            this.IsFtp.UseVisualStyleBackColor = true;
            // 
            // frmScanOpenVnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 175);
            this.Controls.Add(this.IsFtp);
            this.Controls.Add(this.IsVnc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScanOpenVnc";
            this.Text = "PwnVnc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblQueue;
        public System.Windows.Forms.Label lblFinished;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblRemaining;
        public System.Windows.Forms.RadioButton IsVnc;
        public System.Windows.Forms.RadioButton IsFtp;
    }
}

