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
        public SymbolType SymbolType { get; private set; }
        public SymbolSentenceType SymbolSentenceType { get; private set; }

        public override string ToString()
        {
            return Value.ToString();
        }

        public Symbol(char symbol)
        {
            this.Value = symbol;
            SymbolTypeCheck(symbol);
            SymbolSentenceTypeCheck(symbol);
        }

        void SymbolTypeCheck(char symbol)
        {
            if (IsFowel(symbol))
            {
                this.SymbolType = SymbolType.Vowel;
            }
            else if (IsSentenceSplitter(symbol))
            {
                this.SymbolType = SymbolType.SentenceSplitter;
            }
            else if (IsWordSplitter(symbol))
            {
                this.SymbolType = SymbolType.WordSlpitter;
            }
            else
            {
                this.SymbolType = SymbolType.Consonant;
            }
        }

        void SymbolSentenceTypeCheck(char symbol)
        {
            switch (symbol)
            {
                case '?':
                    this.SymbolSentenceType = SymbolSentenceType.Question;
                    break;
                case '!':
                    this.SymbolSentenceType = SymbolSentenceType.Exclaimor;
                    break;
                case ' ':
                    this.SymbolSentenceType = SymbolSentenceType.Space;
                    break;
                default:
                    this.SymbolSentenceType = SymbolSentenceType.Dot;
                    break;
            }
        }

        bool IsFowel(char ch)
        {
            return "aeiouAEIOU".IndexOf(ch) >= 0;
        }

        bool IsSentenceSplitter(char ch)
        {
            if(ch == '!' || ch =='.' || ch == '?')
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
            if(ch == ' ' || ch == ',')
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
