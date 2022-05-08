namespace doancuoiky
{
    partial class AddEdge
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
            this.cbBeginAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEndAdd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTrongSo = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnCancelAddEdge = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBeginAdd
            // 
            this.cbBeginAdd.FormattingEnabled = true;
            this.cbBeginAdd.Location = new System.Drawing.Point(387, 62);
            this.cbBeginAdd.Name = "cbBeginAdd";
            this.cbBeginAdd.Size = new System.Drawing.Size(121, 28);
            this.cbBeginAdd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đỉnh bắt đầu";
            // 
            // cbEndAdd
            // 
            this.cbEndAdd.FormattingEnabled = true;
            this.cbEndAdd.Location = new System.Drawing.Point(387, 123);
            this.cbEndAdd.Name = "cbEndAdd";
            this.cbEndAdd.Size = new System.Drawing.Size(121, 28);
            this.cbEndAdd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trọng số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đỉnh kết thúc";
            // 
            // txbTrongSo
            // 
            this.txbTrongSo.Location = new System.Drawing.Point(387, 191);
            this.txbTrongSo.Name = "txbTrongSo";
            this.txbTrongSo.Size = new System.Drawing.Size(121, 26);
            this.txbTrongSo.TabIndex = 2;
            this.txbTrongSo.TextChanged += new System.EventHandler(this.txbTrongSo_TextChanged);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdge.Location = new System.Drawing.Point(215, 282);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(92, 41);
            this.btnAddEdge.TabIndex = 3;
            this.btnAddEdge.Text = "Thêm";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnCancelAddEdge
            // 
            this.btnCancelAddEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddEdge.Location = new System.Drawing.Point(416, 282);
            this.btnCancelAddEdge.Name = "btnCancelAddEdge";
            this.btnCancelAddEdge.Size = new System.Drawing.Size(92, 41);
            this.btnCancelAddEdge.TabIndex = 3;
            this.btnCancelAddEdge.Text = "Hủy";
            this.btnCancelAddEdge.UseVisualStyleBackColor = true;
            this.btnCancelAddEdge.Click += new System.EventHandler(this.btnCancelAddEdge_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(226, 233);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(282, 25);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Dữ liệu trọng số không hợp lệ!!!";
            this.lblError.Visible = false;
            // 
            // AddEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelAddEdge);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.txbTrongSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEndAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBeginAdd);
            this.Name = "AddEdge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEdge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBeginAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEndAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTrongSo;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnCancelAddEdge;
        private System.Windows.Forms.Label lblError;
    }
}