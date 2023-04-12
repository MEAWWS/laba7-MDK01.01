using System;
using System.IO;
using System.Threading.Tasks;

namespace laba7._2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Reading file 'А.С.Пушкин - Капитанская дочка'...");

            await ReadFileAsync();
            Console.ReadLine();
            
            Console.WriteLine("File read complete.");
        }

        static async Task ReadFileAsync()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\Student\\Desktop\\Новая папка\\laba7.2\\laba7.2\\bin\\Debug\\А.С.Пушкин - Капитанская дочка.txt"))
            {
                await Task.Run(() =>
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                        Task.Delay(300);

                    }
                    
                });
               

            }
        }
    }
}
