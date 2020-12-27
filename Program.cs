using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextLoading.TextLoaderImplementation;
using Task2.TextParsing.TextParserImplementation;
using Task2.Factories.SentenceFactoryItems.SentenceFactoryImplementation;
using Task2.Factories.SymbolFactoryItems.SymbolFactoryImplementation;
using Task2.Factories.TextFactoryItems.TextFactoryImplementation;
using Task2.Factories.WordFactoryItems.WordFactoryImplementation;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SentenceFactory sentenceFactory = new SentenceFactory();
            TextLoader textLoader = new TextLoader();
            TextParser textParser = new TextParser();
            string path = "F:\\Repositories\\Task2\\Task3\\Text\\Text.txt";
            textLoader.OpenFile(path);
            textLoader.Dispose();
            Console.ReadKey();
        }
    }
}
