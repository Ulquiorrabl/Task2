using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.SentenceParts;
using Task2.TextClasses.SentenceClass.SentenceImplementation;

namespace Task2.Factories.SentenceFactoryItems.SentenceFactoryImplementation
{
    class SentenceFactory : ISentenceFactory
    {
        public ISentence CreateSentece(ISentencePart[] sentenceParts)
        {
            return new Sentence(sentenceParts);
        }
    }
}
