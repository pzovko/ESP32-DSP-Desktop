namespace ESP32_DSP_Desktop
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.avaiableDevices = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataPlot = new ScottPlot.FormsPlot();
            this.graphPlotTimer = new System.Windows.Forms.Timer(this.components);
            this.fftPlot = new ScottPlot.FormsPlot();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disconnect);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Controls.Add(this.avaiableDevices);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(776, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 292);
            this.panel1.TabIndex = 0;
            // 
            // disconnect
            // 
            this.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.disconnect.ForeColor = System.Drawing.Color.Silver;
            this.disconnect.Location = new System.Drawing.Point(16, 243);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(169, 33);
            this.disconnect.TabIndex = 7;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click_1);
            // 
            // connect
            // 
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connect.ForeColor = System.Drawing.Color.Silver;
            this.connect.Location = new System.Drawing.Point(16, 204);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(169, 33);
            this.connect.TabIndex = 6;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click_1);
            // 
            // avaiableDevices
            // 
            this.avaiableDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.avaiableDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avaiableDevices.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avaiableDevices.ForeColor = System.Drawing.Color.White;
            this.avaiableDevices.FormattingEnabled = true;
            this.avaiableDevices.ItemHeight = 16;
            this.avaiableDevices.Location = new System.Drawing.Point(16, 13);
            this.avaiableDevices.Name = "avaiableDevices";
            this.avaiableDevices.Size = new System.Drawing.Size(169, 146);
            this.avaiableDevices.Sorted = true;
            this.avaiableDevices.TabIndex = 5;
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresh.ForeColor = System.Drawing.Color.Silver;
            this.refresh.Location = new System.Drawing.Point(16, 165);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(169, 33);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(776, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 275);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(3, 139);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(197, 62);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(3, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(3, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 724);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(0, 44);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1024, 44);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.statusLabel.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 39);
            this.statusLabel.Text = "Status";
            // 
            // dataPlot
            // 
            this.dataPlot.BackColor = System.Drawing.Color.Transparent;
            this.dataPlot.Location = new System.Drawing.Point(12, 8);
            this.dataPlot.Name = "dataPlot";
            this.dataPlot.Size = new System.Drawing.Size(716, 345);
            this.dataPlot.TabIndex = 4;
            this.dataPlot.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // graphPlotTimer
            // 
            this.graphPlotTimer.Interval = 1;
            this.graphPlotTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fftPlot
            // 
            this.fftPlot.BackColor = System.Drawing.Color.Transparent;
            this.fftPlot.Location = new System.Drawing.Point(12, 359);
            this.fftPlot.Name = "fftPlot";
            this.fftPlot.Size = new System.Drawing.Size(716, 345);
            this.fftPlot.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.fftPlot);
            this.Controls.Add(this.dataPlot);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ListBox avaiableDevices;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private ScottPlot.FormsPlot dataPlot;
        private System.Windows.Forms.Timer graphPlotTimer;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private ScottPlot.FormsPlot fftPlot;
    }
}

