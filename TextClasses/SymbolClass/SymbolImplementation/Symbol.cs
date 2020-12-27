using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Types;

namespace Task2.TextClasses.SymbolClass.SymbolImplementation
{
    class Symbol : ISymbol
    {
        public char Value { get; }

        public SymbolType SymbolType { get; }

        public Symbol(char symbol)
        {
            this.Value = symbol;
            if (IsFowel(symbol))
            {
                SymbolType = SymbolType.Vowel;
            }
            else if(IsSplitter())
            {
                SymbolType = SymbolType.Consonant;
            }
        }

        bool IsFowel(char ch)
        {
            return "aeiouAEIOU".IndexOf(ch) >= 0;
        }

        bool IsSplitter()
        {
            return false;
        }
    }
}
