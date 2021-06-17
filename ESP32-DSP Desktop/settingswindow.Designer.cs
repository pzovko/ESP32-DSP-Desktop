namespace ESP32_DSP_Desktop
{
    partial class settingswindow
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoadFIR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmSampleRate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbmFFTLen = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmFilterLen = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFilterCoef = new System.Windows.Forms.OpenFileDialog();
            this.filterPlot = new ScottPlot.FormsPlot();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.Silver;
            this.btnApply.Location = new System.Drawing.Point(583, 81);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(169, 33);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(583, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnLoadFIR
            // 
            this.btnLoadFIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFIR.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadFIR.ForeColor = System.Drawing.Color.Silver;
            this.btnLoadFIR.Location = new System.Drawing.Point(583, 37);
            this.btnLoadFIR.Name = "btnLoadFIR";
            this.btnLoadFIR.Size = new System.Drawing.Size(169, 33);
            this.btnLoadFIR.TabIndex = 9;
            this.btnLoadFIR.Text = "Load filter";
            this.btnLoadFIR.UseVisualStyleBackColor = true;
            this.btnLoadFIR.Click += new System.EventHandler(this.btnLoadFIR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbmSampleRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 131);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(205, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hz";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.cbBaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBaudrate.Font = new System.Drawing.Font("Nirmala UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.cbBaudrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbBaudrate.Location = new System.Drawing.Point(105, 73);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(121, 27);
            this.cbBaudrate.TabIndex = 12;
            this.cbBaudrate.Text = "115200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(25, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Baud rate:";
            // 
            // tbmSampleRate
            // 
            this.tbmSampleRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.tbmSampleRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmSampleRate.Font = new System.Drawing.Font("Nirmala UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbmSampleRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbmSampleRate.Location = new System.Drawing.Point(105, 32);
            this.tbmSampleRate.Mask = "0000";
            this.tbmSampleRate.Name = "tbmSampleRate";
            this.tbmSampleRate.PromptChar = ' ';
            this.tbmSampleRate.Size = new System.Drawing.Size(94, 26);
            this.tbmSampleRate.TabIndex = 14;
            this.tbmSampleRate.Text = "5000";
            this.tbmSampleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sample rate:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbmFFTLen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbmFilterLen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(313, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 131);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter settings";
            // 
            // tbmFFTLen
            // 
            this.tbmFFTLen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.tbmFFTLen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmFFTLen.Font = new System.Drawing.Font("Nirmala UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbmFFTLen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbmFFTLen.Location = new System.Drawing.Point(105, 74);
            this.tbmFFTLen.Mask = "0000";
            this.tbmFFTLen.Name = "tbmFFTLen";
            this.tbmFFTLen.PromptChar = ' ';
            this.tbmFFTLen.Size = new System.Drawing.Size(121, 26);
            this.tbmFFTLen.TabIndex = 16;
            this.tbmFFTLen.Text = "1024";
            this.tbmFFTLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "FFT length:";
            // 
            // tbmFilterLen
            // 
            this.tbmFilterLen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.tbmFilterLen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmFilterLen.Font = new System.Drawing.Font("Nirmala UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbmFilterLen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbmFilterLen.Location = new System.Drawing.Point(105, 32);
            this.tbmFilterLen.Name = "tbmFilterLen";
            this.tbmFilterLen.PromptChar = ' ';
            this.tbmFilterLen.ReadOnly = true;
            this.tbmFilterLen.Size = new System.Drawing.Size(121, 26);
            this.tbmFilterLen.TabIndex = 14;
            this.tbmFilterLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(11, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filter length:";
            // 
            // openFilterCoef
            // 
            this.openFilterCoef.FileOk += new System.ComponentModel.CancelEventHandler(this.openFilterCoef_FileOk);
            // 
            // filterPlot
            // 
            this.filterPlot.BackColor = System.Drawing.Color.Transparent;
            this.filterPlot.Location = new System.Drawing.Point(29, 180);
            this.filterPlot.Name = "filterPlot";
            this.filterPlot.Size = new System.Drawing.Size(723, 396);
            this.filterPlot.TabIndex = 17;
            // 
            // settingswindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.filterPlot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadFIR);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingswindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoadFIR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSampleRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbmSampleRate;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbmFilterLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbmFFTLen;
        private System.Windows.Forms.OpenFileDialog openFilterCoef;
        private ScottPlot.FormsPlot filterPlot;
    }
}