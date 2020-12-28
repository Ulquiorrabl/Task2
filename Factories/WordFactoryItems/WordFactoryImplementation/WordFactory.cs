using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SentenceParts.WordClass;
using Task2.TextClasses.SentenceParts.WordClass.WordImplementation;
using Task2.TextClasses.SymbolClass;
using Task2.Enum.Types;

namespace Task2.Factories.WordFactoryItems.WordFactoryImplementation
{
    class WordFactory : IWordFactory
    {
        public IWord CreateWord(List<ISymbol> symbols)
        {
            bool isBeginsWithVowel = false;
            if(symbols.Count != 0)
            {
                if (symbols[0].SymbolType == SymbolType.Vowel)
                {
                    isBeginsWithVowel = true;
                }
            }
            
            return new Word(symbols, isBeginsWithVowel);
        }
    }
}
