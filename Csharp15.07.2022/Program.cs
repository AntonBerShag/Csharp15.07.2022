using Csharp15._07._2022.Fruits;
using System;
using System.Linq;

namespace Csharp15._07._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Orange orange = new Orange("Самый вкусный апельсин", 15);

             Orange orange1 = new() { Name = "Апельсин ", Weight = 15 };

             Orange blue2 = new Orange();

             String a = "Хай!";

             string b = "Всем";

             Console.BackgroundColor = ConsoleColor.Blue;

             Console.WriteLine(a);
             Console.Write(b);
             string s = Console.ReadLine();
             Console.WriteLine(s);

             int c = int.Parse(Console.ReadLine());
             Console.WriteLine(c);

             Console.WriteLine("Hello World!");*/

            //Задание 2
            
            int?[] arr = new int?[5];
            int i = 0;
            foreach (var item in arr)
            {
                Console.WriteLine($"Введите значения {i + 1} переменной: ");
                string jj = Console.ReadLine();
                if(jj == "")
                {
                    arr[i++] = 0;
                    continue;
                }
                arr[i++] = int.Parse(jj);
            }
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Aggregate((x, y) => x * y));
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());

            int? Mult(int?[] a)
            {
                int? i = 1;
                foreach (var item in a)
                {
                    i = i * item;
                }
                return i;
            }
            Console.WriteLine(Mult(arr));
        }
    }
}
