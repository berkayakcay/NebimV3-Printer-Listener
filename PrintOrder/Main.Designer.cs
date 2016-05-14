namespace PrintOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.buttonPrintAgain = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nIPrinterListener = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelInfo);
            this.panelTop.Controls.Add(this.textBoxOrderNumber);
            this.panelTop.Controls.Add(this.buttonPrintAgain);
            this.panelTop.Controls.Add(this.buttonSettings);
            this.panelTop.Controls.Add(this.buttonPrint);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(420, 99);
            this.panelTop.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(118, 56);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Padding = new System.Windows.Forms.Padding(5);
            this.labelInfo.Size = new System.Drawing.Size(184, 43);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "1-WS-2- XXXXX";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderNumber.Location = new System.Drawing.Point(118, 32);
            this.textBoxOrderNumber.MaxLength = 10;
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(184, 24);
            this.textBoxOrderNumber.TabIndex = 2;
            this.textBoxOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderNumber_KeyPress);
            // 
            // buttonPrintAgain
            // 
            this.buttonPrintAgain.BackColor = System.Drawing.Color.Yellow;
            this.buttonPrintAgain.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPrintAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintAgain.Location = new System.Drawing.Point(118, 0);
            this.buttonPrintAgain.Name = "buttonPrintAgain";
            this.buttonPrintAgain.Size = new System.Drawing.Size(184, 32);
            this.buttonPrintAgain.TabIndex = 3;
            this.buttonPrintAgain.Text = "Print Again";
            this.buttonPrintAgain.UseVisualStyleBackColor = false;
            this.buttonPrintAgain.Click += new System.EventHandler(this.buttonPrintAgain_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(302, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(118, 99);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Red;
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(0, 0);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(118, 99);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "STOPPED";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.dataGridViewOrders);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 99);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(420, 462);
            this.panelMid.TabIndex = 1;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeight = 30;
            this.dataGridViewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(420, 462);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.linkLabel1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 535);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(420, 26);
            this.panelBottom.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(166, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.AcarSoft.net";
            // 
            // nIPrinterListener
            // 
            this.nIPrinterListener.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nIPrinterListener.Icon = ((System.Drawing.Icon)(resources.GetObject("nIPrinterListener.Icon")));
            this.nIPrinterListener.Text = "Sipariş geldiğinde otomatik yazdırılacak.";
            this.nIPrinterListener.Visible = true;
            this.nIPrinterListener.DoubleClick += new System.EventHandler(this.nIPrinterListener_DoubleClick);
            this.nIPrinterListener.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nIPrinterListener_MouseMove);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 561);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 680);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acar Soft - Printer Listener";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon nIPrinterListener;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Button buttonPrintAgain;
        private System.Windows.Forms.Label labelInfo;
    }
}

