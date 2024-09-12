using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double toan, ly, hoa, tb;

            Console.WriteLine("Nhap diem toan: ");
            toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            ly = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            hoa = double.Parse(Console.ReadLine());

            tb = (toan + ly + hoa) / 3;

            if (tb >= 9.0)
            {
                Console.WriteLine("Xuat sac");
            }
            else if(tb>=8.0)
            {
                Console.WriteLine("Gioi");
            }
            else if (tb >= 6.5)
            {
                Console.WriteLine("Kha");
            }
            else if (tb >= 5.0)
            {
                Console.WriteLine("Trung binh");
            }else
            {
                Console.WriteLine("Yeu");
            }

            Console.ReadKey();

        }
    }
}
