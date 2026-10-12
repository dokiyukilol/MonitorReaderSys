namespace MonitorReader
{
    partial class FrmDataMonitor
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
            panel1 = new Panel();
            txtSlaveId = new TextBox();
            btnConnection = new Button();
            btnRefresh = new Button();
            cboStopBits = new ComboBox();
            cboDataBits = new ComboBox();
            cboParity = new ComboBox();
            cboBaudRate = new ComboBox();
            cboPorts = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblMsgTime = new Label();
            lblMsg = new Label();
            tlpDatas = new TableLayoutPanel();
            panelLights = new Panel();
            chkLight05 = new CheckBox();
            chkLight04 = new CheckBox();
            chkLight03 = new CheckBox();
            chkLight02 = new CheckBox();
            chkLight01 = new CheckBox();
            chkAll = new CheckBox();
            label10 = new Label();
            label26 = new Label();
            label22 = new Label();
            label18 = new Label();
            label16 = new Label();
            label13 = new Label();
            lblState05 = new Label();
            lblState04 = new Label();
            lblState03 = new Label();
            lblState02 = new Label();
            lblState01 = new Label();
            lblStateAll = new Label();
            label11 = new Label();
            panel5 = new Panel();
            label37 = new Label();
            label9 = new Label();
            label36 = new Label();
            lblState_B = new Label();
            lblCurValue_B = new Label();
            label34 = new Label();
            lblHValue_B = new Label();
            label33 = new Label();
            lblLValue_B = new Label();
            label32 = new Label();
            panel4 = new Panel();
            label20 = new Label();
            label21 = new Label();
            lblState_H = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            lblLValue_H = new Label();
            lblHValue_H = new Label();
            lblCurValue_H = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label15 = new Label();
            label14 = new Label();
            lblState_T = new Label();
            label12 = new Label();
            label19 = new Label();
            label17 = new Label();
            lblLValue_T = new Label();
            lblHValue_T = new Label();
            lblCurValue_T = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tlpDatas.SuspendLayout();
            panelLights.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtSlaveId);
            panel1.Controls.Add(btnConnection);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(cboStopBits);
            panel1.Controls.Add(cboDataBits);
            panel1.Controls.Add(cboParity);
            panel1.Controls.Add(cboBaudRate);
            panel1.Controls.Add(cboPorts);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 31);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 98);
            panel1.TabIndex = 0;
            // 
            // txtSlaveId
            // 
            txtSlaveId.Location = new Point(74, 59);
            txtSlaveId.Margin = new Padding(2, 3, 2, 3);
            txtSlaveId.Name = "txtSlaveId";
            txtSlaveId.Size = new Size(110, 23);
            txtSlaveId.TabIndex = 3;
            // 
            // btnConnection
            // 
            btnConnection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnection.BackColor = Color.Blue;
            btnConnection.FlatAppearance.BorderSize = 0;
            btnConnection.FlatStyle = FlatStyle.Flat;
            btnConnection.ForeColor = Color.White;
            btnConnection.Location = new Point(923, 12);
            btnConnection.Margin = new Padding(2, 3, 2, 3);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(81, 34);
            btnConnection.TabIndex = 2;
            btnConnection.Text = "连接设备";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 192, 192);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(191, 18);
            btnRefresh.Margin = new Padding(2, 3, 2, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(51, 25);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cboStopBits
            // 
            cboStopBits.FormattingEnabled = true;
            cboStopBits.Location = new Point(792, 19);
            cboStopBits.Margin = new Padding(2, 3, 2, 3);
            cboStopBits.Name = "cboStopBits";
            cboStopBits.Size = new Size(97, 25);
            cboStopBits.TabIndex = 1;
            // 
            // cboDataBits
            // 
            cboDataBits.FormattingEnabled = true;
            cboDataBits.Location = new Point(632, 19);
            cboDataBits.Margin = new Padding(2, 3, 2, 3);
            cboDataBits.Name = "cboDataBits";
            cboDataBits.Size = new Size(97, 25);
            cboDataBits.TabIndex = 1;
            // 
            // cboParity
            // 
            cboParity.FormattingEnabled = true;
            cboParity.Location = new Point(467, 18);
            cboParity.Margin = new Padding(2, 3, 2, 3);
            cboParity.Name = "cboParity";
            cboParity.Size = new Size(97, 25);
            cboParity.TabIndex = 1;
            // 
            // cboBaudRate
            // 
            cboBaudRate.FormattingEnabled = true;
            cboBaudRate.Location = new Point(303, 19);
            cboBaudRate.Margin = new Padding(2, 3, 2, 3);
            cboBaudRate.Name = "cboBaudRate";
            cboBaudRate.Size = new Size(97, 25);
            cboBaudRate.TabIndex = 1;
            // 
            // cboPorts
            // 
            cboPorts.FormattingEnabled = true;
            cboPorts.Location = new Point(74, 19);
            cboPorts.Margin = new Padding(2, 3, 2, 3);
            cboPorts.Name = "cboPorts";
            cboPorts.Size = new Size(110, 25);
            cboPorts.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(745, 21);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 0;
            label5.Text = "停止位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(585, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 0;
            label4.Text = "数据位";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(421, 21);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 0;
            label3.Text = "校验位";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(256, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 0;
            label2.Text = "波特率";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(16, 62);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 0;
            label6.Text = "设备地址";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(16, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "通讯端口";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblMsgTime);
            panel2.Controls.Add(lblMsg);
            panel2.Location = new Point(17, 523);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 51);
            panel2.TabIndex = 1;
            // 
            // lblMsgTime
            // 
            lblMsgTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMsgTime.Location = new Point(864, 8);
            lblMsgTime.Margin = new Padding(2, 0, 2, 0);
            lblMsgTime.Name = "lblMsgTime";
            lblMsgTime.Size = new Size(143, 34);
            lblMsgTime.TabIndex = 0;
            lblMsgTime.Text = "2025-05-19 16:13:52";
            lblMsgTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            lblMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMsg.ForeColor = Color.Green;
            lblMsg.Location = new Point(12, 8);
            lblMsg.Margin = new Padding(2, 0, 2, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(745, 34);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "等待连接涂装车间环境控制器...";
            lblMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpDatas
            // 
            tlpDatas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDatas.BackColor = Color.SlateGray;
            tlpDatas.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tlpDatas.ColumnCount = 4;
            tlpDatas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDatas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDatas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDatas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDatas.Controls.Add(panelLights, 3, 0);
            tlpDatas.Controls.Add(panel5, 2, 0);
            tlpDatas.Controls.Add(panel4, 1, 0);
            tlpDatas.Controls.Add(panel3, 0, 0);
            tlpDatas.Location = new Point(17, 150);
            tlpDatas.Margin = new Padding(2, 3, 2, 3);
            tlpDatas.Name = "tlpDatas";
            tlpDatas.RowCount = 1;
            tlpDatas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDatas.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tlpDatas.Size = new Size(1018, 352);
            tlpDatas.TabIndex = 2;
            // 
            // panelLights
            // 
            panelLights.BackColor = Color.White;
            panelLights.Controls.Add(chkLight05);
            panelLights.Controls.Add(chkLight04);
            panelLights.Controls.Add(chkLight03);
            panelLights.Controls.Add(chkLight02);
            panelLights.Controls.Add(chkLight01);
            panelLights.Controls.Add(chkAll);
            panelLights.Controls.Add(label10);
            panelLights.Controls.Add(label26);
            panelLights.Controls.Add(label22);
            panelLights.Controls.Add(label18);
            panelLights.Controls.Add(label16);
            panelLights.Controls.Add(label13);
            panelLights.Controls.Add(lblState05);
            panelLights.Controls.Add(lblState04);
            panelLights.Controls.Add(lblState03);
            panelLights.Controls.Add(lblState02);
            panelLights.Controls.Add(lblState01);
            panelLights.Controls.Add(lblStateAll);
            panelLights.Controls.Add(label11);
            panelLights.Dock = DockStyle.Fill;
            panelLights.Location = new Point(764, 6);
            panelLights.Margin = new Padding(2, 3, 2, 3);
            panelLights.Name = "panelLights";
            panelLights.Size = new Size(249, 340);
            panelLights.TabIndex = 3;
            // 
            // chkLight05
            // 
            chkLight05.AutoSize = true;
            chkLight05.Location = new Point(109, 297);
            chkLight05.Margin = new Padding(2, 3, 2, 3);
            chkLight05.Name = "chkLight05";
            chkLight05.Size = new Size(15, 14);
            chkLight05.TabIndex = 14;
            chkLight05.Tag = "4";
            chkLight05.UseVisualStyleBackColor = true;
            chkLight05.Click += chkLight_Click;
            // 
            // chkLight04
            // 
            chkLight04.AutoSize = true;
            chkLight04.Location = new Point(109, 254);
            chkLight04.Margin = new Padding(2, 3, 2, 3);
            chkLight04.Name = "chkLight04";
            chkLight04.Size = new Size(15, 14);
            chkLight04.TabIndex = 14;
            chkLight04.Tag = "3";
            chkLight04.UseVisualStyleBackColor = true;
            chkLight04.Click += chkLight_Click;
            // 
            // chkLight03
            // 
            chkLight03.AutoSize = true;
            chkLight03.Location = new Point(109, 217);
            chkLight03.Margin = new Padding(2, 3, 2, 3);
            chkLight03.Name = "chkLight03";
            chkLight03.Size = new Size(15, 14);
            chkLight03.TabIndex = 14;
            chkLight03.Tag = "2";
            chkLight03.UseVisualStyleBackColor = true;
            chkLight03.Click += chkLight_Click;
            // 
            // chkLight02
            // 
            chkLight02.AutoSize = true;
            chkLight02.Checked = true;
            chkLight02.CheckState = CheckState.Checked;
            chkLight02.Location = new Point(109, 174);
            chkLight02.Margin = new Padding(2, 3, 2, 3);
            chkLight02.Name = "chkLight02";
            chkLight02.Size = new Size(15, 14);
            chkLight02.TabIndex = 14;
            chkLight02.Tag = "1";
            chkLight02.UseVisualStyleBackColor = true;
            chkLight02.Click += chkLight_Click;
            // 
            // chkLight01
            // 
            chkLight01.AutoSize = true;
            chkLight01.Location = new Point(109, 133);
            chkLight01.Margin = new Padding(2, 3, 2, 3);
            chkLight01.Name = "chkLight01";
            chkLight01.Size = new Size(15, 14);
            chkLight01.TabIndex = 14;
            chkLight01.Tag = "0";
            chkLight01.UseVisualStyleBackColor = true;
            chkLight01.Click += chkLight_Click;
            // 
            // chkAll
            // 
            chkAll.AutoSize = true;
            chkAll.Location = new Point(109, 86);
            chkAll.Margin = new Padding(2, 3, 2, 3);
            chkAll.Name = "chkAll";
            chkAll.Size = new Size(15, 14);
            chkAll.TabIndex = 14;
            chkAll.Tag = "all";
            chkAll.UseVisualStyleBackColor = true;
            chkAll.Click += chkAll_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.Location = new Point(9, 18);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(126, 26);
            label10.TabIndex = 1;
            label10.Text = "通风设备状态";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label26.Location = new Point(40, 291);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(84, 20);
            label26.TabIndex = 13;
            label26.Text = "声光报警：";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label22.Location = new Point(40, 250);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(69, 20);
            label22.TabIndex = 13;
            label22.Text = "水帘泵：";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label18.Location = new Point(40, 211);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 13;
            label18.Text = "新风阀：";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label16.Location = new Point(40, 169);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(69, 20);
            label16.TabIndex = 13;
            label16.Text = "排风机：";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.Location = new Point(40, 130);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 13;
            label13.Text = "送风机：";
            // 
            // lblState05
            // 
            lblState05.BackColor = Color.Gray;
            lblState05.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblState05.ForeColor = Color.White;
            lblState05.Location = new Point(150, 287);
            lblState05.Margin = new Padding(2, 0, 2, 0);
            lblState05.Name = "lblState05";
            lblState05.Size = new Size(42, 26);
            lblState05.TabIndex = 13;
            lblState05.Tag = "4";
            lblState05.Text = "停止";
            lblState05.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblState04
            // 
            lblState04.BackColor = Color.Gray;
            lblState04.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblState04.ForeColor = Color.White;
            lblState04.Location = new Point(150, 248);
            lblState04.Margin = new Padding(2, 0, 2, 0);
            lblState04.Name = "lblState04";
            lblState04.Size = new Size(42, 26);
            lblState04.TabIndex = 13;
            lblState04.Tag = "3";
            lblState04.Text = "停止";
            lblState04.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblState03
            // 
            lblState03.BackColor = Color.Gray;
            lblState03.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblState03.ForeColor = Color.White;
            lblState03.Location = new Point(150, 209);
            lblState03.Margin = new Padding(2, 0, 2, 0);
            lblState03.Name = "lblState03";
            lblState03.Size = new Size(42, 26);
            lblState03.TabIndex = 13;
            lblState03.Tag = "2";
            lblState03.Text = "停止";
            lblState03.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblState02
            // 
            lblState02.BackColor = Color.Orange;
            lblState02.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblState02.ForeColor = Color.White;
            lblState02.Location = new Point(150, 167);
            lblState02.Margin = new Padding(2, 0, 2, 0);
            lblState02.Name = "lblState02";
            lblState02.Size = new Size(42, 26);
            lblState02.TabIndex = 13;
            lblState02.Tag = "1";
            lblState02.Text = "停止";
            lblState02.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblState01
            // 
            lblState01.BackColor = Color.Gray;
            lblState01.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblState01.ForeColor = Color.White;
            lblState01.Location = new Point(150, 128);
            lblState01.Margin = new Padding(2, 0, 2, 0);
            lblState01.Name = "lblState01";
            lblState01.Size = new Size(42, 26);
            lblState01.TabIndex = 13;
            lblState01.Tag = "0";
            lblState01.Text = "停止";
            lblState01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStateAll
            // 
            lblStateAll.BackColor = Color.Gray;
            lblStateAll.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblStateAll.ForeColor = Color.White;
            lblStateAll.Location = new Point(150, 78);
            lblStateAll.Margin = new Padding(2, 0, 2, 0);
            lblStateAll.Name = "lblStateAll";
            lblStateAll.Size = new Size(42, 26);
            lblStateAll.TabIndex = 13;
            lblStateAll.Tag = "all";
            lblStateAll.Text = "全部停止";
            lblStateAll.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label11.Location = new Point(28, 81);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 13;
            label11.Text = "集中控制：";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label37);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label36);
            panel5.Controls.Add(lblState_B);
            panel5.Controls.Add(lblCurValue_B);
            panel5.Controls.Add(label34);
            panel5.Controls.Add(lblHValue_B);
            panel5.Controls.Add(label33);
            panel5.Controls.Add(lblLValue_B);
            panel5.Controls.Add(label32);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(511, 6);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 340);
            panel5.TabIndex = 2;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label37.Location = new Point(18, 259);
            label37.Margin = new Padding(2, 0, 2, 0);
            label37.Name = "label37";
            label37.Size = new Size(99, 20);
            label37.TabIndex = 12;
            label37.Text = "历史最低值：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.Location = new Point(9, 18);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(88, 26);
            label9.TabIndex = 1;
            label9.Text = "排风风速";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label36.Location = new Point(18, 184);
            label36.Margin = new Padding(2, 0, 2, 0);
            label36.Name = "label36";
            label36.Size = new Size(99, 20);
            label36.TabIndex = 13;
            label36.Text = "历史最高值：";
            // 
            // lblState_B
            // 
            lblState_B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblState_B.BackColor = Color.DarkTurquoise;
            lblState_B.ForeColor = Color.White;
            lblState_B.Location = new Point(166, 58);
            lblState_B.Margin = new Padding(2, 0, 2, 0);
            lblState_B.Name = "lblState_B";
            lblState_B.Size = new Size(61, 29);
            lblState_B.TabIndex = 11;
            lblState_B.Text = "正常";
            lblState_B.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurValue_B
            // 
            lblCurValue_B.AutoSize = true;
            lblCurValue_B.Font = new Font("微软雅黑", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCurValue_B.Location = new Point(36, 112);
            lblCurValue_B.Margin = new Padding(2, 0, 2, 0);
            lblCurValue_B.Name = "lblCurValue_B";
            lblCurValue_B.Size = new Size(83, 40);
            lblCurValue_B.TabIndex = 10;
            lblCurValue_B.Text = "0.00";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(142, 118);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(57, 34);
            label34.TabIndex = 5;
            label34.Text = "m/s";
            // 
            // lblHValue_B
            // 
            lblHValue_B.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblHValue_B.Location = new Point(52, 217);
            lblHValue_B.Margin = new Padding(2, 0, 2, 0);
            lblHValue_B.Name = "lblHValue_B";
            lblHValue_B.Size = new Size(58, 26);
            lblHValue_B.TabIndex = 9;
            lblHValue_B.Text = "0.00";
            lblHValue_B.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label33.Location = new Point(121, 293);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(47, 25);
            label33.TabIndex = 6;
            label33.Text = "m/s";
            // 
            // lblLValue_B
            // 
            lblLValue_B.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblLValue_B.Location = new Point(52, 293);
            lblLValue_B.Margin = new Padding(2, 0, 2, 0);
            lblLValue_B.Name = "lblLValue_B";
            lblLValue_B.Size = new Size(58, 26);
            lblLValue_B.TabIndex = 8;
            lblLValue_B.Text = "0.00";
            lblLValue_B.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label32.Location = new Point(121, 217);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(47, 25);
            label32.TabIndex = 7;
            label32.Text = "m/s";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(lblState_H);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(lblLValue_H);
            panel4.Controls.Add(lblHValue_H);
            panel4.Controls.Add(lblCurValue_H);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(258, 6);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 340);
            panel4.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label20.Location = new Point(17, 253);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(99, 20);
            label20.TabIndex = 12;
            label20.Text = "历史最低值：";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label21.Location = new Point(17, 178);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(99, 20);
            label21.TabIndex = 13;
            label21.Text = "历史最高值：";
            // 
            // lblState_H
            // 
            lblState_H.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblState_H.BackColor = Color.CornflowerBlue;
            lblState_H.ForeColor = Color.White;
            lblState_H.Location = new Point(165, 58);
            lblState_H.Margin = new Padding(2, 0, 2, 0);
            lblState_H.Name = "lblState_H";
            lblState_H.Size = new Size(61, 29);
            lblState_H.TabIndex = 11;
            lblState_H.Text = "正常";
            lblState_H.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(166, 112);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(40, 34);
            label23.TabIndex = 5;
            label23.Text = "%";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label24.Location = new Point(121, 287);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(29, 25);
            label24.TabIndex = 6;
            label24.Text = "%";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label25.Location = new Point(121, 211);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(29, 25);
            label25.TabIndex = 7;
            label25.Text = "%";
            // 
            // lblLValue_H
            // 
            lblLValue_H.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblLValue_H.Location = new Point(51, 287);
            lblLValue_H.Margin = new Padding(2, 0, 2, 0);
            lblLValue_H.Name = "lblLValue_H";
            lblLValue_H.Size = new Size(58, 26);
            lblLValue_H.TabIndex = 8;
            lblLValue_H.Text = "20";
            lblLValue_H.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHValue_H
            // 
            lblHValue_H.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblHValue_H.Location = new Point(51, 211);
            lblHValue_H.Margin = new Padding(2, 0, 2, 0);
            lblHValue_H.Name = "lblHValue_H";
            lblHValue_H.Size = new Size(58, 26);
            lblHValue_H.TabIndex = 9;
            lblHValue_H.Text = "98";
            lblHValue_H.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurValue_H
            // 
            lblCurValue_H.AutoSize = true;
            lblCurValue_H.Font = new Font("微软雅黑", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCurValue_H.Location = new Point(35, 106);
            lblCurValue_H.Margin = new Padding(2, 0, 2, 0);
            lblCurValue_H.Name = "lblCurValue_H";
            lblCurValue_H.Size = new Size(55, 40);
            lblCurValue_H.TabIndex = 10;
            lblCurValue_H.Text = "80";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(9, 18);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 26);
            label8.TabIndex = 1;
            label8.Text = "车间湿度";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(lblState_T);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(lblLValue_T);
            panel3.Controls.Add(lblHValue_T);
            panel3.Controls.Add(lblCurValue_T);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 6);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 340);
            panel3.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label15.Location = new Point(16, 253);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(99, 20);
            label15.TabIndex = 4;
            label15.Text = "历史最低值：";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label14.Location = new Point(16, 178);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 4;
            label14.Text = "历史最高值：";
            // 
            // lblState_T
            // 
            lblState_T.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblState_T.BackColor = Color.Blue;
            lblState_T.ForeColor = Color.White;
            lblState_T.Location = new Point(165, 58);
            lblState_T.Margin = new Padding(2, 0, 2, 0);
            lblState_T.Name = "lblState_T";
            lblState_T.Size = new Size(61, 29);
            lblState_T.TabIndex = 3;
            lblState_T.Text = "正常";
            lblState_T.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(166, 112);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 34);
            label12.TabIndex = 2;
            label12.Text = "℃";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label19.Location = new Point(120, 287);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(31, 25);
            label19.TabIndex = 2;
            label19.Text = "℃";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label17.Location = new Point(120, 211);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(31, 25);
            label17.TabIndex = 2;
            label17.Text = "℃";
            // 
            // lblLValue_T
            // 
            lblLValue_T.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblLValue_T.Location = new Point(51, 287);
            lblLValue_T.Margin = new Padding(2, 0, 2, 0);
            lblLValue_T.Name = "lblLValue_T";
            lblLValue_T.Size = new Size(58, 26);
            lblLValue_T.TabIndex = 2;
            lblLValue_T.Text = "5.5";
            lblLValue_T.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHValue_T
            // 
            lblHValue_T.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblHValue_T.Location = new Point(51, 211);
            lblHValue_T.Margin = new Padding(2, 0, 2, 0);
            lblHValue_T.Name = "lblHValue_T";
            lblHValue_T.Size = new Size(58, 26);
            lblHValue_T.TabIndex = 2;
            lblHValue_T.Text = "25.5";
            lblHValue_T.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurValue_T
            // 
            lblCurValue_T.AutoSize = true;
            lblCurValue_T.Font = new Font("微软雅黑", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCurValue_T.Location = new Point(34, 106);
            lblCurValue_T.Margin = new Padding(2, 0, 2, 0);
            lblCurValue_T.Name = "lblCurValue_T";
            lblCurValue_T.Size = new Size(83, 40);
            lblCurValue_T.TabIndex = 2;
            lblCurValue_T.Text = "25.5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.Location = new Point(9, 18);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 26);
            label7.TabIndex = 1;
            label7.Text = "车间温度";
            // 
            // FrmDataMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 604);
            Controls.Add(tlpDatas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1071, 643);
            Name = "FrmDataMonitor";
            ShowIcon = false;
            Text = "环境监控";
            Load += FrmDataMonitor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tlpDatas.ResumeLayout(false);
            panelLights.ResumeLayout(false);
            panelLights.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tlpDatas;
        private Panel panelLights;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btnRefresh;
        private ComboBox cboPorts;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label1;
        private TextBox txtSlaveId;
        private Button btnConnection;
        private ComboBox cboStopBits;
        private ComboBox cboDataBits;
        private ComboBox cboParity;
        private ComboBox cboBaudRate;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label lblState_T;
        private Label label12;
        private Label lblCurValue_T;
        private Label label37;
        private Label label36;
        private Label lblState_B;
        private Label lblCurValue_B;
        private Label label34;
        private Label lblHValue_B;
        private Label label33;
        private Label lblLValue_B;
        private Label label32;
        private Label label20;
        private Label label21;
        private Label lblState_H;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label lblLValue_H;
        private Label lblHValue_H;
        private Label lblCurValue_H;
        private Label label15;
        private Label label14;
        private Label label19;
        private Label label17;
        private Label lblLValue_T;
        private Label lblHValue_T;
        private Label label26;
        private Label label22;
        private Label label18;
        private Label label16;
        private Label label13;
        private Label label11;
        private CheckBox chkLight05;
        private CheckBox chkLight04;
        private CheckBox chkLight03;
        private CheckBox chkLight02;
        private CheckBox chkLight01;
        private CheckBox chkAll;
        private Label lblStateAll;
        private Label lblState05;
        private Label lblState04;
        private Label lblState03;
        private Label lblState02;
        private Label lblState01;
        private Label lblMsgTime;
        private Label lblMsg;
    }
}