using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancuoiky
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        Point[] Dinh = new Point[50];   //vi tri cua dinh tren picturebox
        public int mSoDinh = 0;       //luu so dinh cua do thi
        string[] mTenDinh = new string[50];  //luu ten dinh
        int[,] mMT = new int[50, 50];        //luu trong so
        int SoDinhLienThong = 0;        //luu lai so dinh lien thong tren mot mien lien thong / luu lai so dinh trong chuoi duyet BFS hoac DFS

        Color color = Color.Black;      //mau chu mac dinh tren picturebox

        //Form doi trong so
        int dinhdi, dinhden;
        
        public struct LienThong_Paint
        {
            public int index;
            public int r;
            public int b;
            public int g;
        };

        LienThong_Paint[] paint = new LienThong_Paint[50];

        private void btnReadGraph_Click(object sender, EventArgs e)
        {
            FrmReadGraph f = new FrmReadGraph();
            f.ShowDialog();
            if (f.checkhople)
            {
                RefreshForm();
                mTenDinh = f.ten;
                mSoDinh = f.sodinh;
                mMT = f.mt;

                for (int i = 0; i < mSoDinh; i++)
                {
                    TaoViTriDinh(i);
                }
                LoadLVCB();
                pictureBox1.Refresh();
            }
        }

        private void btnLienThong_Click(object sender, EventArgs e)
        {
            if (mSoDinh > 0)
            {
                string[] tp_lienThong = new string[50];
                KiemTraLienThong x = new KiemTraLienThong();
                KiemTraLienThong.DoThi doThi = new KiemTraLienThong.DoThi();
                doThi.iMaTran = mMT;
                doThi.iSoDinh = mSoDinh;
                tp_lienThong = x.xuatMienLienThong(doThi);
                int SoMienLT = int.Parse(tp_lienThong[0]);
                //Hiển thị kết quả
                if (SoMienLT == 1)
                {
                    lblChucNang.Text = "Đồ thị liên thông!!!";
                    txbKetQua.Text = "Đồ thị chỉ có một miền liên thông.";
                }
                else
                {
                    lblChucNang.Text = "Đồ thị không liên thông!!!";
                    txbKetQua.Text = "Đồ thị có " + SoMienLT.ToString() + " miền liên thông.";
                }

                //chọn màu ngẫu nhiên cho các miền liên thông
                for (int i = 1; i <= SoMienLT; i++)
                {
                    Random rnd = new Random();
                    while (true)
                    {
                        int r = rnd.Next(0, 256);
                        int b = rnd.Next(0, 256);
                        int g = rnd.Next(0, 256);
                        if (r != b && r != g && g != r && KtMau(r, b, g) == true)
                        {
                            string[] tachtp = tp_lienThong[i].Split(' '); //tplienthong 2 [1 2 3 4 5] [6 7 8 9 10]
                            foreach (string dinhlienthong in tachtp)
                            {
                                if (dinhlienthong != "")
                                {
                                    paint[SoDinhLienThong].index = int.Parse(dinhlienthong);
                                    paint[SoDinhLienThong].r = r;
                                    paint[SoDinhLienThong].b = b;
                                    paint[SoDinhLienThong].g = g;
                                    SoDinhLienThong++;
                                }
                            }
                            break;
                        }
                        else continue;
                    }
                }
                pictureBox1.Refresh();
                SoDinhLienThong = 0;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền ma trận", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            if (cbBegin.SelectedIndex != -1 && cbEnd.SelectedIndex != -1)
            {
                lblChucNang.Text = "Duyệt DFS";
                string xuattxb = "";
                int batdau = 0;
                int ketthuc = mSoDinh - 1;
                if (cbBegin.SelectedIndex == 0)
                {
                    if (cbEnd.SelectedIndex != 0)
                    {
                        ketthuc = cbEnd.SelectedIndex - 1;
                    }
                }
                else
                {
                    if (cbBegin.SelectedIndex != 1)
                    {
                        batdau = cbBegin.SelectedIndex - 1;
                        if (cbEnd.SelectedIndex != 0)
                        {
                            ketthuc = cbEnd.SelectedIndex - 1;
                        }
                    }
                    else
                    {
                        if (cbEnd.SelectedIndex != 0)
                        {
                            ketthuc = cbEnd.SelectedIndex - 1;
                        }
                    }
                }
                DFS x = new DFS();
                x.DFSsodinh = mSoDinh;
                x.DFSmt = mMT;
                x.duyetDFS(batdau, ketthuc);
                if (x.ketqua == "")
                {
                    xuattxb = "Không có đường đi từ đỉnh " + mTenDinh[batdau] + " đến đỉnh " + mTenDinh[ketthuc];
                }
                else
                {
                    int r = 228;
                    int b = 30;
                    int g = 30;
                    string[] tachtp = x.ketqua.Split(' ');
                    for (int i = 0; i < tachtp.Length; i++)
                    {
                        if (tachtp[i] != "")
                        {
                            if (i != tachtp.Length - 1)
                            {
                                xuattxb = "-->" + mTenDinh[int.Parse(tachtp[i])]  + xuattxb;
                            }
                            else
                            {
                                xuattxb = mTenDinh[int.Parse(tachtp[i])] + xuattxb;
                            }

                            paint[SoDinhLienThong].index = int.Parse(tachtp[i]);
                            paint[SoDinhLienThong].r = r;
                            paint[SoDinhLienThong].b = b;
                            paint[SoDinhLienThong].g = g;
                            SoDinhLienThong++;
                        }
                    }
                }
                txbKetQua.Text = xuattxb;
                pictureBox1.Refresh();
                SoDinhLienThong = 0;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền ma trận", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            if (cbBegin.SelectedIndex != -1 && cbEnd.SelectedIndex != -1)
            {
                lblChucNang.Text = "Duyệt BFS";
                string xuattxb = "";
                int batdau = 0;
                int ketthuc = mSoDinh - 1;
                if (cbBegin.SelectedIndex == 0)
                {
                    if (cbEnd.SelectedIndex != 0)
                    {
                        ketthuc = cbEnd.SelectedIndex - 1;
                    }
                }
                else
                {
                    if (cbBegin.SelectedIndex != 1)
                    {
                        batdau = cbBegin.SelectedIndex - 1;
                        if (cbEnd.SelectedIndex != 0)
                        {
                            ketthuc = cbEnd.SelectedIndex - 1;
                        }
                    }
                    else
                    {
                        if (cbEnd.SelectedIndex != 0)
                        {
                            ketthuc = cbEnd.SelectedIndex - 1;
                        }
                    }
                }
                BFS x = new BFS();
                x.BFSsodinh = mSoDinh;
                x.BFSmt = mMT;
                x.duyetBFS(batdau, ketthuc);
                if (x.ketqua == "")
                {
                    xuattxb = "Không có đường đi từ đỉnh " + mTenDinh[batdau] + " đến đỉnh " + mTenDinh[ketthuc];
                }
                else
                {
                    int r = 239;
                    int b = 84;
                    int g = 7;
                    string[] tachtp = x.ketqua.Split(' ');
                    for (int i = 0; i < tachtp.Length; i++)
                    {
                        if (tachtp[i] != "")
                        {
                            if (i != tachtp.Length - 1)
                            {
                                xuattxb = "-->" + mTenDinh[int.Parse(tachtp[i])] + xuattxb;
                            }
                            else
                            {
                                xuattxb = mTenDinh[int.Parse(tachtp[i])] + xuattxb;
                            }

                            paint[SoDinhLienThong].index = int.Parse(tachtp[i]);
                            paint[SoDinhLienThong].r = r;
                            paint[SoDinhLienThong].b = b;
                            paint[SoDinhLienThong].g = g;
                            SoDinhLienThong++;
                        }
                    }
                }
                txbKetQua.Text = xuattxb;
                pictureBox1.Refresh();
                SoDinhLienThong = 0;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền ma trận", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g;
            SolidBrush maunenDinh = new SolidBrush(Color.YellowGreen);
            SolidBrush mauchuDinh = new SolidBrush(Color.Black);
            SolidBrush khoangtrong = new SolidBrush(Color.White);
            Pen line = new Pen(maunenDinh);
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            System.Drawing.Font f2 = new System.Drawing.Font(lblChucNang.Font.Name, 13, FontStyle.Bold);

            if (SoDinhLienThong == 0)
            {
                for (int i = 0; i < mSoDinh; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (mMT[i, j] != int.MinValue)
                        {
                            g.DrawLine(line, Dinh[i], Dinh[j]);
                            g.FillEllipse(khoangtrong, (Dinh[i].X + Dinh[j].X) / 2 - 5, (Dinh[i].Y + Dinh[j].Y) / 2 - 5, 5, 5);
                            g.DrawString(mMT[i, j].ToString(), f2, mauchuDinh, (Dinh[i].X + Dinh[j].X) / 2 - 5, (Dinh[i].Y + Dinh[j].Y) / 2 - 5);
                        }
                    }
                }
                for (int i = 0; i < mSoDinh; i++)
                {
                    g.FillEllipse(maunenDinh, Dinh[i].X - 10, Dinh[i].Y - 10, 30, 30);
                    g.DrawString(mTenDinh[i], f2, mauchuDinh, Dinh[i].X - 5, Dinh[i].Y - 5);
                }
            }
            if (SoDinhLienThong > 0)
            {
                for (int i = 0; i < SoDinhLienThong; i++)
                {
                    SolidBrush maulienthong = new SolidBrush(Color.FromArgb(paint[i].r, paint[i].b, paint[i].g));
                    
                    for (int j = 0; j < SoDinhLienThong; j++)
                    {
                        if (paint[i].r == paint[j].r && paint[i].b == paint[j].b && paint[i].g == paint[j].g && mMT[paint[i].index, paint[j].index] != int.MinValue)
                        {
                            maulienthong = new SolidBrush(Color.FromArgb(paint[i].r, paint[i].b, paint[i].g));
                            Pen paintLienThong = new Pen(maulienthong);
                            g.DrawLine(paintLienThong, Dinh[paint[i].index], Dinh[paint[j].index]);
                            g.FillEllipse(khoangtrong, (Dinh[paint[i].index].X + Dinh[paint[j].index].X) / 2 - 5, (Dinh[paint[i].index].Y + Dinh[paint[j].index].Y) / 2 - 5, 10, 10);
                            g.DrawString(mMT[paint[i].index, paint[j].index].ToString(), f2, maulienthong, (Dinh[paint[i].index].X + Dinh[paint[j].index].X) / 2 - 5, (Dinh[paint[i].index].Y + Dinh[paint[j].index].Y) / 2 - 5);
                        }
                    }

                    g.FillEllipse(maulienthong, Dinh[paint[i].index].X - 10, Dinh[paint[i].index].Y - 10, 30, 30);
                    g.DrawString(mTenDinh[paint[i].index], f2, new SolidBrush(Color.Black), Dinh[paint[i].index].X - 5, Dinh[paint[i].index].Y - 5);
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (mSoDinh != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string save = mSoDinh.ToString() + "\n";
                    for (int i = 0; i < mSoDinh; i++)
                    {
                        for (int j = 0; j < mSoDinh; j++)
                        {
                            if (mMT[i, j] == int.MinValue) save += "0 ";
                            else save += mMT[i, j].ToString() + " ";
                        }
                        save += "\n";
                    }
                    for (int i = 0; i < mSoDinh; i++)
                    {
                        save += mTenDinh[i];
                        if (i < mSoDinh - 1) save += "\n";
                    }
                    StreamWriter stream = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    stream.WriteLine(save);
                    stream.Close();
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstbDinh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstbDinh.Items.Count > 0 && lstbDinh.SelectedIndex >= 0)
            {
                string changename = "Đổi tên đỉnh " + mTenDinh[lstbDinh.SelectedIndex] + " thành:";
                DoiTenDinh f = new DoiTenDinh(changename);
                f.ShowDialog();

                if (f.namechange != "")
                {
                    bool flag = true;
                    for (int i = 0; i < mSoDinh; i++)
                    {
                        if (f.namechange == mTenDinh[i])
                        {
                            flag = false;
                            MessageBox.Show("Tên mới đổi trùng với một đỉnh đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (flag)
                    {
                        mTenDinh[lstbDinh.SelectedIndex] = f.namechange;
                        LoadLVCB();
                    }
                }
            }
        }

        private void lstvEdge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string vertexbegin = lstvEdge.SelectedItems[0].SubItems[0].Text;
            string vertexend = lstvEdge.SelectedItems[0].SubItems[1].Text;

            for (int i = 0; i < mSoDinh; i++)
            {
                if (mTenDinh[i] == vertexbegin) dinhdi = i;
                if (mTenDinh[i] == vertexend) dinhden = i;
            }

            DoiTrongSo f = new DoiTrongSo(vertexbegin, vertexend);
            f.ShowDialog();

            if (f.edgechange != "")
            {
                if (int.Parse(f.edgechange) == 0 || int.Parse(f.edgechange) < 0)
                {
                    DialogResult t = MessageBox.Show("Trọng số bằng 0 hoặc âm đồng nghĩa với xóa cạnh\nBạn chắc chắn muốn xóa cạnh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (t == DialogResult.Yes)
                    {
                        mMT[dinhdi, dinhden] = int.MinValue;
                        mMT[dinhden, dinhdi] = int.MinValue;
                        LoadLVCB();
                    }
                }
                else
                {
                    mMT[dinhdi, dinhden] = int.Parse(f.edgechange);
                    mMT[dinhden, dinhdi] = int.Parse(f.edgechange);
                    LoadLVCB();
                }
            }
        }

        private void thêmCạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mSoDinh > 0)
            {
                AddEdge f = new AddEdge(mTenDinh, mSoDinh);
                f.ShowDialog();

                if (f.den != -1 && f.di != -1 && f.trongso != "")
                {
                    if (mMT[f.di, f.den] != int.MinValue && mMT[f.den, f.di] != int.MinValue)
                    {
                        DialogResult r = MessageBox.Show("Cạnh " + mTenDinh[f.di] + mTenDinh[f.den] + " đã tồn tại\nBạn có muốn thay đổi trọng số không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (r == DialogResult.Yes)
                        {
                            if (int.Parse(f.trongso) == 0 || int.Parse(f.trongso) < 0)
                            {
                                DialogResult t = MessageBox.Show("Trọng số bằng 0 hoặc âm đồng nghĩa với xóa cạnh\nBạn chắc chắn muốn xóa cạnh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (t == DialogResult.Yes)
                                {
                                    mMT[f.den, f.di] = int.MinValue;
                                    mMT[f.di, f.den] = int.MinValue;
                                    LoadLVCB();
                                }
                            }
                            else
                            {
                                mMT[f.den, f.di] = int.Parse(f.trongso);
                                mMT[f.di, f.den] = int.Parse(f.trongso);
                                LoadLVCB();
                            }
                        }
                    }
                    else
                    {
                        mMT[f.den, f.di] = int.Parse(f.trongso);
                        mMT[f.di, f.den] = int.Parse(f.trongso);
                        LoadLVCB();
                    }
                }
            }
        }

        private void xóaCạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstvEdge.Items.Count > 0)
            {
                if (lstvEdge.SelectedItems.Count > 0)
                {
                    string vertexbegin = lstvEdge.SelectedItems[0].SubItems[0].Text;
                    string vertexend = lstvEdge.SelectedItems[0].SubItems[1].Text;

                    for (int i = 0; i < mSoDinh; i++)
                    {
                        if (mTenDinh[i] == vertexbegin) dinhdi = i;
                        if (mTenDinh[i] == vertexend) dinhden = i;
                    }

                    DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa cạnh" + vertexbegin + vertexend + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        mMT[dinhdi, dinhden] = int.MinValue;
                        mMT[dinhden, dinhdi] = int.MinValue;
                        LoadLVCB();
                    }
                }
                else
                {
                    MessageBox.Show("Click vào cạnh bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void xóaĐỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbDinh.Items.Count > 0)
            {
                if (lstbDinh.SelectedIndex != -1)
                {
                    string tenxoa = mTenDinh[lstbDinh.SelectedIndex];
                    DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa đỉnh" + tenxoa + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int index = lstbDinh.SelectedIndex;
                        for (int i = index; i < mSoDinh-1; i++)
                        {
                            Dinh[i] = Dinh[i + 1];
                            mTenDinh[i] = mTenDinh[i + 1];
                        }

                        for (int i = index; i < mSoDinh; i++)
                        {
                            for (int j = 0; j < mSoDinh; j++)
                            {
                                if (i!=j)
                                {
                                    mMT[i, j] = mMT[i + 1, j];
                                    mMT[j, i] = mMT[j, i + 1];
                                }
                            }
                        }

                        mSoDinh--;
                        LoadLVCB();
                    }
                }
                else
                {
                    MessageBox.Show("Click vào đỉnh bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void thêmĐỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mSoDinh > 0)
            {
                if (mSoDinh == 15)
                {
                    MessageBox.Show("Số lượng đỉnh đã đạt tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    AddVertex f = new AddVertex();
                    f.ShowDialog();
                    bool flag = true;
                    if (f.tenthem != "")
                    {
                        for (int i = 0; i < mSoDinh; i++)
                        {
                            if (mTenDinh[i] == f.tenthem)
                            {
                                MessageBox.Show("Đỉnh muốn thêm trùng tên với một đỉnh đã tồn tại\nHãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                flag = false;
                                break;
                            }
                        }

                        if (flag)
                        {
                            mTenDinh[mSoDinh] = f.tenthem;
                            TaoViTriDinh(mSoDinh);

                            for (int i = 0; i <= mSoDinh; i++)
                            {
                                mMT[mSoDinh, i] = int.MinValue;
                                mMT[i, mSoDinh] = int.MinValue;
                            }
                            mSoDinh++;
                            LoadLVCB();
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (mSoDinh > 0)
            {
                DialogResult r = MessageBox.Show("Bạn chắc chắn muốn làm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền ma trận", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mSoDinh; i++)
            {
                TaoViTriDinh(i);
            }
            pictureBox1.Refresh();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.ShowDialog();
        }

        //-----------------Hàm bổ trợ------------------------
        private void RefreshForm()
        {
            SoDinhLienThong = mSoDinh = 0;
            lblChucNang.Text = "Chức năng";
            lstbDinh.Items.Clear();
            lstvEdge.Items.Clear();
            txbKetQua.Clear();
            cbBegin.Items.Clear();
            cbEnd.Items.Clear();
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

        private void LoadLVCB()
        {
            lstbDinh.Items.Clear();
            lstvEdge.Items.Clear();
            cbBegin.Items.Clear();
            cbEnd.Items.Clear();
            cbBegin.Items.Add("(None)");
            cbEnd.Items.Add("(None)");
            ListViewItem moi = new ListViewItem();
            string[] a = new string[3];
            for (int i = 0; i < mSoDinh; i++)
            {
                cbBegin.Items.Add(mTenDinh[i]);
                cbEnd.Items.Add(mTenDinh[i]);
                lstbDinh.Items.Add(mTenDinh[i]);
                for (int j = 0; j < mSoDinh; j++)
                {
                    if (mMT[i, j] != int.MinValue)
                    {
                        a[0] = mTenDinh[i];
                        a[1] = mTenDinh[j];
                        a[2] = mMT[i, j].ToString();
                        moi = new ListViewItem(a);
                        lstvEdge.Items.Add(moi);
                    }
                }
            }
            cbBegin.SelectedIndex = 0;
            cbEnd.SelectedIndex = 0;
            pictureBox1.Refresh();
        }

        //kiểm tra khoảng cách đỉnh cho một đỉnh ngẫu nhiên mới có hợp lệ không
        bool KTKhoangCachDinh(int x, int y)
        {
            for (int i = 0; i < mSoDinh; i++)
            {
                float kc = (float)(Math.Sqrt(Math.Pow(x - Dinh[i].X, 2) + Math.Pow(y - Dinh[i].Y, 2)));
                if (kc < 30) return true;
            }
            return false;
        }

        //tạo vị trí ngẫu nhiên trên đồ thị cho 1 đỉnh
        void TaoViTriDinh(int dem)
        {
            Random rnd = new Random();
            int randomX, randomY;
            while (true)
            {
                randomX = rnd.Next(12, 885);
                randomY = rnd.Next(150, 600);
                if (!KTKhoangCachDinh(randomX, randomY))
                {
                    Dinh[dem] = new Point(randomX, randomY);
                    break;
                }
            }
        }

        //kiểm tra hai màu có lệch không
        bool LechMau(int m1, int m2)
        {
            if (Math.Abs(m1 - m2) < 50) return true;
            return false;
        }

        //kiểm tra màu của các đỉnh trong một thành phần liên thông có hợp lệ không
        bool KtMau(int r, int b, int g)
        {
            int dem = 0;
            if (r + g + b <= 370)
            {
                if (SoDinhLienThong == 0) return true;
                for (int i = 0; i < SoDinhLienThong; i++)
                {
                    if (LechMau(paint[i].r, r) == false || LechMau(paint[i].b, b) == false || LechMau(paint[i].g, g) == false) dem++;
                }
                return dem == SoDinhLienThong;
            }
            return false;
        }
    }
}
