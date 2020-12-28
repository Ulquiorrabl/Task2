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
using Task2.TextClasses.SentenceParts.WordClass;
using Task2.TextClasses.SentenceParts;
using Task2.Enum.Types;
using Task2.Comparers;

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
                int input = 0;
                Console.Clear();
                Console.WriteLine("Choose needed operation");
                Console.WriteLine("1.Show parsed text");
                Console.WriteLine("2.Show words with needed length in question sentences");
                Console.WriteLine("3.Show sentences in increasing order");
                Console.WriteLine("4.Remove words with needed length");
                Console.WriteLine("0.Exit");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error input, please, try again:");
                    Console.ReadKey();
                }
                
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
                        Console.WriteLine("Show words with needed length in question sentences");
                        Console.WriteLine("Input length of word: ");
                        int length = int.Parse(Console.ReadLine());
                        foreach (ISentence sentence in text.Value)
                        {
                            if(sentence.SentenceType == SentenceType.Question)
                            {
                                foreach(ISentencePart word in sentence.Value)
                                {
                                    if(word.Length == length)
                                    {
                                        Console.Write(word + " ");
                                    }
                                }
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Show sentences in increasing order");
                        Text temp = new Text(text.Value);
                        temp.Value.Sort(new SentenceLengthComparer());
                        foreach(ISentence sentence in temp.Value)
                        {
                            Console.WriteLine(sentence);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Remove all words with needed length");
                        Console.WriteLine("Input word length:");
                        int wordLength = int.Parse(Console.ReadLine());
                        foreach(ISentence sentence in text.Value)
                        {
                            sentence.Value.RemoveAll(word => word.Length == wordLength);
                        }
                        break;
                    case 0:
                        menuState = false;
                        break;

                }
            }

        }
    }
}
