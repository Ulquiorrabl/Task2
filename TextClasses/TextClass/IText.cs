using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceClass;

namespace Task2.TextClasses.TextClass
{
    interface IText
    {
        int Length { get; }
        List<ISentence> Value { get; }
        string GetText();
    }
}
