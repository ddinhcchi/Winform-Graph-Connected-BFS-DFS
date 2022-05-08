namespace doancuoiky
{
    partial class DoiTrongSo
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
            this.lblChangedEdge = new System.Windows.Forms.Label();
            this.txbChangeEdge = new System.Windows.Forms.TextBox();
            this.btnSaveChangeEdge = new System.Windows.Forms.Button();
            this.btnCancelSaveCE = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChangedEdge
            // 
            this.lblChangedEdge.AutoSize = true;
            this.lblChangedEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangedEdge.Location = new System.Drawing.Point(69, 125);
            this.lblChangedEdge.Name = "lblChangedEdge";
            this.lblChangedEdge.Size = new System.Drawing.Size(373, 25);
            this.lblChangedEdge.TabIndex = 0;
            this.lblChangedEdge.Text = "Đổi trọng số từ đỉnh V0 đến đỉnh V1 thành";
            // 
            // txbChangeEdge
            // 
            this.txbChangeEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChangeEdge.Location = new System.Drawing.Point(495, 125);
            this.txbChangeEdge.Name = "txbChangeEdge";
            this.txbChangeEdge.Size = new System.Drawing.Size(100, 30);
            this.txbChangeEdge.TabIndex = 1;
            this.txbChangeEdge.TextChanged += new System.EventHandler(this.txbChangeEdge_TextChanged);
            // 
            // btnSaveChangeEdge
            // 
            this.btnSaveChangeEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChangeEdge.Location = new System.Drawing.Point(220, 217);
            this.btnSaveChangeEdge.Name = "btnSaveChangeEdge";
            this.btnSaveChangeEdge.Size = new System.Drawing.Size(84, 39);
            this.btnSaveChangeEdge.TabIndex = 2;
            this.btnSaveChangeEdge.Text = "Lưu";
            this.btnSaveChangeEdge.UseVisualStyleBackColor = true;
            this.btnSaveChangeEdge.Click += new System.EventHandler(this.btnSaveChangeEdge_Click);
            // 
            // btnCancelSaveCE
            // 
            this.btnCancelSaveCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSaveCE.Location = new System.Drawing.Point(424, 217);
            this.btnCancelSaveCE.Name = "btnCancelSaveCE";
            this.btnCancelSaveCE.Size = new System.Drawing.Size(84, 39);
            this.btnCancelSaveCE.TabIndex = 2;
            this.btnCancelSaveCE.Text = "Hủy";
            this.btnCancelSaveCE.UseVisualStyleBackColor = true;
            this.btnCancelSaveCE.Click += new System.EventHandler(this.btnCancelSaveCE_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(215, 170);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(293, 25);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Dữ liệu nhập vào không hợp lệ!!!";
            this.lblError.Visible = false;
            // 
            // DoiTrongSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 371);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelSaveCE);
            this.Controls.Add(this.btnSaveChangeEdge);
            this.Controls.Add(this.txbChangeEdge);
            this.Controls.Add(this.lblChangedEdge);
            this.Name = "DoiTrongSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoiTrongSo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangedEdge;
        private System.Windows.Forms.TextBox txbChangeEdge;
        private System.Windows.Forms.Button btnSaveChangeEdge;
        private System.Windows.Forms.Button btnCancelSaveCE;
        private System.Windows.Forms.Label lblError;
    }
}