using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "Python";
            string kurs3 = "C++";
            Console.WriteLine(kurs1);

            //array - dizi

            string[] kurslar = new string[] {"Java", "Python", "C++", "C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
