using System;
using System.Threading;
namespace _13_Sep_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread MainThread = Thread.CurrentThread;
            MainThread.Name = "Main Thread";
            //Console.WriteLine(MainThread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            Thread thread3 = new Thread(CountUpUp);
            thread1.Start();
            thread2.Start();

            Console.WriteLine(MainThread.Name + " is Compelete");
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 :  "+i+" Seconds");
                Thread.Sleep(500);

            }
            Console.WriteLine("Timer Number 1 is Complelete");  

        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 :  " + i + " Seconds");
                Thread.Sleep(1000);

            }
            Console.WriteLine("Timer Number #2 is Complelete");

        }
        public static void CountUpUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 :  " + i + " Seconds");
                Thread.Sleep(1000);

            }
            Console.WriteLine("Timer Number #2 is Complelete");

        }
    }
}