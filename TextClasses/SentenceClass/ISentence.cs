using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Types;
using Task2.TextClasses.SentenceParts;

namespace Task2.TextClasses.SentenceClass
{
    interface ISentence
    {
        int NumberOfWords { get; }
        SentenceType SentenceType { get; }
        ISentencePart[] Value { get; }

        string ToString();
    }
}
