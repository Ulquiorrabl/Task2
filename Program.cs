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
using Task2.TextClasses.SentenceClass;
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
            Console.WriteLine("Line parse status: {0}",textParser.ParseLine(s));
            s = textLoader.GetNextLine();
            Console.WriteLine("Line parse status: {0}",textParser.ParseLine(s));
            text = (Text)textFactory.CreateText();
            textLoader.Dispose();
            Console.ReadKey();

            bool menuState = true;
            while (menuState)
            {
                Console.Clear();
                Console.WriteLine("Choose needed operation");
                Console.WriteLine("1.Show parsed text");
                Console.WriteLine("2.Show Question sentences");
                Console.WriteLine("0.Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Parsed text:");
                            Console.WriteLine(text.GetText());
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error {0}", e.Message);
                        }
                        finally
                        {
                            Console.ReadKey();
                        }                     
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Question sentences:");
                        foreach(ISentence sentence in text.Value)
                        {
                            if(sentence.SentenceType == Enum.Types.SentenceType.Question)
                            {
                                Console.WriteLine(sentence);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 0:
                        menuState = false;
                        break;

                }
            }

        }
    }
}
