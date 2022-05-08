using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancuoiky
{
    public partial class FrmReadGraph : Form
    {
        public FrmReadGraph()
        {
            InitializeComponent();
        }

        public int sodinh;
        public int[,] mt = new int[50, 50];         // 3 field public truyen ra ngoai
        public string[] ten = new string[50];
        public bool checkhople = false;
        int h = 20, m = 3;
        int[] mangts = new int[2500];
        int dem = 0;
        Random rnd = new Random();        

        private void txbNhapDinh_TextChanged(object sender, EventArgs e)
        {
            if (txbNhapDinh.Text != "")
            {
                if (!int.TryParse(txbNhapDinh.Text.Trim(), out sodinh))
                {
                    pnlMatrix.Controls.Clear();
                    lblInputError.Text = "Nhập sai dữ liệu số đỉnh";
                    lblInputError.Visible = true;
                }
                else if (sodinh == 0)
                {
                    pnlMatrix.Controls.Clear();
                    lblInputError.Text = "Số đỉnh phải lớn hơn 0";
                    lblInputError.Visible = true;
                }
                else if (sodinh > 15)
                {
                    pnlMatrix.Controls.Clear();
                    lblInputError.Text = "Chỉ tối đa 15 đỉnh";
                    lblInputError.Visible = true;
                }
                else
                {
                    lblInputError.Visible = false;
                    int x = 3, y = 3;
                    pnlMatrix.Controls.Clear();
                    for (int i = 0; i <= sodinh; i++)
                    {
                        for (int j = 0; j <= sodinh; j++)
                        {
                            mt[i, j] = int.MinValue;
                            TextBox a = new TextBox();
                            a.Multiline = true;
                            a.Width = 50;
                            a.Height = h;
                            if (i == 0 && j == 0)
                            {
                                a.ReadOnly = true;
                                a.Text = $"*";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    a.ReadOnly = true;
                                    a.Text = $"V{j - 1}";
                                }
                                if (j == 0)
                                {
                                    a.ReadOnly = true;
                                    a.Text = $"V{i - 1}";
                                }
                                if (i == j)
                                {
                                    a.ReadOnly = true;
                                    a.Text = $"0";
                                }
                                if (i > j && j != 0)
                                {
                                    a.ReadOnly = true;
                                    a.Text = "";
                                }
                            }
                            a.Location = new Point(x, y);
                            pnlMatrix.Controls.Add(a);
                            x += m + 50;
                        }
                        x = 3;
                        y += m + h;
                    }
                }
            }
            else
            {
                pnlMatrix.Controls.Clear();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (sodinh > 0)
            {
                bool kt = true;

                for (int i = 0; i < sodinh; i++)
                {
                    ten[i] = "V" + i.ToString();
                }

                foreach (TextBox textBox in pnlMatrix.Controls)
                {
                    int trongso;
                    if (!textBox.ReadOnly)
                    {
                        try
                        {
                            if (textBox.Text == "∞" || int.Parse(textBox.Text) < 0 || int.Parse(textBox.Text) == 0) trongso = int.MinValue;
                            else trongso = int.Parse(textBox.Text);
                            mangts[dem++] = trongso;
                        }
                        catch
                        {
                            kt = false;
                            MessageBox.Show("Lỗi nhập liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                if (kt)
                {
                    dem = 0;
                    for (int i = 0; i < sodinh - 1; i++)
                    {
                        for (int j = i + 1; j < sodinh; j++)
                        {
                            if (i != j)
                            {
                                if (mangts[dem] == int.MinValue) mt[i, j] = mt[j, i] = int.MinValue;
                                else
                                {

                                    mt[i, j] = mt[j, i] = mangts[dem];
                                }
                                dem++;
                            }
                        }
                    }
                    dem = 0;
                    checkhople = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền ma trận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;            //lấy địa chỉ
                string[] line = File.ReadAllLines(path);    //đọc tất cả các dòng

                bool kt = true;

                if (!int.TryParse(line[0].Trim(), out sodinh))
                {
                    kt = false;
                    MessageBox.Show("Dữ liệu trong file không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (sodinh > 15)
                {
                    MessageBox.Show("Số đỉnh không lớn hơn 15", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < sodinh; i++)
                    {
                        string[] weight = line[i + 1].Split(' ');
                        try
                        {
                            for (int j = 0; j < sodinh; j++)
                            {
                                if (weight[j] == "∞" || weight[j] == "0" || int.Parse(weight[j]) < 0) mt[i, j] = int.MinValue;          //sửa lại (<0,==0,==∞) và !tryparse --> messagebox
                                else
                                {
                                    mt[i, j] = int.Parse(weight[j]);
                                }
                            }
                        }

                        catch
                        {
                            kt = false;
                            MessageBox.Show("Dữ liệu trong file không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (kt)
                    {
                        for (int j = 0; j < sodinh; j++)        //có tên thì lấy, không có tên thì để mặc định
                        {
                            string name;
                            try
                            {
                                name = line[sodinh + 1 + j].Trim();
                            }
                            catch
                            {
                                name = $"V{j}";
                            }
                            ten[j] = name;
                        }

                        XetDoThiHopLe x = new XetDoThiHopLe();
                        XetDoThiHopLe.DoThi dt = new XetDoThiHopLe.DoThi();
                        dt.iSodinh = sodinh;
                        dt.iMaTran = mt;

                        if (x.KiemTraDonDoThiDonVoHuong(dt))
                        {
                            if (path != "")
                            {
                                checkhople = true;
                                this.Close();
                                MessageBox.Show("Đọc file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chương trình chỉ sử dụng được với đơn đồ thị vô hướng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnRandomW_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in pnlMatrix.Controls)
            {
                if (!textBox.ReadOnly)
                {
                    int trongso = rnd.Next(-1000, 1000);
                    if (trongso < 0) textBox.Text = "0";
                    else textBox.Text = trongso.ToString();
                }
            }
        }


    }
}
