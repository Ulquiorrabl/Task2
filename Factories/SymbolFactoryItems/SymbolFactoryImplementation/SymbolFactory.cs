using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SymbolClass;
using Task2.TextClasses.SymbolClass.SymbolImplementation;
using Task2.Enum.Types;

namespace Task2.Factories.SymbolFactoryItems.SymbolFactoryImplementation
{
    class SymbolFactory : ISymbolFactory
    {
        SymbolType symbolType = SymbolType.NotDefined;
        SymbolSentenceType symbolSentenceType = SymbolSentenceType.NotDefined;
        public ISymbol CreateSymbol(char symbol)
        {
            SymbolTypeCheck(symbol);
            SymbolSentenceTypeCheck(symbol);
            return new Symbol(symbol, symbolType, symbolSentenceType);
        }

        void SymbolTypeCheck(char symbol)
        {
            if (IsFowel(symbol))
            {
                this.symbolType = SymbolType.Vowel;
            }
            else if (IsSentenceSplitter(symbol))
            {
                this.symbolType = SymbolType.SentenceSplitter;
            }
            else if (IsWordSplitter(symbol))
            {
                this.symbolType = SymbolType.WordSlpitter;
            }
            else
            {
                this.symbolType = SymbolType.Consonant;
            }
        }

        void SymbolSentenceTypeCheck(char symbol)
        {
            switch (symbol)
            {
                case '?':
                    this.symbolSentenceType = SymbolSentenceType.Question;
                    break;
                case '!':
                    this.symbolSentenceType = SymbolSentenceType.Exclaimor;
                    break;
                case ' ':
                    this.symbolSentenceType = SymbolSentenceType.Space;
                    break;
                default:
                    this.symbolSentenceType = SymbolSentenceType.Dot;
                    break;
            }
        }

        bool IsFowel(char ch)
        {
            return "aeiouAEIOU".IndexOf(ch) >= 0;
        }

        bool IsSentenceSplitter(char ch)
        {
            if (ch == '!' || ch == '.' || ch == '?')
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
            if (ch == ' ' || ch == ',')
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
