using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancuoiky
{
    public partial class AddEdge : Form
    {
        public int di = -1, den = -1;
        public string trongso = "";
        private int sodinh;
        public AddEdge()
        {
            InitializeComponent();
        }

        public AddEdge(string[] tendinh, int sodinh) : this()
        {
            for (int i = 0; i < sodinh; i++)
            {
                cbBeginAdd.Items.Add(tendinh[i]);
                cbEndAdd.Items.Add(tendinh[i]);
            }
        }

        private void txbTrongSo_TextChanged(object sender, EventArgs e)
        {
            int check;
            if (txbTrongSo.Text.Length > 0)
            {
                if (!int.TryParse(txbTrongSo.Text, out check))
                {
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Visible = false;
                }
            }
        }

        private void btnCancelAddEdge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            if (cbBeginAdd.SelectedIndex != -1 && cbEndAdd.SelectedIndex != -1 && txbTrongSo.Text.Length > 0)
            {
                if (cbEndAdd.SelectedIndex == cbBeginAdd.SelectedIndex)
                {
                    MessageBox.Show("Đỉnh bắt đầu và đỉnh kết thúc không được trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int check;
                    if (int.TryParse(txbTrongSo.Text, out check))
                    {
                        di = cbBeginAdd.SelectedIndex;
                        den = cbEndAdd.SelectedIndex;
                        trongso = txbTrongSo.Text;
                        this.Close();
                    }
                }
            }
        }
    }
}
