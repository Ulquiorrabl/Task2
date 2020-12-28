using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.SentenceParts;
using Task2.TextClasses.SentenceClass.SentenceImplementation;
using Task2.Enum.Types;

namespace Task2.Factories.SentenceFactoryItems.SentenceFactoryImplementation
{
    class SentenceFactory : ISentenceFactory
    {
        public ISentence CreateSentece(List <ISentencePart> sentenceParts)
        {
            if (sentenceParts[sentenceParts.Count-1].Value[0].SymbolSentenceType == SymbolSentenceType.Question)
            {
                return new Sentence(sentenceParts, SentenceType.Question);
            }
            if (sentenceParts[sentenceParts.Count-1].Value[0].SymbolSentenceType == SymbolSentenceType.Exclaimor)
            {
                return new Sentence(sentenceParts, SentenceType.Exclamatory);
            }
            return new Sentence(sentenceParts);
        }
    }
}
