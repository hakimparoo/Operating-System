using System;
using System.Threading;

namespace CshapeFirst
{
    class Program
    {
        //LAB 01
        // static void TestThread1()
        // {
        //     int i;
        //     for (i = 0; i < 100000; i++)
        //         Console.WriteLine("Thread# 1 i={0}", i);
        // }
        // static void TestThread2()
        // {
        //     int i;
        //     for (i = 0; i < 100000; i++)
        //         Console.WriteLine("Thread# 2 i={0}", i);
        // }

        // LAB 02
        // static int resource = 10000;
        // static void TestThread1()
        // {
        //     Console.WriteLine("Thread# 1 i={0}",resource);
        // }
        // static void TestThread2()
        // {
        //     Console.WriteLine("Thread# 2 i={0}",resource);
        // }

        //LAB 03
        static int resource = 10000;
        static void TestThread1()
        {
            // resource = 55555;
            int i;
            for(i=0; i<45555; i++){
                resource++;
                Console.Write(".");
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("this is a first project");
            // Thread th1 = new Thread(TestThread1);
            // Thread th2 = new Thread(TestThread2);
            // th1.Start();
            // th2.Start();

            // Thread th1 = new Thread(TestThread1);
            // th1.Start();
            // // Thread.Sleep(1000);
            // th1.Join();
            // Console.WriteLine("resource={0}", resource);
            Console.WriteLine(0.2+0.1);
        }
    }
}