namespace ContactTracingApp
{
    partial class QRCodeScannerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeScannerForm));
            this.BtnStartScan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PictureBoxCameraVideo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxVideoCaptureDevice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCameraVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStartScan
            // 
            this.BtnStartScan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnStartScan.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStartScan.ForeColor = System.Drawing.Color.Black;
            this.BtnStartScan.Location = new System.Drawing.Point(271, 422);
            this.BtnStartScan.Name = "BtnStartScan";
            this.BtnStartScan.Size = new System.Drawing.Size(132, 36);
            this.BtnStartScan.TabIndex = 60;
            this.BtnStartScan.Text = "Start Scan";
            this.BtnStartScan.UseVisualStyleBackColor = false;
            this.BtnStartScan.Click += new System.EventHandler(this.BtnStartScan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PictureBoxCameraVideo
            // 
            this.PictureBoxCameraVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxCameraVideo.Location = new System.Drawing.Point(18, 54);
            this.PictureBoxCameraVideo.Name = "PictureBoxCameraVideo";
            this.PictureBoxCameraVideo.Size = new System.Drawing.Size(607, 344);
            this.PictureBoxCameraVideo.TabIndex = 62;
            this.PictureBoxCameraVideo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Camera:";
            // 
            // ComboBoxVideoCaptureDevice
            // 
            this.ComboBoxVideoCaptureDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxVideoCaptureDevice.FormattingEnabled = true;
            this.ComboBoxVideoCaptureDevice.Location = new System.Drawing.Point(91, 18);
            this.ComboBoxVideoCaptureDevice.Name = "ComboBoxVideoCaptureDevice";
            this.ComboBoxVideoCaptureDevice.Size = new System.Drawing.Size(465, 29);
            this.ComboBoxVideoCaptureDevice.TabIndex = 64;
            // 
            // QRCodeScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(641, 466);
            this.Controls.Add(this.ComboBoxVideoCaptureDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxCameraVideo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnStartScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRCodeScannerForm";
            this.Text = "QRCodeScannerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCodeScannerForm_FormClosing);
            this.Load += new System.EventHandler(this.QRCodeScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCameraVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnStartScan;
        private Button button1;
        private PictureBox PictureBoxCameraVideo;
        private Label label1;
        private ComboBox ComboBoxVideoCaptureDevice;
    }
}