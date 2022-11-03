// using System;
// using System.Diagnostics;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;
// using System.Threading;

// namespace Problem01
// {
//         class Program
//         {
//                 static byte[] Data_Global = new byte[1000000000];
//                 static long Sum_Global = 0;
//                 static int G_index = 0;

//                 static int ReadData()
//                 {
//                         int returnData = 0;
//                         FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
//                         BinaryFormatter bf = new BinaryFormatter();

//                         try
//                         {
//                                 Data_Global = (byte[])bf.Deserialize(fs);
//                         }
//                         catch (SerializationException se)
//                         {
//                                 Console.WriteLine("Read Failed:" + se.Message);
//                                 returnData = 1;
//                         }
//                         finally
//                         {
//                                 fs.Close();
//                         }

//                         return returnData;
//                 }
//                 static void sum(int indexNumber)
//                 {
//                         if (Data_Global[indexNumber] % 2 == 0)
//                         {
//                                 Sum_Global -= Data_Global[indexNumber];
//                         }
//                         else if (Data_Global[indexNumber] % 3 == 0)
//                         {
//                                 Sum_Global += (Data_Global[indexNumber] * 2);
//                         }
//                         else if (Data_Global[indexNumber] % 5 == 0)
//                         {
//                                 Sum_Global += (Data_Global[indexNumber] / 2);
//                         }
//                         else if (Data_Global[indexNumber] % 7 == 0)
//                         {
//                                 Sum_Global += (Data_Global[indexNumber] / 3);
//                         }
//                         Data_Global[indexNumber] = 0;
//                 }

//                 static void Main(string[] args)
//                 {
//                         Stopwatch sw = new Stopwatch();
//                         int y;
//                         int min = 0;
//                         int limit = 1000000000;
//                         int[] numbersIndex = Enumerable.Range(0, limit).ToArray();

//                         /* Read data from file */
//                         Console.Write("Data read...");
//                         y = ReadData();
//                         if (y == 0)
//                         {
//                                 Console.WriteLine("Complete.");
//                         }
//                         else
//                         {
//                                 Console.WriteLine("Read Failed!");
//                         }

//                         /* Start */
//                         Console.Write("\n\nWorking...");
//                         sw.Start();
//                         Parallel.For(0, limit, new ParallelOptions { MaxDegreeOfParallelism = 200 }, i =>
//                         {
//                                 sum(i);
//                         });
//                         // for (i = 0; i < 1000000000; i++)
//                                 // sum(i);
//                         sw.Stop();
//                         Console.WriteLine("Done.");

//                         /* Result */
//                         Console.WriteLine("Summation result: {0}", Sum_Global);
//                         Console.WriteLine("Expection result: {0}", 888701676);
//                         Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
//                 }
//         }
// }



// // *****************************************************************
// // V2

// using System;
// using System.Diagnostics;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;
// using System.Threading;

// namespace Problem01
// {
//         class Program
//         {
//                 static byte[] Data_Global = new byte[1000000000];
//                 static long Sum_Global = 0;
//                 static int G_index = 0;

//                 static int ReadData()
//                 {
//                         int returnData = 0;
//                         FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
//                         BinaryFormatter bf = new BinaryFormatter();

//                         try
//                         {
//                                 Data_Global = (byte[])bf.Deserialize(fs);
//                         }
//                         catch (SerializationException se)
//                         {
//                                 Console.WriteLine("Read Failed:" + se.Message);
//                                 returnData = 1;
//                         }
//                         finally
//                         {
//                                 fs.Close();
//                         }

//                         return returnData;
//                 }
//                 static void sum(int indexNumber)
//                 {
//                         if (Data_Global[indexNumber] % 2 == 0)
//                         {
//                                 Sum_Global -= Data_Global[indexNumber];
//                         }
//                         else if (Data_Global[indexNumber] % 3 == 0)
//                         {
//                                 Sum_Global += (Data_Global[indexNumber] * 2);
//                         }
//                         else if (Data_Global[indexNumber] % 5 == 0)
//                         {
//                                 Sum_Global += (Data_Global[indexNumber] / 2);
//                         }
//                         else if (Data_Global[indexNumber] % 7 == 0)
//                         {
//                                 Sum_Global += (Data_Global[indexNumber] / 3);
//                         }
//                         Data_Global[indexNumber] = 0;
//                 }

