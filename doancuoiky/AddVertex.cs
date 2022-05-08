﻿using System;
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
    public partial class AddVertex : Form
    {
        public string tenthem = "";
        public AddVertex()
        {
            InitializeComponent();
        }

        private void btnSaveAddVertex_Click(object sender, EventArgs e)
        {
            if (txbAddVertex.Text.Length > 0 && kiemtraten(txbAddVertex.Text))
            {
                tenthem = txbAddVertex.Text;
                this.Close();
            }
        }

        private bool kiemtraten(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ') return true;
            }
            return false;
        }

        private void btnCancelAddVertex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
