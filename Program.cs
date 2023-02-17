using System;
using Sysytem.IO;

namespace ConsoleApp1
{
    class Program
    {
        int Finding(string s, string s1)
        {
         string s2=s;
         int n;
            while (s2.IndexOf(s1)>=0)
            {
                n = n + 1;
                s2=s2.substring(s2.IndexOf(s1)+s1.Length);
               
            }
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string ps = @"C:\Users\alexg\source\repos\ConsoleApp1\input.txt";
            using (StreamReader f = file File.OpenText(path))
              {
                string s, s1;
                int k = 0;//счетчик, количество

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Введите подстроку для", k, "строки");
                    k = k + 1;
                    Console.ReadLine(s1);
                   
                    int n= Finding(s, s1);

                    Console.WriteLine("В строке с номером ", k, " содержится ", n, " подстрок");
                }
              }
        }
       
    }
}
