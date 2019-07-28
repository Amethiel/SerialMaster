namespace SerialMaster
{
    partial class SerialMaster
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialMaster));
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblHandshake = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbSendData = new System.Windows.Forms.GroupBox();
            this.btnClearSendText = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.gbReceiveData = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnClearReceiveText = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatusChanged = new System.Windows.Forms.Timer(this.components);
            this.gbParameters.SuspendLayout();
            this.gbSendData.SuspendLayout();
            this.gbReceiveData.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.cbEncoding);
            this.gbParameters.Controls.Add(this.lblEncoding);
            this.gbParameters.Controls.Add(this.btnClose);
            this.gbParameters.Controls.Add(this.btnOpen);
            this.gbParameters.Controls.Add(this.cbHandshake);
            this.gbParameters.Controls.Add(this.cbParity);
            this.gbParameters.Controls.Add(this.cbStopBits);
            this.gbParameters.Controls.Add(this.cbDataBits);
            this.gbParameters.Controls.Add(this.cbBaudRate);
            this.gbParameters.Controls.Add(this.lblHandshake);
            this.gbParameters.Controls.Add(this.lblParity);
            this.gbParameters.Controls.Add(this.lblStopBits);
            this.gbParameters.Controls.Add(this.lblDataBits);
            this.gbParameters.Controls.Add(this.lblBaudRate);
            this.gbParameters.Controls.Add(this.cbName);
            this.gbParameters.Controls.Add(this.lblName);
            this.gbParameters.Location = new System.Drawing.Point(12, 12);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(274, 341);
            this.gbParameters.TabIndex = 1;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "串口参数设置";
            // 
            // cbEncoding
            // 
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "RAW（16进制）",
            "ASCII"});
            this.cbEncoding.Location = new System.Drawing.Point(118, 255);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(121, 20);
            this.cbEncoding.TabIndex = 27;
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(27, 259);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(65, 12);
            this.lblEncoding.TabIndex = 26;
            this.lblEncoding.Text = "字符编码：";
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(149, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "关闭端口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(45, 302);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 24;
            this.btnOpen.Text = "打开端口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbHandshake
            // 
            this.cbHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Items.AddRange(new object[] {
            "无",
            "XON/XOFF软件控制协议",
            "(RTS) 硬件流控制",
            "(RTS) 硬件流控制和XON/XOFF软件控制协议"});
            this.cbHandshake.Location = new System.Drawing.Point(118, 219);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(121, 20);
            this.cbHandshake.TabIndex = 23;
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "标记为1",
            "保留为0"});
            this.cbParity.Location = new System.Drawing.Point(118, 183);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 20);
            this.cbParity.TabIndex = 22;
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(118, 147);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbStopBits.TabIndex = 21;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(118, 111);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbDataBits.TabIndex = 20;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(118, 75);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbBaudRate.TabIndex = 19;
            // 
            // lblHandshake
            // 
            this.lblHandshake.AutoSize = true;
            this.lblHandshake.Location = new System.Drawing.Point(27, 222);
            this.lblHandshake.Name = "lblHandshake";
            this.lblHandshake.Size = new System.Drawing.Size(77, 12);
            this.lblHandshake.TabIndex = 18;
            this.lblHandshake.Text = "数据流控制：";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(27, 186);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(77, 12);
            this.lblParity.TabIndex = 17;
            this.lblParity.Text = "奇偶校验位：";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(27, 150);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(53, 12);
            this.lblStopBits.TabIndex = 16;
            this.lblStopBits.Text = "停止位：";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(27, 114);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(53, 12);
            this.lblDataBits.TabIndex = 15;
            this.lblDataBits.Text = "数据位：";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(27, 78);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(53, 12);
            this.lblBaudRate.TabIndex = 14;
            this.lblBaudRate.Text = "波特率：";
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(118, 39);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 20);
            this.cbName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "串口号：";
            // 
            // gbSendData
            // 
            this.gbSendData.Controls.Add(this.btnClearSendText);
            this.gbSendData.Controls.Add(this.btnSend);
            this.gbSendData.Controls.Add(this.txtSend);
            this.gbSendData.Enabled = false;
            this.gbSendData.Location = new System.Drawing.Point(292, 12);
            this.gbSendData.Name = "gbSendData";
            this.gbSendData.Size = new System.Drawing.Size(418, 162);
            this.gbSendData.TabIndex = 2;
            this.gbSendData.TabStop = false;
            this.gbSendData.Text = "数据发送区域";
            // 
            // btnClearSendText
            // 
            this.btnClearSendText.Location = new System.Drawing.Point(351, 96);
            this.btnClearSendText.Name = "btnClearSendText";
            this.btnClearSendText.Size = new System.Drawing.Size(56, 54);
            this.btnClearSendText.TabIndex = 3;
            this.btnClearSendText.Text = "清除";
            this.btnClearSendText.UseVisualStyleBackColor = true;
            this.btnClearSendText.Click += new System.EventHandler(this.btnClearSendText_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(351, 25);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 54);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.OnBtnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 25);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(329, 125);
            this.txtSend.TabIndex = 1;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxKeyDown);
            // 
            // gbReceiveData
            // 
            this.gbReceiveData.Controls.Add(this.btnCopyToClipboard);
            this.gbReceiveData.Controls.Add(this.btnClearReceiveText);
            this.gbReceiveData.Controls.Add(this.txtReceive);
            this.gbReceiveData.Enabled = false;
            this.gbReceiveData.Location = new System.Drawing.Point(292, 184);
            this.gbReceiveData.Name = "gbReceiveData";
            this.gbReceiveData.Size = new System.Drawing.Size(418, 169);
            this.gbReceiveData.TabIndex = 3;
            this.gbReceiveData.TabStop = false;
            this.gbReceiveData.Text = "数据接收区域";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(351, 20);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(56, 54);
            this.btnCopyToClipboard.TabIndex = 4;
            this.btnCopyToClipboard.Text = "复制";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnClearReceiveText
            // 
            this.btnClearReceiveText.Location = new System.Drawing.Point(351, 103);
            this.btnClearReceiveText.Name = "btnClearReceiveText";
            this.btnClearReceiveText.Size = new System.Drawing.Size(56, 54);
            this.btnClearReceiveText.TabIndex = 3;
            this.btnClearReceiveText.Text = "清除";
            this.btnClearReceiveText.UseVisualStyleBackColor = true;
            this.btnClearReceiveText.Click += new System.EventHandler(this.btnClearReceiveText_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(12, 20);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(329, 137);
            this.txtReceive.TabIndex = 0;
            this.txtReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxKeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 365);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(723, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "状态栏";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 17);
            this.lblStatus.Text = "就绪";
            // 
            // timerStatusChanged
            // 
            this.timerStatusChanged.Interval = 3000;
            this.timerStatusChanged.Tick += new System.EventHandler(this.timerStatusChanged_Tick);
            // 
            // SerialMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 387);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbReceiveData);
            this.Controls.Add(this.gbSendData);
            this.Controls.Add(this.gbParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialMaster";
            this.Text = "SerialMaster";
            this.Load += new System.EventHandler(this.SerialMaster_Load);
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbSendData.ResumeLayout(false);
            this.gbSendData.PerformLayout();
            this.gbReceiveData.ResumeLayout(false);
            this.gbReceiveData.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label lblHandshake;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox gbReceiveData;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.Button btnClearSendText;
        private System.Windows.Forms.Button btnClearReceiveText;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Timer timerStatusChanged;
    }
}

