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
            string path = "F:\\Repositories\\Task2\\Task3\\Text\\Text.txt";
            textLoader.OpenFile(path);
            textLoader.Dispose();
            Console.ReadKey();
        }
    }
}
