using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBrand p = new PhoneBrand();
            abc:
            Console.Write("Apple/Samsung/Xiaomi/LG/Huawei/Nokia ----> Choose one of them: ");
            p.brandname=Console.ReadLine();

            void info()
            {
                Console.Write("\nCountry: "+p.country + "\nYear: " + p.foundingyear);
            }

            if (p.brandname == "Apple"|| p.brandname == "apple")
            {
                p.country = "USA";
                p.foundingyear = 1976;
                info();
            }
            else if (p.brandname == "Samsung"|| p.brandname == "samsung")
            {
                p.country = "South Korea";
                p.foundingyear = 1969;
                info();
            }
            else if (p.brandname == "Xiaomi"|| p.brandname == "xiaomi")
            {
                p.country = "China";
                p.foundingyear = 2010;
                info();
            }
            else if (p.brandname == "LG"|| p.brandname == "lg")
                {
                    p.country = "South Korea";
                    p.foundingyear = 1958;
                info();
            }

            else if (p.brandname == "Huawei"|| p.brandname == "huawei")
            {
                p.country = "China";
                p.foundingyear = 1987;
                info();
            }
            else if (p.brandname == "Nokia"|| p.brandname == "nokia")
            {
                p.country = "Finland";
                p.foundingyear = 1865;
                 info();
            } else { Console.WriteLine("Answer again.\n-----------------------------------------------------------------------"); goto abc; }
          

            Console.ReadLine();




        }
    }
}