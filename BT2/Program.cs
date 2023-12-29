using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {

            Account my = new Account("346246", "Nguyen Thi Chung", 400);
            Console.Write("Enter your mother's id: ");
            string id = Console.ReadLine();
            Console.Write("Enter your mother's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your mother's money: ");
            int balance = int.Parse(Console.ReadLine());
            Account myMother = new Account(id, name, balance);

            Console.WriteLine("*********Thong tin 2 tai khoan ban dau********");
            Console.WriteLine("My account: id:{0}, name:{1}, balance: {2}", my.getid(), my.getname(), my.getbalance());
            Console.WriteLine("My Mother account: id:{0}, name:{1}, balance: {2}", myMother.getid(), myMother.getname(), myMother.getbalance());

            my.debit(200);
            my.tranferTo(myMother, 50);
            myMother.tranferTo(my, 100);

            Console.WriteLine("*******Thong tin 2 tai khoan sau khi thuc hien giao dich*******");
            Console.WriteLine("My account: id:{0}, name:{1}, balance: {2}", my.getid(), my.getname(), my.getbalance());
            Console.WriteLine("My Mother account: id:{0}, name:{1}, balance: {2}", myMother.getid(), myMother.getname(), myMother.getbalance());
            Console.ReadLine();
        }
    }
}
