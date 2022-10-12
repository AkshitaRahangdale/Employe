using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("man1", 33000, 4000);
            m1.CalculateSalary();
            Console.WriteLine(m1);



            President p1 = new President("p1", 35000, 4100);
            p1.CalculateSalary();
            Console.WriteLine(p1);



            SalesManager s1 = new SalesManager("s1", 43000, 4200);
            s1.CalculateSalary();
            Console.WriteLine(s1);

        }

    }   
          
}      



