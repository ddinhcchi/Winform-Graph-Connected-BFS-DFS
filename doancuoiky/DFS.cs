using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancuoiky
{
    class DFS
    {
        public int[,] DFSmt = new int[50,50];
        public int DFSsodinh = 0;
        private int[] visited = new int[50];
        private int[] LuuVet = new int[50];
        public string ketqua = "";

        //hàm xét từ đỉnh s bất kỳ
        public void dFS(int s)
        {
            //Đánh dấu đỉnh s đã duyệt
            visited[s] = 1;

            //Tìm xem từ đỉnh s có đỉnh i nào chưa duyệt và nối trực tiếp với s
            for (int i = 0; i < DFSsodinh; i++)
                if (visited[i] == 0 && DFSmt[s,i] != int.MinValue)
                {
                    LuuVet[i] = s; //Lưu trước đỉnh i là đỉnh s
                    dFS(i);//gọi đệ quy tiến hành xét tiếp
                }
        }

        //Hàm tìm đường đi từ đỉnh s đến đỉnh f trong đồ thị g
        public void duyetDFS(int s, int f)
        {
            //Khởi tạo giá trị ban đầu, tất cả các đỉnh chưa được duyệt và chưa lưu vết
            for (int i = 0; i < DFSsodinh; i++)
            {
                visited[i] = 0;
                LuuVet[i] = -1;
            }

            //Gọi hàm DFS
            dFS(s);

            if (visited[f] == 1)
            {
                //In ket qua
                int j = f;
                while (j != s)
                {
                    ketqua += j.ToString() + " ";
                    j = LuuVet[j];
                }
                ketqua += s.ToString();
            }   
        }
    }
}
