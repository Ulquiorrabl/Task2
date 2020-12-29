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

        public Symbol(char symbol, SymbolType symbolType, SymbolSentenceType symbolSentenceType)
        {
            this.Value = symbol;
            this.SymbolType = symbolType;
            this.SymbolSentenceType = symbolSentenceType;
        }
    }

        
}
