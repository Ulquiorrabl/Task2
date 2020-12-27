using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum;
using Task2.Factories.TextFactoryItems;
using Task2.Factories.WordFactoryItems;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.WordClass;

namespace Task2.TextParsing.TextParserImplementation
{
    class TextParser : ITextParser
    {
        ITextFactory textFactory;
        IWordFactory wordFactory;
        
        public TextParser(ITextFactory textFactory, IWordFactory wordFactory)
        {
            this.textFactory = textFactory;
            this.wordFactory = wordFactory;
        }

        public TextParsingStatus ParseLine(string line)
        {
            StringBuilder buffer = new StringBuilder();
            try
            {
                foreach (char ch in line)
                {
                    if (ch != '!')
                    {
                        buffer.Append(ch);
                    }
                    else
                    {
                        textFactory.AddSentence(buffer.ToString());
                    }
                }
                return TextParsingStatus.LineParsed;
            }
            catch
            {
                return TextParsingStatus.Error;
            }
        }

        public TextParsingStatus ParseSentence(ISentence sentence)
        {

        }

        public TextParsingStatus ParseWord(IWord word)
        {
            
        }
    }
}
