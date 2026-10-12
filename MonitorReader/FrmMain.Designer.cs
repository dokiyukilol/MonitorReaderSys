namespace MonitorReader
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnShow = new Button();
            btnTrends = new Button();
            btnDataMonitor = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 66);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.DeepSkyBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1108, 19);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "退出系统";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 31);
            label1.TabIndex = 1;
            label1.Text = "联南家具涂装车间监控系统";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnShow);
            panel2.Controls.Add(btnTrends);
            panel2.Controls.Add(btnDataMonitor);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1205, 62);
            panel2.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.DeepSkyBlue;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Microsoft YaHei UI", 10.8F);
            btnShow.ForeColor = Color.Black;
            btnShow.Location = new Point(243, 12);
            btnShow.Margin = new Padding(2, 3, 2, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(101, 47);
            btnShow.TabIndex = 5;
            btnShow.Text = "车间看板";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnTrends
            // 
            btnTrends.BackColor = Color.DeepSkyBlue;
            btnTrends.FlatAppearance.BorderSize = 0;
            btnTrends.FlatStyle = FlatStyle.Flat;
            btnTrends.Font = new Font("Microsoft YaHei UI", 10.8F);
            btnTrends.ForeColor = Color.Black;
            btnTrends.Location = new Point(127, 12);
            btnTrends.Margin = new Padding(2, 3, 2, 3);
            btnTrends.Name = "btnTrends";
            btnTrends.Size = new Size(101, 47);
            btnTrends.TabIndex = 4;
            btnTrends.Text = "实时趋势";
            btnTrends.UseVisualStyleBackColor = false;
            btnTrends.Click += btnTrends_Click;
            // 
            // btnDataMonitor
            // 
            btnDataMonitor.BackColor = Color.DeepSkyBlue;
            btnDataMonitor.FlatAppearance.BorderSize = 0;
            btnDataMonitor.FlatStyle = FlatStyle.Flat;
            btnDataMonitor.Font = new Font("Microsoft YaHei UI", 10.8F);
            btnDataMonitor.ForeColor = Color.Black;
            btnDataMonitor.Location = new Point(11, 12);
            btnDataMonitor.Margin = new Padding(2, 3, 2, 3);
            btnDataMonitor.Name = "btnDataMonitor";
            btnDataMonitor.Size = new Size(101, 47);
            btnDataMonitor.TabIndex = 3;
            btnDataMonitor.Text = "环境监控";
            btnDataMonitor.UseVisualStyleBackColor = false;
            btnDataMonitor.Click += btnDataMonitor_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 689);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1221, 728);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "联南家具涂装车间监控系统";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Label label1;
        private Panel panel2;
        private Button btnShow;
        private Button btnTrends;
        private Button btnDataMonitor;
    }
}