//                 static void Main(string[] args)
//                 {
//                         Stopwatch sw = new Stopwatch();
//                         int i, y;
//                         int min = 0;
//                         int limit = 1000000000;
//                         var numbersIndex = Enumerable.Range(0, limit).ToList();

//                         /* Read data from file */
//                         Console.Write("Data read...");
//                         y = ReadData();
//                         if (y == 0)
//                         {
//                                 Console.WriteLine("Complete.");
//                         }
//                         else
//                         {
//                                 Console.WriteLine("Read Failed!");
//                         }

//                         /* Start */
//                         Console.Write("\n\nWorking...");
//                         sw.Start();
//                         Parallel.ForEach(numbersIndex, numberSum => {
//                                 sum(numberSum);
//                         });
//                         sw.Stop();
//                         Console.WriteLine("Done.");

//                         /* Result */
//                         Console.WriteLine("Summation result: {0}", Sum_Global);
//                         Console.WriteLine("Expection result: {0}", 888701676);
//                         Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
//                 }
//         }
// }


// using System;
// using System.Diagnostics;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;
// using System.Threading;

// namespace Problem01
// {
//     class Program
//     {
//         static byte[] Data_Global = new byte[1000000000];
//         static long Sum_Global = 0;
//         static int G_index = 0;

//         static int ReadData()
//         {
//             int returnData = 0;
//             FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
//             BinaryFormatter bf = new BinaryFormatter();

//             try 
//             {
//                 Data_Global = (byte[]) bf.Deserialize(fs);
//             }
//             catch (SerializationException se)
//             {
//                 Console.WriteLine("Read Failed:" + se.Message);
//                 returnData = 1;
//             }
//             finally
//             {
//                 fs.Close();
//             }

//             return returnData;
//         }
//         static int sum(int indexNumber)
//         {
//             if (Data_Global[indexNumber] % 2 == 0)
//             {
//                 Sum_Global -= Data_Global[indexNumber];
//             }
//             else if (Data_Global[indexNumber] % 3 == 0)
//             {
//                 Sum_Global += (Data_Global[indexNumber]*2);
//             }
//             else if (Data_Global[indexNumber] % 5 == 0)
//             {
//                 Sum_Global += (Data_Global[indexNumber] / 2);
//             }
//             else if (Data_Global[indexNumber] %7 == 0)
//             {
//                 Sum_Global += (Data_Global[indexNumber] / 3);
//             }
//             Data_Global[indexNumber] = 0;
//             return indexNumber++;
//         }

//         static void Thread1(int partitionNumberStart, int partitionNumberEnd)
//         {
//                 int threads_partiotion_start = partitionNumberStart;
//                 int threads_partiotion_end = partitionNumberEnd;
//                 for (int i = partitionNumberStart; i < partitionNumberEnd ; i++) {
//                         sum(i);
//                 }
//         }

//         static void Main(string[] args)
//         {
//             Stopwatch sw = new Stopwatch();
//             int i, y;
//             int min = 0;
//             int max = 1000000000;
        
//             /* Read data from file */
//             Console.Write("Data read...");
//             y = ReadData();
//             if (y == 0)
//             {
//                 Console.WriteLine("Complete.");
//             }
//             else
//             {
//                 Console.WriteLine("Read Failed!");
//             }
//             Thread th1 = new Thread(()=>Thread1(0,  250000000));
//             Thread th2 = new Thread(()=>Thread1(250000000,  500000000));
//             Thread th3 = new Thread(()=>Thread1(500000000,  750000000));
//             Thread th4 = new Thread(()=>Thread1(750000000,  1000000000));

