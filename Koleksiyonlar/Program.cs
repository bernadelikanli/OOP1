using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] isimler = new string[] { "Ali", "Ayşe", "Can" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            List<string> isimler2 = new List<string> { "Ali", "Ayşe", "Can" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Berna");
            isimler2.Add("Ayça");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
        }
    }
}
