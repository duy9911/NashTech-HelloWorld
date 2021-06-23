using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace Test
{
    class Program
    {
        static List<int> result = new List<int>();
        static List<int> rangeList1 = new List<int>();
        static List<int> rangeList2 = new List<int>();
        static void Main(string[] args)
        {
            Program s = new Program();
            Console.WriteLine("Enter min number... ");
            Int32 min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max number... ");
            Int32 max = int.Parse(Console.ReadLine());
            List<int> primeNumberList = GetPrimeNumber(min, max);
            Task tasks = DoTask();
            //Thread.Sleep(10000);
            Console.WriteLine("Co {0} so nguyen to ", result.Count);
            Console.ReadLine();
        }

        static List<int> GetPrimeNumber(int start, int end)
        {
            List<int> result = new List<int>();
            Int32 range = (end - start) / 2;
            for (int i = start; i <= end; i++)
            {
                if (i <= (range + start))
                {
                    rangeList1.Add(i);
                }
                else if (i <= ((range * 2) + start))
                {
                    rangeList2.Add(i);
                }
            }
            return result;
        }


        static async Task DoTask()
        {
            var t = Task.Factory.StartNew(() =>
            {
                foreach (var item in rangeList1)
                {
                    if (CheckPriceNumber(item))
                    {
                        result.Add(item);
                    }
                }
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                foreach (var item in rangeList2)
                {
                    if (CheckPriceNumber(item))
                    {
                        result.Add(item);
                    }
                }
            });
            t.Start();
            t2.Start();
            await Task.WhenAll(t, t2);
        }

        static bool CheckPriceNumber(int number)
        {
            if (number == 2)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}

