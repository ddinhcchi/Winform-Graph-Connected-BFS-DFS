namespace doancuoiky
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstvEdge = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTMCanh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmCạnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaCạnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbDinh = new System.Windows.Forms.ListBox();
            this.CMTDinh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmĐỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaĐỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReadGraph = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnLienThong = new System.Windows.Forms.Button();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBegin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChucNang = new System.Windows.Forms.Label();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CTMCanh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CMTDinh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnReadGraph);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1391, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 1024);
            this.panel1.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(237, 67);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(104, 52);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Đổi đẳng cấu";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstvEdge);
            this.groupBox2.Location = new System.Drawing.Point(234, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 514);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cạnh";
            // 
            // lstvEdge
            // 
            this.lstvEdge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvEdge.ContextMenuStrip = this.CTMCanh;
            this.lstvEdge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvEdge.FullRowSelect = true;
            this.lstvEdge.GridLines = true;
            this.lstvEdge.HideSelection = false;
            this.lstvEdge.Location = new System.Drawing.Point(3, 22);
            this.lstvEdge.MultiSelect = false;
            this.lstvEdge.Name = "lstvEdge";
            this.lstvEdge.Size = new System.Drawing.Size(251, 489);
            this.lstvEdge.TabIndex = 0;
            this.lstvEdge.UseCompatibleStateImageBehavior = false;
            this.lstvEdge.View = System.Windows.Forms.View.Details;
            this.lstvEdge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvEdge_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Begin";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "End";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edge";
            this.columnHeader3.Width = 80;
            // 
            // CTMCanh
            // 
            this.CTMCanh.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CTMCanh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmCạnhToolStripMenuItem,
            this.xóaCạnhToolStripMenuItem});
            this.CTMCanh.Name = "CTMCanh";
            this.CTMCanh.Size = new System.Drawing.Size(171, 64);
            // 
            // thêmCạnhToolStripMenuItem
            // 
            this.thêmCạnhToolStripMenuItem.Name = "thêmCạnhToolStripMenuItem";
            this.thêmCạnhToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.thêmCạnhToolStripMenuItem.Text = "Thêm cạnh";
            this.thêmCạnhToolStripMenuItem.Click += new System.EventHandler(this.thêmCạnhToolStripMenuItem_Click);
            // 
            // xóaCạnhToolStripMenuItem
            // 
            this.xóaCạnhToolStripMenuItem.Name = "xóaCạnhToolStripMenuItem";
            this.xóaCạnhToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.xóaCạnhToolStripMenuItem.Text = "Xóa cạnh";
            this.xóaCạnhToolStripMenuItem.Click += new System.EventHandler(this.xóaCạnhToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbDinh);
            this.groupBox1.Location = new System.Drawing.Point(40, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 514);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đỉnh";
            // 
            // lstbDinh
            // 
            this.lstbDinh.ContextMenuStrip = this.CMTDinh;
            this.lstbDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbDinh.FormattingEnabled = true;
            this.lstbDinh.ItemHeight = 20;
            this.lstbDinh.Location = new System.Drawing.Point(3, 22);
            this.lstbDinh.Name = "lstbDinh";
            this.lstbDinh.Size = new System.Drawing.Size(147, 489);
            this.lstbDinh.TabIndex = 0;
            this.lstbDinh.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbDinh_MouseDoubleClick);
            // 
            // CMTDinh
            // 
            this.CMTDinh.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMTDinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmĐỉnhToolStripMenuItem,
            this.xóaĐỉnhToolStripMenuItem});
            this.CMTDinh.Name = "CMTDinh";
            this.CMTDinh.Size = new System.Drawing.Size(169, 64);
            // 
            // thêmĐỉnhToolStripMenuItem
            // 
            this.thêmĐỉnhToolStripMenuItem.Name = "thêmĐỉnhToolStripMenuItem";
            this.thêmĐỉnhToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.thêmĐỉnhToolStripMenuItem.Text = "Thêm đỉnh";
            this.thêmĐỉnhToolStripMenuItem.Click += new System.EventHandler(this.thêmĐỉnhToolStripMenuItem_Click);
            // 
            // xóaĐỉnhToolStripMenuItem
            // 
            this.xóaĐỉnhToolStripMenuItem.Name = "xóaĐỉnhToolStripMenuItem";
            this.xóaĐỉnhToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.xóaĐỉnhToolStripMenuItem.Text = "Xóa đỉnh";
            this.xóaĐỉnhToolStripMenuItem.Click += new System.EventHandler(this.xóaĐỉnhToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(387, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 52);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReadGraph
            // 
            this.btnReadGraph.Location = new System.Drawing.Point(40, 65);
            this.btnReadGraph.Name = "btnReadGraph";
            this.btnReadGraph.Size = new System.Drawing.Size(153, 52);
            this.btnReadGraph.TabIndex = 0;
            this.btnReadGraph.Text = "Điền ma trận đồ thị";
            this.btnReadGraph.UseVisualStyleBackColor = true;
            this.btnReadGraph.Click += new System.EventHandler(this.btnReadGraph_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(772, 70);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(108, 47);
            this.btnBFS.TabIndex = 5;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(575, 70);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(108, 47);
            this.btnDFS.TabIndex = 5;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnLienThong
            // 
            this.btnLienThong.Location = new System.Drawing.Point(348, 70);
            this.btnLienThong.Name = "btnLienThong";
            this.btnLienThong.Size = new System.Drawing.Size(136, 47);
            this.btnLienThong.TabIndex = 5;
            this.btnLienThong.Text = "Xét Liên Thông";
            this.btnLienThong.UseVisualStyleBackColor = true;
            this.btnLienThong.Click += new System.EventHandler(this.btnLienThong_Click);
            // 
            // cbEnd
            // 
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(759, 25);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(121, 28);
            this.cbEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đỉnh kết thúc";
            // 
            // cbBegin
            // 
            this.cbBegin.FormattingEnabled = true;
            this.cbBegin.Location = new System.Drawing.Point(462, 25);
            this.cbBegin.Name = "cbBegin";
            this.cbBegin.Size = new System.Drawing.Size(121, 28);
            this.cbBegin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đỉnh bắt đầu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1391, 1024);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1391, 1024);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblChucNang);
            this.panel4.Controls.Add(this.cbEnd);
            this.panel4.Controls.Add(this.btnBFS);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbKetQua);
            this.panel4.Controls.Add(this.cbBegin);
            this.panel4.Controls.Add(this.btnDFS);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSaveFile);
            this.panel4.Controls.Add(this.btnLienThong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1391, 177);
            this.panel4.TabIndex = 1;
            // 
            // lblChucNang
            // 
            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucNang.ForeColor = System.Drawing.Color.Red;
            this.lblChucNang.Location = new System.Drawing.Point(108, 139);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(108, 25);
            this.lblChucNang.TabIndex = 0;
            this.lblChucNang.Text = "Chức năng";
            // 
            // txbKetQua
            // 
            this.txbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKetQua.Location = new System.Drawing.Point(348, 136);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.ReadOnly = true;
            this.txbKetQua.Size = new System.Drawing.Size(674, 30);
            this.txbKetQua.TabIndex = 1;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFile.Location = new System.Drawing.Point(1256, 130);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(135, 47);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Lưu ma trận";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1391, 1024);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFS-BFS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.CTMCanh.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.CMTDinh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReadGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnLienThong;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstvEdge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbDinh;
        private System.Windows.Forms.TextBox txbKetQua;
        private System.Windows.Forms.Label lblChucNang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip CTMCanh;
        private System.Windows.Forms.ToolStripMenuItem thêmCạnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaCạnhToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMTDinh;
        private System.Windows.Forms.ToolStripMenuItem thêmĐỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaĐỉnhToolStripMenuItem;
    }
}

