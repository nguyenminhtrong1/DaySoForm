using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySoForm
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            int count = 0;
            Console.Write("Mat khau mac dinh la: bai1\n");
            Console.Write("---------------------------------\n");

            do
            {
                Console.Write("Mat khau: ");
                pass = Console.ReadLine();

                count++;

            }
            while ((pass != "bai1") && (count != 3));

            if (count == 3)
                Console.Write("Dang nhap that bai!");
            else
                Console.Write("ok");

            Console.ReadKey();

        }
    }
}
