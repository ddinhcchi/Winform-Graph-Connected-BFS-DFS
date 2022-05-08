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
    public partial class DoiTrongSo : Form
    {
        private string _mess1, _mess2;
        public string edgechange = "";
        public DoiTrongSo()
        {
            InitializeComponent();
        }

        private void btnSaveChangeEdge_Click(object sender, EventArgs e)
        {
            int check;
            if (txbChangeEdge.Text.Length > 0)
            {
                if (int.TryParse(txbChangeEdge.Text, out check))
                {
                    edgechange = txbChangeEdge.Text;
                    this.Close();
                }
            }
        }

        private void txbChangeEdge_TextChanged(object sender, EventArgs e)
        {
            int check;
            if (txbChangeEdge.Text.Length > 0)
            {
                if (!int.TryParse(txbChangeEdge.Text, out check))
                {
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Visible = false;
                }
            }
        }

        private void btnCancelSaveCE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DoiTrongSo(string mess1, string mess2) : this()
        {
            _mess1 = mess1;
            _mess2 = mess2;
            lblChangedEdge.Text = "Đổi trọng số từ đỉnh " + _mess1 + " đến đỉnh " + _mess2;
        }
    }
}
