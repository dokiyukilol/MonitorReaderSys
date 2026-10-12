namespace MonitorReader
{
    partial class FrmSend
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblShow = new Label();
            label1 = new Label();
            txtSend = new TextBox();
            btnSend = new Button();
            btnClear = new Button();
            lvMsgList = new ListView();
            col01 = new ColumnHeader();
            colContent = new ColumnHeader();
            colTime = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(txtSend);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblShow);
            groupBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(28, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 610);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "车间看板";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(lvMsgList);
            groupBox2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(680, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(618, 610);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "报警与操作记录";
            // 
            // lblShow
            // 
            lblShow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblShow.BackColor = Color.Black;
            lblShow.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblShow.ForeColor = Color.Cyan;
            lblShow.Location = new Point(29, 44);
            lblShow.Name = "lblShow";
            lblShow.Padding = new Padding(5);
            lblShow.Size = new Size(567, 195);
            lblShow.TabIndex = 0;
            lblShow.Text = "联南家具·涂装车间";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(29, 250);
            label1.Name = "label1";
            label1.Size = new Size(292, 20);
            label1.TabIndex = 1;
            label1.Text = "说明：下发的字符串(英文字符不超过60个)\r\n";
            // 
            // txtSend
            // 
            txtSend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSend.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtSend.Location = new Point(29, 302);
            txtSend.Multiline = true;
            txtSend.Name = "txtSend";
            txtSend.Size = new Size(565, 196);
            txtSend.TabIndex = 2;
            txtSend.Text = "联南家具·涂装车间";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Goldenrod;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Microsoft YaHei UI", 9F);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(61, 527);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(140, 50);
            btnSend.TabIndex = 3;
            btnSend.Text = "发送信息";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft YaHei UI", 9F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(274, 527);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 50);
            btnClear.TabIndex = 3;
            btnClear.Text = "清空信息";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lvMsgList
            // 
            lvMsgList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvMsgList.BorderStyle = BorderStyle.None;
            lvMsgList.Columns.AddRange(new ColumnHeader[] { col01, colContent, colTime });
            lvMsgList.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lvMsgList.Location = new Point(17, 32);
            lvMsgList.Name = "lvMsgList";
            lvMsgList.Size = new Size(583, 561);
            lvMsgList.TabIndex = 0;
            lvMsgList.UseCompatibleStateImageBehavior = false;
            lvMsgList.View = View.Details;
            // 
            // col01
            // 
            col01.Width = 0;
            // 
            // colContent
            // 
            colContent.Text = "消息内容";
            colContent.Width = 380;
            // 
            // colTime
            // 
            colTime.Text = "发送时间";
            colTime.Width = 200;
            // 
            // FrmSend
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1332, 697);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSend";
            ShowIcon = false;
            Text = "车间看板";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblShow;
        private GroupBox groupBox2;
        private TextBox txtSend;
        private Label label1;
        private Button btnClear;
        private Button btnSend;
        private ListView lvMsgList;
        private ColumnHeader col01;
        private ColumnHeader colContent;
        private ColumnHeader colTime;
    }
}