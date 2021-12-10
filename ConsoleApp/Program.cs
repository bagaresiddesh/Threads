using System;
using System.IO;
using System.Threading;
using SimpleFunctions;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Functions obj = new Functions();
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./Log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Log.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);

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

            thread1.Abort();
            thread2.Abort();
            thread3.Abort();

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();

            Console.WriteLine("Log file created!");
            Console.ReadLine();
        }
    }
}
