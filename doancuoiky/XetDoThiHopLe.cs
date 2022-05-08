using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancuoiky
{
    class XetDoThiHopLe
    {
        public struct DoThi
        {
            public int iSodinh;
            public int[,] iMaTran;

        };

        //kiem tra duong cheo chinh
        bool kiemTraMaTranKeVoHuongHopLe(DoThi dt)
        {
            for (int i = 0; i < dt.iSodinh; i++)
            {
                if (dt.iMaTran[i, i] != int.MinValue) return false;
            }
            return true;
        }

        //kiem tra doi xung
        bool kiemTraMaTranKeVoHuong(DoThi dt)
        {
            for (int i = 0; i < dt.iSodinh; i++)
            {
                for (int j = i + 1; j < dt.iSodinh; j++)
                {
                    if (dt.iMaTran[i, j] != dt.iMaTran[j, i]) return false;
                }
            }
            return true;
        }

        //kiem tra ma tran hop le
        public bool KiemTraDonDoThiDonVoHuong(DoThi dt)
        {
            if (kiemTraMaTranKeVoHuong(dt) == true && kiemTraMaTranKeVoHuongHopLe(dt) == true)
            {
                return true;
            }
            return false;
        }
    }
}

