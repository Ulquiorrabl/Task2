using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.SentenceParts;

namespace Task2.Factories.SentenceFactoryItems
{
    interface ISentenceFactory
    {
        ISentence CreateSentece(ISentencePart[] sentenceParts);
    }
}
