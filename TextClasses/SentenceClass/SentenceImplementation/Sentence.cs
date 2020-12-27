using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Types;
using Task2.TextClasses.SentenceParts;

namespace Task2.TextClasses.SentenceClass.SentenceImplementation
{
    class Sentence : ISentence
    {
        public int NumberOfWords { get; }
        public SentenceType SentenceType { get; }

        public Sentence(ISentencePart[] sentenceParts)
        {

        }
    }
}
