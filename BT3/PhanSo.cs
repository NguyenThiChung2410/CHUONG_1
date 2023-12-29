using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class PhanSo
    {
        private int tuso;
        private int mauso;

        public PhanSo()
        {
            tuso = 0;
            mauso = 1; 
        }
        public PhanSo(int tuso,int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso) 
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void ToiGian()
        {
            int uscln = TimUSCLN(tuso, mauso);
            tuso = tuso / uscln;
            mauso = mauso / uscln;
        }
        private int TimUSCLN(int a,int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    x = y - x;
            }
            return x;
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
    }
}
