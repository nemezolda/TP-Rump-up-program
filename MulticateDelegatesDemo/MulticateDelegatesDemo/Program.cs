using System;

namespace MulticateDelegatesDemo
{
    class Program
    {
        private delegate int DoSomeWorkDelegate(int number);

        static void Main(string[] args)
        {
            var someDelegate = new DoSomeWorkDelegate(Substruct);
            someDelegate += Add;
            someDelegate += Multiple;

            var delegates = someDelegate.GetInvocationList();
            if (delegates != null)
            {
                int[] results = new int[delegates.Length];
                for (int i = 0; i < delegates.Length; i++)
                {
                    results[i] = (int)delegates[i].DynamicInvoke(i);
                }

                foreach (var number in results)
                {
                    Console.WriteLine(number);
                }

                Console.ReadLine();
            }
        }

        private static int Add(int number)
        {
            return number += number;
        }

        private static int Multiple(int number)
        {
            return number *= number;
        }

        private static int Substruct(int number)
        {
            return number -= number;
        }
    }
}