//             /* Start */
//             Console.Write("\n\nWorking...");
//             sw.Start();
//             th1.Start();
//             th2.Start();
//             th3.Start();
//             th4.Start();
//             th1.Join();         
//             th2.Join();    
//             th3.Join();    
//             th4.Join();    
//             sw.Stop();
//             Console.WriteLine("Done.");

//             /* Result */
//             Console.WriteLine("Summation result: {0}", Sum_Global);
//             Console.WriteLine("Expection result: {0}", 888701676);
//             Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
//         }
//     }
// }




// // ของซัน
// using System;
// using System.Diagnostics;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;
// using System.Threading;

// namespace Problem01
// {
//     class Program
//     {
//         static byte[] Data_Global = new byte[1000000000];
//         static long Sum_Global = 0;
//         static int G_index = 0;

//         static int ReadData()
//         {
//             // - - - - - - - - - - - - - - - - Header - - - - - - - - - - - - - - - - - - - 
//             int returnData = 0;
//             FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
//             BinaryFormatter bf = new BinaryFormatter();

//             try 
//             {
//                 Data_Global = (byte[]) bf.Deserialize(fs);
//             }
//             catch (SerializationException se)
//             {
//                 Console.WriteLine("Read Failed:" + se.Message);
//                 returnData = 1;
//             }
//             finally
//             {
//                 fs.Close();
//             }

//             return returnData;
//         }
//         // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
//         static long Sum(int start,int end)
//         {
//             long Sum_Local = 0;
//             for (int index = start;index<end;index++){
//                 if (Data_Global[index] % 2 == 0)
//                 {
//                     Sum_Local -= Data_Global[index];
//                 }
//                 else if (Data_Global[index] % 3 == 0)
//                 {
//                     Sum_Local += (Data_Global[index]*2);
//                 }
//                 else if (Data_Global[index] % 5 == 0)
//                 {
//                     Sum_Local += (Data_Global[index] / 2);
//                 }
//                 else if (Data_Global[index] %7 == 0)
//                 {
//                     Sum_Local += (Data_Global[index] / 3);
//                 }
//                 Data_Global[index] = 0;
//             }
            
//             return Sum_Local;
//         }
//         static void Main(string[] args)
//         {
//             Stopwatch sw = new Stopwatch();
//             int y;
//             int MAX_VALUE = 1000000000;
//             int parallelParts = 8;
//             List<long> eachSum = new List<long>();

//             /* Read data from file */
//             Console.Write("Data read...");
//             y = ReadData();
//             if (y == 0)
//             { Console.WriteLine("Complete."); }
//             else
//             { Console.WriteLine("Read Failed!"); }

//             /* Start */
//             Console.Write("\n\nWorking...");
//             sw.Start();
            
//             //       For(Start, End, (Loop Code)) *i = loop
//             Parallel.For(0,parallelParts, i=>eachSum.Add(Sum((i*(MAX_VALUE/parallelParts)),((i + 1) * (MAX_VALUE/parallelParts))))); //888701676 Ans

//             for(int j = 0;j < eachSum.Count; j++){
//                 Sum_Global += eachSum[j];
//             }

//             sw.Stop();
//             Console.WriteLine("Done.");

//             /* Result */
//             Console.WriteLine("Summation result: {0}", Sum_Global);
//             Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
//         }
//     }
// }

// using System;
// using System.Diagnostics;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;
// using System.Threading;

// namespace Problem01
// {
//     class Program
//     {
//         static byte[] Data_Global = new byte[1000000000];
//         static long Sum_Global = 0;
//         static int G_index = 0;

//         static int ReadData()
//         {
//             int returnData = 0;
//             FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
//             BinaryFormatter bf = new BinaryFormatter();

//             try 
//             {
//                 Data_Global = (byte[]) bf.Deserialize(fs);
//             }
//             catch (SerializationException se)
//             {
//                 Console.WriteLine("Read Failed:" + se.Message);
//                 returnData = 1;
//             }
//             finally
//             {
//                 fs.Close();
//             }

