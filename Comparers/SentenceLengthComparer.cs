using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;

namespace Task2.Comparers
{
    class SentenceLengthComparer : IComparer<ISentence>
    {
        public int Compare(ISentence x, ISentence y)
        {
            return x.NumberOfWords.CompareTo(y.NumberOfWords);
        }
    }
}
