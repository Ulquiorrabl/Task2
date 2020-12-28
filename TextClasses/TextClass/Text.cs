using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;

namespace Task2.TextClasses.TextClass
{
    class Text : IText
    {
        List<ISentence> textSentences;

        public int Length
        {
            get
            {
                return textSentences.Count;
            }
        }

        public Text(ISentence[] sentences)
        {
            textSentences = new List<ISentence>();
            try
            {
                foreach(ISentence sentence in sentences)
                {
                    this.textSentences.Add(sentence);
                }
            }
            catch
            {

            }
        }

        public string GetText()
        {
            if(textSentences != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (ISentence sentence in textSentences)
                {
                    sb.Append(sentence.ToString());
                }
                return sb.ToString();
            }
            else
            {
                throw new Exception("There is no sentences in text");
            }
        }
    }
}
