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
using Task2.TextClasses.TextClass;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text;
            SentenceFactory sentenceFactory = new SentenceFactory();
            SymbolFactory symbolFactory = new SymbolFactory();
            TextFactory textFactory = new TextFactory();
            WordFactory wordFactory = new WordFactory();
            TextLoader textLoader = new TextLoader();
            TextParser textParser = new TextParser(textFactory, sentenceFactory, wordFactory, symbolFactory);
            string path = "F:\\Repositories\\Task2\\Task3\\Text\\Text.txt";
            textLoader.OpenFile(path);
            string s = textLoader.GetNextLine();
            Console.WriteLine(textParser.ParseLine(s));
            StringBuilder sb = new StringBuilder();
            try
            {
                text = (Text)textFactory.CreateText();
                Console.WriteLine(text.GetText());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            textLoader.Dispose();
            Console.ReadKey();
        }
    }
}
