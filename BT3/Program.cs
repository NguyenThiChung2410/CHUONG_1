using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cau A

            PhanSo x = new PhanSo();
            Console.WriteLine("******Nhap thong tin phan so thu 1:****");
            Console.Write("Nhap tu so: ");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            int mauso = int.Parse(Console.ReadLine());

            x.setTuso(tuso);
            x.setMauso(mauso);
            x.ToiGian();
            Console.WriteLine("*******Nhap thong tin phan so thu 2:*********");
            Console.Write("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());

            PhanSo y = new PhanSo(tuso,mauso);
            
            PhanSo tong = x.Cong(y);
            
            Console.WriteLine("Tong 2 phan so: Phan so1:{0}/{1},Phan so 2: {2}/{3}=Ket qua: {4}/{5}", x.getTuso(), x.getMauso(), y.getTuso(), y.getMauso(), tong.getTuso(), tong.getMauso());
            
           
            PhanSo hieu = x.Tru(y);
            
            Console.WriteLine("Hieu 2 phan so: Phan so 1:{0}/{1},Phan so 2: {2}/{3}=Ket qua:{4}/{5}", x.getTuso(), x.getMauso(), y.getTuso(), y.getMauso(), hieu.getTuso(), hieu.getMauso());
            
            
            PhanSo tich = x.Nhan(y);
            
            Console.WriteLine("Tich 2 phan so: Phan so 1:{0}/{1},Phan so 2: {2}/{3}=Ket qua:{4}/{5}", x.getTuso(), x.getMauso(), y.getTuso(), y.getMauso(), tich.getTuso(), tich.getMauso());
            
            
            PhanSo thuong = x.Chia(y);
            
            Console.WriteLine("Thuong 2 phan so: Phan so 1:{0}/{1},Phan so 2: {2}/{3}=Ket qua:{4}/{5}", x.getTuso(), x.getMauso(), y.getTuso(), y.getMauso(), thuong.getTuso(), thuong.getMauso());
            
            //Cau B

            Console.WriteLine("*****Tinh toan day phan so*****");
            Console.Write("Nhap vao so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            PhanSo t = new PhanSo(0, 1);
            for(int i = 1; i <= n; i++)
            {
                t = t.Cong(new PhanSo(1, i));
            }
            t.ToiGian();
            Console.WriteLine("Ket qua tong day phan so: 1+1/2+1/3+...+1/n={0}/{1}", t.getTuso(), t.getMauso());
            Console.ReadLine();

        }
    }
    
}
