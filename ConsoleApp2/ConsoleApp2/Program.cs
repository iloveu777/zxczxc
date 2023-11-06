using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
       static void Vvod(ref int x)
        {
            int count = 1; 
            Write($"введите {count} число = ");
            x = int.Parse(ReadLine());
            count++;
        }
        //ко второму
        /*
        static int Seconds(ref int h, ref int m, ref int s)
        {
            int seconds = (h * 60) + (m * 60) + s;
            return seconds;
        }
        */
        // уровень B,2 задание
        /*
        static void Numbers(ref int n)
        {
            
            for (int i = 2; i < n; i++)
            {
                if (i % 2 == 0  )
                {
                    WriteLine(i);
                }
                
            }
            
        }
        */
        static int Sum(ref int m, ref int nn)
        {
            int res = 0;
            for (int i = m; i < nn; i++)
            {
                int ac = i;
                int vb = nn;
                res = ac + vb;

                WriteLine(res);
                
            }
            
            return res;

        }
        static void Main(string[] args)
        {
            /*
            double AddMeth(int x)

            {
                double result;
                return result = (x + Math.Sin(x)) / 3;
            }
            double Sum(double x, double y)
            {
                double result = x + y;
                return result; 
            }
            int z = 1; int c = 2; int v = 3;
            Vvod(ref z);
            Vvod(ref c);
            Vvod(ref v);
            AddMeth(z); AddMeth(c); AddMeth(v);
            double ress = Sum(z, Sum(c, v));
            WriteLine(ress);
            */
            // 2 задание
            /*
            int h1 = 0; int m1 = 0; int s1 = 0;
            Vvod(ref h1); Vvod(ref m1); Vvod(ref s1);
            int ss = Seconds(ref h1, ref m1, ref s1);
            Write(ss);
            */
            //b2
            /*
            int n = 0;
            Vvod(ref n);
            Numbers(ref n);
            */
            int a = 1; int b = 50;
            Vvod(ref a); Vvod(ref b);
            Sum(ref a, ref b);

            ReadKey();
        }
    }
}
