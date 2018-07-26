using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Account
    {
        private int acc_no;
        private string name, acc_type;
        private char trans_type;
        private double amount;
        public static double balance;
        public Account(int acc_no, string name, string acc_type)
        {
            this.acc_no = acc_no;
            this.name = name;
            this.acc_type = acc_type;


        }
        public void transaction(char ch, double amount)
        {
            if (ch == 'd')
            {
                balance = balance + amount;
            }
            if (ch == 'w')
            {
                balance = balance - amount;
            }
        }
        public void ShowData()
        {
            Console.WriteLine("Account no.:" + acc_no + "\nName :" + name + "\nAccount type:" + acc_type + "\nBalance" + balance);
        }
    }
}
