using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string f_name, l_name, email;
            DateTime dob;
            Console.WriteLine("enter first name,lastname,email,dob:");
            f_name = Console.ReadLine();
            l_name = Console.ReadLine();
            email = Console.ReadLine();
            dob = DateTime.Parse(Console.ReadLine());
            Person p = new Person(f_name, l_name, email, dob);
            p.adult();
            p.sunsign();
            p.birthday();
            Person p2 = new Person(f_name, l_name, dob);
            p2.adult();
            p2.sunsign();
            p2.birthday();
            Person p3 = new Person(f_name, l_name, email);
            p3.adult();
            p3.sunsign();
            p3.birthday();
        }
    }
}
