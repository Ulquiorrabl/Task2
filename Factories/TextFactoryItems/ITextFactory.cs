using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum;
using Task2.TextClasses.SentenceClass;

namespace Task2.TextFactoryItems
{
    interface ITextFactory
    {
        TextFactoryStatus AddSentence(ISentence sentence);
    }
}
