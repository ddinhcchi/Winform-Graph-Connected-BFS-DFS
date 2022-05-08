namespace doancuoiky
{
    partial class DoiTenDinh
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
            this.lblChangeName = new System.Windows.Forms.Label();
            this.txbChangeName = new System.Windows.Forms.TextBox();
            this.btnSaveChangeName = new System.Windows.Forms.Button();
            this.btnCancelChangeName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeName
            // 
            this.lblChangeName.AutoSize = true;
            this.lblChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeName.Location = new System.Drawing.Point(138, 91);
            this.lblChangeName.Name = "lblChangeName";
            this.lblChangeName.Size = new System.Drawing.Size(236, 25);
            this.lblChangeName.TabIndex = 0;
            this.lblChangeName.Text = "Đổi tên cho đỉnh V0 thành";
            // 
            // txbChangeName
            // 
            this.txbChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChangeName.Location = new System.Drawing.Point(421, 88);
            this.txbChangeName.Name = "txbChangeName";
            this.txbChangeName.Size = new System.Drawing.Size(100, 30);
            this.txbChangeName.TabIndex = 1;
            // 
            // btnSaveChangeName
            // 
            this.btnSaveChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChangeName.Location = new System.Drawing.Point(217, 182);
            this.btnSaveChangeName.Name = "btnSaveChangeName";
            this.btnSaveChangeName.Size = new System.Drawing.Size(87, 37);
            this.btnSaveChangeName.TabIndex = 2;
            this.btnSaveChangeName.Text = "Lưu";
            this.btnSaveChangeName.UseVisualStyleBackColor = true;
            this.btnSaveChangeName.Click += new System.EventHandler(this.btnSaveChangeName_Click);
            // 
            // btnCancelChangeName
            // 
            this.btnCancelChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChangeName.Location = new System.Drawing.Point(409, 182);
            this.btnCancelChangeName.Name = "btnCancelChangeName";
            this.btnCancelChangeName.Size = new System.Drawing.Size(87, 37);
            this.btnCancelChangeName.TabIndex = 2;
            this.btnCancelChangeName.Text = "Hủy";
            this.btnCancelChangeName.UseVisualStyleBackColor = true;
            this.btnCancelChangeName.Click += new System.EventHandler(this.btnCancelChangeName_Click);
            // 
            // DoiTenDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 281);
            this.Controls.Add(this.btnCancelChangeName);
            this.Controls.Add(this.btnSaveChangeName);
            this.Controls.Add(this.txbChangeName);
            this.Controls.Add(this.lblChangeName);
            this.Name = "DoiTenDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoiTenDinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeName;
        private System.Windows.Forms.TextBox txbChangeName;
        private System.Windows.Forms.Button btnSaveChangeName;
        private System.Windows.Forms.Button btnCancelChangeName;
    }
}