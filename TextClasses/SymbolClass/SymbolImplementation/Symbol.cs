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

        public override string ToString()
        {
            return Value.ToString();
        }

        public Symbol(char symbol)
        {
            this.Value = symbol;
            if (IsFowel(symbol))
            {
                SymbolType = SymbolType.Vowel;
            }
            else if(IsSentenceSplitter(symbol))
            {
                SymbolType = SymbolType.SentenceSplitter;
            }
            else if (IsWordSplitter(symbol))
            {
                SymbolType = SymbolType.WordSlpitter;
            }
            else
            {
                SymbolType = SymbolType.Consonant;
            }
        }

        bool IsFowel(char ch)
        {
            return "aeiouAEIOU".IndexOf(ch) >= 0;
        }

        bool IsSentenceSplitter(char ch)
        {
            if(ch == '!')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IsWordSplitter(char ch)
        {
            if(ch == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
