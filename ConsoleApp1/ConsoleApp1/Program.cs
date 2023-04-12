using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main()
        {

            Task taskA = MethodA();
            Task taskB = MethodB();
            Task taskC = MethodC();

            await Task.WhenAll(taskA, taskB, taskC);

            Console.WriteLine("All tasks completed.");

            Console.ReadKey();
        }

        static async Task MethodA()
        {
            Console.WriteLine("Method A started.");
            await Task.Delay(5000);
            Console.WriteLine("Method A completed.");
        }

        /// <summary>
        /// fgsdfgds
        /// </summary>
        /// <returns>sadfsafsad</returns>
        static async Task MethodB()
        {
            Console.WriteLine("Method B started.");
            await Task.Delay(3000);
            Console.WriteLine("Method B completed.");
        }

        static async Task MethodC()
        {
            Console.WriteLine("Method C started.");
            await Task.Delay(2000);
            Console.WriteLine("Method C completed.");
        }

        /// <summary>
        /// dsafdsa
        /// </summary>
        /// <param name="a">dasas</param>
        /// <param name="b">sadfdsa</param>
        void A(int a, int b)
        {

        }

        void B()
        {

        }
        
    }
}
