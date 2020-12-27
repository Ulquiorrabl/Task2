using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Statuses;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.SentenceParts.WordClass;

namespace Task2.Factories.TextFactoryItems
{
    interface ITextFactory
    {
        TextFactoryStatus AddSentence(ISentence sentence);
        TextFactoryStatus AddWord(IWord word);
    }
}
