using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceParts.WordClass;

namespace Task2.Factories.WordFactoryItems
{
    interface IWordFactory
    {
        IWord CreateWord(char[] symbols);
    }
}
