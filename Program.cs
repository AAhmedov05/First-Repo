using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашно_за_11._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ахмед Шакиров Ахмедов №2

            //Вариант №1
            int Ox = 0x0002;
            string two = Convert.ToString(Ox,2);
            Console.WriteLine(two);

            //Вариант №2
            //string sixteen = Console.ReadLine();
            //int ten= Convert.ToInt32(sixteen,16);
            //string two= Convert.ToString(ten,2);
            //Console.WriteLine(two);

            // Математическо решение на задачата:
            // 2/2=1|0
            // 1/2=0|1
            // Отговор:10
        }
    }
}
