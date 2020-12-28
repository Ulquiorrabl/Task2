using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceParts.WordClass;
using Task2.TextClasses.SentenceParts.WordClass.WordImplementation;
using Task2.TextClasses.SymbolClass;

namespace Task2.Factories.WordFactoryItems.WordFactoryImplementation
{
    class WordFactory : IWordFactory
    {
        public IWord CreateWord(List<ISymbol> symbols)
        {
            return new Word(symbols);
        }
    }
}
