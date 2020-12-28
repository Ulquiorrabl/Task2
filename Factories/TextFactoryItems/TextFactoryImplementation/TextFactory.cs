using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Statuses;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.TextClass;

namespace Task2.Factories.TextFactoryItems.TextFactoryImplementation
{
    class TextFactory : ITextFactory
    {
        List<ISentence> sentences;

        public TextFactory()
        {
            sentences = new List<ISentence>();
        }

        public TextFactoryStatus AddSentence(ISentence sentence)
        {
            try
            {
                sentences.Add(sentence);
                Console.WriteLine(sentence);
                return TextFactoryStatus.SentenceAdded;
            }
            catch
            {
                return TextFactoryStatus.Error;
            }
        }

        public IText CreateText()
        {
            return new Text(sentences.ToArray());
        }
    }
}
