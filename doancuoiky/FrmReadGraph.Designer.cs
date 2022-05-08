namespace doancuoiky
{
    partial class FrmReadGraph
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInputError = new System.Windows.Forms.Label();
            this.btnRandomW = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txbNhapDinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTipReadFile = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReadFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(622, 12);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(104, 47);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Đọc File";
            this.toolTipReadFile.SetToolTip(this.btnReadFile, "Dòng đầu là số nguyên n (số đỉnh).\r\nn dòng tiếp theo là ma trận kề, \r\nvà n dòng t" +
        "iếp theo tên đỉnh theo thứ tự (nếu có) ");
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điền thủ công ma trận ở phía dưới hoặc nhấn nút đọc file";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 649);
            this.panel2.TabIndex = 1;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatrix.Location = new System.Drawing.Point(0, 56);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(1297, 593);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInputError);
            this.panel3.Controls.Add(this.btnRandomW);
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Controls.Add(this.txbNhapDinh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 56);
            this.panel3.TabIndex = 0;
            // 
            // lblInputError
            // 
            this.lblInputError.AutoSize = true;
            this.lblInputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputError.ForeColor = System.Drawing.Color.Red;
            this.lblInputError.Location = new System.Drawing.Point(770, 14);
            this.lblInputError.Name = "lblInputError";
            this.lblInputError.Size = new System.Drawing.Size(460, 22);
            this.lblInputError.TabIndex = 0;
            this.lblInputError.Text = "Điền thủ công ma trận ở phía dưới hoặc nhấn nút đọc file";
            this.lblInputError.Visible = false;
            // 
            // btnRandomW
            // 
            this.btnRandomW.Location = new System.Drawing.Point(399, 4);
            this.btnRandomW.Name = "btnRandomW";
            this.btnRandomW.Size = new System.Drawing.Size(201, 47);
            this.btnRandomW.TabIndex = 1;
            this.btnRandomW.Text = "Trọng số ngẫu nhiên";
            this.btnRandomW.UseVisualStyleBackColor = true;
            this.btnRandomW.Click += new System.EventHandler(this.btnRandomW_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(622, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(104, 47);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txbNhapDinh
            // 
            this.txbNhapDinh.Location = new System.Drawing.Point(132, 14);
            this.txbNhapDinh.MaxLength = 2;
            this.txbNhapDinh.Name = "txbNhapDinh";
            this.txbNhapDinh.Size = new System.Drawing.Size(100, 26);
            this.txbNhapDinh.TabIndex = 1;
            this.txbNhapDinh.TextChanged += new System.EventHandler(this.txbNhapDinh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chỉ tối đa 15 đỉnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số đỉnh";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTipReadFile
            // 
            this.toolTipReadFile.AutoPopDelay = 10000;
            this.toolTipReadFile.InitialDelay = 500;
            this.toolTipReadFile.ReshowDelay = 100;
            // 
            // FrmReadGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReadGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReadGraph";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lblInputError;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txbNhapDinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandomW;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTipReadFile;
    }
}