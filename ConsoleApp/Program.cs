using System;
using System.Threading;
using SimpleFunctions;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Functions obj = new Functions();

            Console.WriteLine("\nEven numbers upto 1000 : \n");
            obj.Even();

            Console.WriteLine("\nPallindrome numbers upto 1000 : \n");
            obj.Pallindrome();

            Console.WriteLine("\nEven numbers upto 1000 using double Thread : \n");
            Thread thread2 = new Thread(new ThreadStart(obj.Even));
            thread2.Start();

            Console.WriteLine("\nPallindrome numbers upto 1000 using double Thread : \n");
            Thread thread3 = new Thread(new ThreadStart(obj.Pallindrome));
            thread3.Start();

            Console.WriteLine("\nPallindrome numbers upto 1000 using single Thread : \n");
            Thread thread1 = new Thread(new ThreadStart(obj.Pallindrome));
            thread1.Start();
            obj.Even();

            Console.ReadLine();
        }
    }
}
