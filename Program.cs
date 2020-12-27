using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextLoading.TextLoaderImplementation;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextLoader textLoader = new TextLoader();
            Console.WriteLine(textLoader.OpenFile("Text.txt"));
            Console.WriteLine(textLoader.GetNextLine());
            Console.ReadKey();
        }
    }
}
