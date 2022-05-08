namespace doancuoiky
{
    partial class AddVertex
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddVertex = new System.Windows.Forms.TextBox();
            this.btnSaveAddVertex = new System.Windows.Forms.Button();
            this.btnCancelAddVertex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điền tên đỉnh bạn muốn thêm";
            // 
            // txbAddVertex
            // 
            this.txbAddVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddVertex.Location = new System.Drawing.Point(381, 100);
            this.txbAddVertex.Name = "txbAddVertex";
            this.txbAddVertex.Size = new System.Drawing.Size(140, 30);
            this.txbAddVertex.TabIndex = 1;
            // 
            // btnSaveAddVertex
            // 
            this.btnSaveAddVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddVertex.Location = new System.Drawing.Point(177, 170);
            this.btnSaveAddVertex.Name = "btnSaveAddVertex";
            this.btnSaveAddVertex.Size = new System.Drawing.Size(83, 40);
            this.btnSaveAddVertex.TabIndex = 2;
            this.btnSaveAddVertex.Text = "Lưu";
            this.btnSaveAddVertex.UseVisualStyleBackColor = true;
            this.btnSaveAddVertex.Click += new System.EventHandler(this.btnSaveAddVertex_Click);
            // 
            // btnCancelAddVertex
            // 
            this.btnCancelAddVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddVertex.Location = new System.Drawing.Point(349, 170);
            this.btnCancelAddVertex.Name = "btnCancelAddVertex";
            this.btnCancelAddVertex.Size = new System.Drawing.Size(83, 40);
            this.btnCancelAddVertex.TabIndex = 2;
            this.btnCancelAddVertex.Text = "Hủy";
            this.btnCancelAddVertex.UseVisualStyleBackColor = true;
            this.btnCancelAddVertex.Click += new System.EventHandler(this.btnCancelAddVertex_Click);
            // 
            // AddVertex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 254);
            this.Controls.Add(this.btnCancelAddVertex);
            this.Controls.Add(this.btnSaveAddVertex);
            this.Controls.Add(this.txbAddVertex);
            this.Controls.Add(this.label1);
            this.Name = "AddVertex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddVertex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddVertex;
        private System.Windows.Forms.Button btnSaveAddVertex;
        private System.Windows.Forms.Button btnCancelAddVertex;
    }
}