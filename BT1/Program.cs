using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            Rectangle r2;
            r1 = new Rectangle();
            Console.Write("Cho biet chieu dai: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Cho biet chieu rong: ");
            double width = double.Parse(Console.ReadLine());
            r2 = new Rectangle(length, width);
            Console.WriteLine("-------Thong tin chu nhat r1-------");
            Console.WriteLine(" Chieu dai : {0} \n Chieu rong : {1} \n Dien Tich : {2} \n Chu vi : {3}", r1.getLength(), r1.getWidth(), r1.findArea(), r1.findPerimeter());
            Console.WriteLine("--------Thong tin chu nhat r2-------");
            Console.WriteLine(" Chieu dai : {0} \n Chieu rong: {1} \n Dien Tich : {2} \n Chu vi : {3}", r2.getLength(), r2.getWidth(), r2.findArea(), r2.findPerimeter());
            Console.ReadLine();
        }
    }
}
