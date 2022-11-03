using System;
using System.Threading;

namespace cv_lab
{
        class Program
        {
                private static string x = "";
                private static int exitflag = 0;
                private static int updateflag = 0;
                private static object _lock = new Object();



                static void ThReadX(object i)
                {

                        while (exitflag == 0)
                        {
                                lock (_lock)
                                {
                                        if (x != "exit" && updateflag == 1)
                                        {
                                                Monitor.Pulse(_lock);
                                                
                                                Console.WriteLine("***Thread {0} : x = {1}***", i, x);
                                                updateflag = 0;
                                                Monitor.Wait(_lock);
                                        }
                                }
                        }
                        Console.WriteLine("---Thread {0} exit---", i);
                }

                static void ThWriteX()
                {
                        string xx;
                        lock (_lock)
                        {
                                while (exitflag == 0)
                                {
                                        Console.Write("Input: ");
                                        xx = Console.ReadLine();
                                        if (xx == "exit")
                                        {
                                                x = xx;
                                                exitflag = 1;
                                                Monitor.Pulse(_lock);
                                                
                                        }
                                        else
                                        {
                                                x = xx;
                                                updateflag = 1;
                                                Monitor.Pulse(_lock);
                                                Monitor.Wait(_lock);
                                        }

                                }
                        }
                }

                static void Main()
                {
                        Thread A = new Thread(ThWriteX);
                        Thread B = new Thread(ThReadX);
                        Thread C = new Thread(ThReadX);
                        Thread D = new Thread(ThReadX);

                        A.Start();
                        B.Start(1);
                        C.Start(2);
                        D.Start(3);
                }
        }
}