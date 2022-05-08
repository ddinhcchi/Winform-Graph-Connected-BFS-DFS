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
    public partial class DoiTenDinh : Form
    {
        private string _mess;
        public string namechange = "";
        public DoiTenDinh()
        {
            InitializeComponent();
        }

        public DoiTenDinh(string Message) : this()
        {
            _mess = Message;
            lblChangeName.Text = _mess;
        }

        private void btnSaveChangeName_Click(object sender, EventArgs e)
        {
            if (txbChangeName.Text.Length > 0)
            {
                namechange = txbChangeName.Text;
                this.Close();
            }
        }

        private void btnCancelChangeName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
