using System;
using System.Diagnostics;
using System.Threading;

namespace OS_Sync_01
{
    class Program  
    {
        private static string x = "";
        private static int exitflag = 0;
        static object _Lock = new object();
        // Semaphore s = new Semaphore(1, 1);

        static void ThReadX()
        {
            lock (_Lock)
            {
                while (exitflag == 0)
                {   
                    Monitor.Pulse(_Lock);
                    Monitor.Wait(_Lock);
                    if (exitflag == 1)
                    {
                        Console.WriteLine("Thread 1 exit");    
                    }
                    else
                        Console.WriteLine("X = {0}", x);
                }
            }
        }

        static void ThWriteX()
        {
            string xx;
            lock (_Lock)
            {
                while (exitflag == 0)
                {
                    Console.Write("Input: ");
                    xx = Console.ReadLine();
                    if (xx == "exit")
                    {
                        exitflag = 1;
                        Monitor.Pulse(_Lock);
                    }
                    else
                    {
                        x = xx;
                        Monitor.Pulse(_Lock);
                        Monitor.Wait(_Lock);
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            Thread A = new Thread(ThReadX);
            Thread B = new Thread(ThWriteX);

            A.Start();
            B.Start();


        }
    }
}