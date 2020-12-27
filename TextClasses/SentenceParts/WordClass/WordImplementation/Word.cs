using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SymbolClass;

namespace Task2.TextClasses.SentenceParts.WordClass.WordImplementation
{
    class Word : IWord
    {
        public ISymbol[] Value { get; }

        public int Length { get; }
        public Word(ISymbol[] symbols)
        {
            this.Value = symbols;
            this.Length = Value.Length;
        }
    }
}
