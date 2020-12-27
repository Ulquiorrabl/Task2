using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.WordClass;

namespace Task2.TextParsing
{
    interface ITextParser
    {
        TextParsingStatus ParseLine(string line);
        TextParsingStatus ParseSentence(ISentence sentence);
        TextParsingStatus ParseWord(IWord word);
    }
}
