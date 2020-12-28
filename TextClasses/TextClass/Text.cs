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
        public List<ISentence> Value { get; private set; }

        public int Length
        {
            get
            {
                return Value.Count;
            }
        }

        public Text(List<ISentence> sentences)
        {
            Value = new List<ISentence>();
            try
            {
                foreach(ISentence sentence in sentences)
                {
                    this.Value.Add(sentence);
                }
            }
            catch
            {

            }
        }

        public string GetText()
        {
            if(Value != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (ISentence sentence in Value)
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
