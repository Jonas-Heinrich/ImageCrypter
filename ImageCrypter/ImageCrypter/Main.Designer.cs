namespace ImageCrypter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.grpDecrypt = new System.Windows.Forms.GroupBox();
            this.cmdDecryptSave = new System.Windows.Forms.Button();
            this.cmdDecryptOpen = new System.Windows.Forms.Button();
            this.lblTitleDecryptBitnumber = new System.Windows.Forms.Label();
            this.numDecryptBits = new System.Windows.Forms.NumericUpDown();
            this.lblDecryptInfo = new System.Windows.Forms.Label();
            this.grpEncrypt = new System.Windows.Forms.GroupBox();
            this.cmdEncryptPayload = new System.Windows.Forms.Button();
            this.cmdEncryptSave = new System.Windows.Forms.Button();
            this.lblTitleEncryptBitnumber = new System.Windows.Forms.Label();
            this.cmdEncryptOpen = new System.Windows.Forms.Button();
            this.numEncryptBits = new System.Windows.Forms.NumericUpDown();
            this.lblEncryptInfo = new System.Windows.Forms.Label();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.grpDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecryptBits)).BeginInit();
            this.grpEncrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEncryptBits)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Enabled = false;
            this.cmdEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncrypt.Location = new System.Drawing.Point(183, 227);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(111, 23);
            this.cmdEncrypt.TabIndex = 9;
            this.cmdEncrypt.Text = "Encrypt Message";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Enabled = false;
            this.cmdDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecrypt.Location = new System.Drawing.Point(183, 227);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(111, 23);
            this.cmdDecrypt.TabIndex = 11;
            this.cmdDecrypt.Text = "Decrypt Message";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // grpDecrypt
            // 
            this.grpDecrypt.Controls.Add(this.cmdDecryptSave);
            this.grpDecrypt.Controls.Add(this.cmdDecryptOpen);
            this.grpDecrypt.Controls.Add(this.lblTitleDecryptBitnumber);
            this.grpDecrypt.Controls.Add(this.numDecryptBits);
            this.grpDecrypt.Controls.Add(this.lblDecryptInfo);
            this.grpDecrypt.Controls.Add(this.cmdDecrypt);
            this.grpDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecrypt.Location = new System.Drawing.Point(11, 12);
            this.grpDecrypt.Name = "grpDecrypt";
            this.grpDecrypt.Size = new System.Drawing.Size(300, 256);
            this.grpDecrypt.TabIndex = 20;
            this.grpDecrypt.TabStop = false;
            this.grpDecrypt.Text = "Decrypt an Image";
            // 
            // cmdDecryptSave
            // 
            this.cmdDecryptSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecryptSave.Location = new System.Drawing.Point(9, 72);
            this.cmdDecryptSave.Name = "cmdDecryptSave";
            this.cmdDecryptSave.Size = new System.Drawing.Size(68, 23);
            this.cmdDecryptSave.TabIndex = 26;
            this.cmdDecryptSave.Text = "Save";
            this.cmdDecryptSave.UseVisualStyleBackColor = true;
            this.cmdDecryptSave.Click += new System.EventHandler(this.cmdDecryptSave_Click);
            // 
            // cmdDecryptOpen
            // 
            this.cmdDecryptOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecryptOpen.Location = new System.Drawing.Point(9, 33);
            this.cmdDecryptOpen.Name = "cmdDecryptOpen";
            this.cmdDecryptOpen.Size = new System.Drawing.Size(68, 23);
            this.cmdDecryptOpen.TabIndex = 25;
            this.cmdDecryptOpen.Text = "Open";
            this.cmdDecryptOpen.UseVisualStyleBackColor = true;
            this.cmdDecryptOpen.Click += new System.EventHandler(this.cmdDecryptOpen_Click);
            // 
            // lblTitleDecryptBitnumber
            // 
            this.lblTitleDecryptBitnumber.AutoSize = true;
            this.lblTitleDecryptBitnumber.Location = new System.Drawing.Point(6, 166);
            this.lblTitleDecryptBitnumber.Name = "lblTitleDecryptBitnumber";
            this.lblTitleDecryptBitnumber.Size = new System.Drawing.Size(143, 18);
            this.lblTitleDecryptBitnumber.TabIndex = 24;
            this.lblTitleDecryptBitnumber.Text = "Number of Bits used";
            // 
            // numDecryptBits
            // 
            this.numDecryptBits.Location = new System.Drawing.Point(9, 187);
            this.numDecryptBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDecryptBits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDecryptBits.Name = "numDecryptBits";
            this.numDecryptBits.Size = new System.Drawing.Size(285, 24);
            this.numDecryptBits.TabIndex = 23;
            this.numDecryptBits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDecryptInfo
            // 
            this.lblDecryptInfo.AutoSize = true;
            this.lblDecryptInfo.Location = new System.Drawing.Point(6, 228);
            this.lblDecryptInfo.Name = "lblDecryptInfo";
            this.lblDecryptInfo.Size = new System.Drawing.Size(100, 18);
            this.lblDecryptInfo.TabIndex = 22;
            this.lblDecryptInfo.Text = "<Information>";
            // 
            // grpEncrypt
            // 
            this.grpEncrypt.Controls.Add(this.cmdEncryptPayload);
            this.grpEncrypt.Controls.Add(this.cmdEncryptSave);
            this.grpEncrypt.Controls.Add(this.lblTitleEncryptBitnumber);
            this.grpEncrypt.Controls.Add(this.cmdEncryptOpen);
            this.grpEncrypt.Controls.Add(this.numEncryptBits);
            this.grpEncrypt.Controls.Add(this.lblEncryptInfo);
            this.grpEncrypt.Controls.Add(this.cmdEncrypt);
            this.grpEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEncrypt.Location = new System.Drawing.Point(317, 12);
            this.grpEncrypt.Name = "grpEncrypt";
            this.grpEncrypt.Size = new System.Drawing.Size(300, 256);
            this.grpEncrypt.TabIndex = 21;
            this.grpEncrypt.TabStop = false;
            this.grpEncrypt.Text = "Encrypt an Image";
            // 
            // cmdEncryptPayload
            // 
            this.cmdEncryptPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncryptPayload.Location = new System.Drawing.Point(9, 111);
            this.cmdEncryptPayload.Name = "cmdEncryptPayload";
            this.cmdEncryptPayload.Size = new System.Drawing.Size(68, 23);
            this.cmdEncryptPayload.TabIndex = 29;
            this.cmdEncryptPayload.Text = "Load";
            this.cmdEncryptPayload.UseVisualStyleBackColor = true;
            this.cmdEncryptPayload.Click += new System.EventHandler(this.cmdEncryptPayload_Click);
            // 
            // cmdEncryptSave
            // 
            this.cmdEncryptSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncryptSave.Location = new System.Drawing.Point(9, 72);
            this.cmdEncryptSave.Name = "cmdEncryptSave";
            this.cmdEncryptSave.Size = new System.Drawing.Size(68, 23);
            this.cmdEncryptSave.TabIndex = 28;
            this.cmdEncryptSave.Text = "Save";
            this.cmdEncryptSave.UseVisualStyleBackColor = true;
            this.cmdEncryptSave.Click += new System.EventHandler(this.cmdEncryptSave_Click);
            // 
            // lblTitleEncryptBitnumber
            // 
            this.lblTitleEncryptBitnumber.AutoSize = true;
            this.lblTitleEncryptBitnumber.Location = new System.Drawing.Point(6, 166);
            this.lblTitleEncryptBitnumber.Name = "lblTitleEncryptBitnumber";
            this.lblTitleEncryptBitnumber.Size = new System.Drawing.Size(143, 18);
            this.lblTitleEncryptBitnumber.TabIndex = 26;
            this.lblTitleEncryptBitnumber.Text = "Number of Bits used";
            // 
            // cmdEncryptOpen
            // 
            this.cmdEncryptOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncryptOpen.Location = new System.Drawing.Point(9, 33);
            this.cmdEncryptOpen.Name = "cmdEncryptOpen";
            this.cmdEncryptOpen.Size = new System.Drawing.Size(68, 23);
            this.cmdEncryptOpen.TabIndex = 27;
            this.cmdEncryptOpen.Text = "Open";
            this.cmdEncryptOpen.UseVisualStyleBackColor = true;
            this.cmdEncryptOpen.Click += new System.EventHandler(this.cmdEncryptOpen_Click);
            // 
            // numEncryptBits
            // 
            this.numEncryptBits.Location = new System.Drawing.Point(6, 187);
            this.numEncryptBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numEncryptBits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEncryptBits.Name = "numEncryptBits";
            this.numEncryptBits.Size = new System.Drawing.Size(285, 24);
            this.numEncryptBits.TabIndex = 25;
            this.numEncryptBits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEncryptInfo
            // 
            this.lblEncryptInfo.AutoSize = true;
            this.lblEncryptInfo.Location = new System.Drawing.Point(6, 228);
            this.lblEncryptInfo.Name = "lblEncryptInfo";
            this.lblEncryptInfo.Size = new System.Drawing.Size(100, 18);
            this.lblEncryptInfo.TabIndex = 23;
            this.lblEncryptInfo.Text = "<Information>";
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 280);
            this.Controls.Add(this.grpEncrypt);
            this.Controls.Add(this.grpDecrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageCrypter";
            this.grpDecrypt.ResumeLayout(false);
            this.grpDecrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecryptBits)).EndInit();
            this.grpEncrypt.ResumeLayout(false);
            this.grpEncrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEncryptBits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdEncrypt;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.GroupBox grpDecrypt;
        private System.Windows.Forms.GroupBox grpEncrypt;
        private System.Windows.Forms.Label lblDecryptInfo;
        private System.Windows.Forms.Label lblEncryptInfo;
        private System.Windows.Forms.NumericUpDown numDecryptBits;
        private System.Windows.Forms.Label lblTitleDecryptBitnumber;
        private System.Windows.Forms.Label lblTitleEncryptBitnumber;
        private System.Windows.Forms.NumericUpDown numEncryptBits;
        private System.Windows.Forms.Button cmdDecryptSave;
        private System.Windows.Forms.Button cmdDecryptOpen;
        private System.Windows.Forms.Button cmdEncryptSave;
        private System.Windows.Forms.Button cmdEncryptOpen;
        private System.Windows.Forms.Button cmdEncryptPayload;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
    }
}

