using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Account
    {
        private string id;
        private string name;
        private int balance;

        public Account(string name, string id, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getbalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (balance > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
                Console.Write("Thanh toan khong thanh cong");
        }
        public void tranferTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
            {
                Console.WriteLine("So tien vuot qua so du. Chuyen khoan khong thanh cong");
            }
        }
    }
}
