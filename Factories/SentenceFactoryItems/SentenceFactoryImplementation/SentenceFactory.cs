using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.SentenceParts;
using Task2.TextClasses.SentenceClass.SentenceImplementation;
using Task2.Enum.Types;
using Task2.TextClasses.SentenceParts.WordClass;

namespace Task2.Factories.SentenceFactoryItems.SentenceFactoryImplementation
{
    class SentenceFactory : ISentenceFactory
    {
        public ISentence CreateSentece(List <ISentencePart> sentenceParts)
        {
            int numberOfWords = 0;
            SentenceType sentenceType = SentenceType.Declarative;
            foreach(IWord word in sentenceParts)
            {
                numberOfWords++;
            }
            if (sentenceParts[sentenceParts.Count-1].Value[0].SymbolSentenceType == SymbolSentenceType.Question)
            {
                sentenceType = SentenceType.Question;
            }
            if (sentenceParts[sentenceParts.Count-1].Value[0].SymbolSentenceType == SymbolSentenceType.Exclaimor)
            {
                sentenceType = SentenceType.Exclamatory;
            }
            return new Sentence(sentenceParts, sentenceType, numberOfWords);
        }
    }
}
