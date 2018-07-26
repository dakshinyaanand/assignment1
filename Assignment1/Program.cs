using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;
            string name, type;
            char ch;
            double amt;
            int cont;
            Console.WriteLine("enter the account no:");
            no = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name:");
            name = Console.ReadLine();
            Console.WriteLine("enter the account type:");
            type = Console.ReadLine();
            do
            {
                Console.WriteLine("enter the transaction type:");
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine("enter the amount");
                amt = double.Parse(Console.ReadLine());
                Account a1 = new Account(no, name, type);
                a1.transaction(ch, amt);
                a1.ShowData();
                Console.WriteLine("to continue the transaction press 1");
                cont = int.Parse(Console.ReadLine());
            } while (cont == 1);



        }
    }
}
