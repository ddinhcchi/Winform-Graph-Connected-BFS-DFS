using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancuoiky
{
    class BFS
    {
        public int[,] BFSmt = new int[50, 50];
        public int BFSsodinh = 0;
        private int[] visited = new int[50];
        private int[] LuuVet = new int[50];
        public string ketqua = "";
        public int size = 0;
        public int[] a = new int[50];

        public void Them(int k)
        {
            if (size + 1 <= 50)
            {
                a[size] = k;
                size++;
            }
        }

        public void Lay(ref int v)
        {
            if (size > 0)
            {
                v = a[0];
                for (int i = 0; i < size - 1; i++)
                    a[i] = a[i + 1];
                size--;
            }
        }

        public void bFS(int s)
        {
            Them(s);//Thêm đỉnh s vào q

            while (size!=0)
            {
                Lay(ref s);
                //Đánh dấu đỉnh s đã suyệt
                visited[s] = 1;
                for (int i = 0; i < BFSsodinh; i++)
                    if (visited[i] == 0 && BFSmt[s,i] != int.MinValue)
                    {
                        Them(i);
                        LuuVet[i] = s;
                    }
            }
        }

        public void duyetBFS(int s, int f)
        {
            //Khởi tạo giá trị ban đầu, tất cả các địh chư đuợc duyệt và chưa lưu vết
            for (int i = 0; i < BFSsodinh; i++)
            {
                visited[i] = 0;
                LuuVet[i] = -1;
            }

            //Gọi hàm BFS
            bFS(s);

            if (visited[f] == 1)
            {
                //In ket qua
                int j = f;
                while (j != s)
                {
                    ketqua += j.ToString() + " ";
                    j = LuuVet[j];
                }
                ketqua += j.ToString();
            }
        }
    }
}