//             return returnData;
//         }
//         static void sum()
//         {
//             if (Data_Global[G_index] % 2 == 0)
//             {
//                 Sum_Global -= Data_Global[G_index];
//             }
//             else if (Data_Global[G_index] % 3 == 0)
//             {
//                 Sum_Global += (Data_Global[G_index]*2);
//             }
//             else if (Data_Global[G_index] % 5 == 0)
//             {
//                 Sum_Global += (Data_Global[G_index] / 2);
//             }
//             else if (Data_Global[G_index] %7 == 0)
//             {
//                 Sum_Global += (Data_Global[G_index] / 3);
//             }
//             Data_Global[G_index] = 0;
//             G_index++;   
//         }
//         static void Main(string[] args)
//         {
//             Stopwatch sw = new Stopwatch();
//             int i, y;

//             /* Read data from file */
//             Console.Write("Data read...");
//             y = ReadData();
//             if (y == 0)
//             {
//                 Console.WriteLine("Complete.");
//             }
//             else
//             {
//                 Console.WriteLine("Read Failed!");
//             }

//             /* Start */
//             Console.Write("\n\nWorking...");
//             sw.Start();
//             for (i = 0; i < 1000000000; i++)
//                 sum();
//             sw.Stop();
//             Console.WriteLine("Done.");

//             /* Result */
//             Console.WriteLine("Summation result: {0}", Sum_Global);
//             Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
//         }
//     }
// }


//ของโฟค
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Problem01
{
        class Program
        {
                static byte[] Data_Global = new byte[1000000000];
                static long Sum_Global = 0;
                static int G_index = 0;

                static int ReadData()
                {
                        int returnData = 0;
                        FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
                        BinaryFormatter bf = new BinaryFormatter();

                        try
                        {
                                Data_Global = (byte[])bf.Deserialize(fs);
                        }
                        catch (SerializationException se)
                        {
                                Console.WriteLine("Read Failed:" + se.Message);
                                returnData = 1;
                        }
                        finally
                        {
                                fs.Close();
                        }

                        return returnData;
                }
                static long sum(long indexNumber)
                {
                        long temp_ans = 0;
                        if (Data_Global[indexNumber] % 2 == 0)
                        {
                                temp_ans -= Data_Global[indexNumber];
                        }
                        else if (Data_Global[indexNumber] % 3 == 0)
                        {
                                temp_ans += (Data_Global[indexNumber] * 2);
                        }
                        else if (Data_Global[indexNumber] % 5 == 0)
                        {
                                temp_ans += (Data_Global[indexNumber] / 2);
                        }
                        else if (Data_Global[indexNumber] % 7 == 0)
                        {
                                temp_ans += (Data_Global[indexNumber] / 3);
                        }
                        Data_Global[indexNumber] = 0;
                        return temp_ans;
                }

                static void Main(string[] args)
                {
                        Stopwatch sw = new Stopwatch();
                        int y;
                        int limit = 1000000000;
                        int[] numbersIndex = Enumerable.Range(0, limit).ToArray();

                        /* Read data from file */
                        Console.Write("Data read...");
                        y = ReadData();
                        if (y == 0)
                        {
                                Console.WriteLine("Complete.");
                        }
                        else
                        {
                                Console.WriteLine("Read Failed!");
                        }

                        /* Start */
                        Console.Write("\n\nWorking...");
                        sw.Start();
                        Parallel.For<long>(0, numbersIndex.Length, () => 0 , (j, loop, subtotal) =>
                        {
                                subtotal += sum(j);
                                return subtotal;
                        },
                            (x) => Interlocked.Add(ref Sum_Global, x)
                        );
                        sw.Stop();
                        Console.WriteLine("Done.");

                        /* Result */
                        Console.WriteLine("Summation result: {0}", Sum_Global);
                        Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
                }
        }
}