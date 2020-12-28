using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SymbolClass;

namespace Task2.TextClasses.SentenceParts.WordClass.WordImplementation
{
    class Word : IWord, ISentencePart
    {
        public ISymbol[] Value { get; }
        public int Length { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(ISymbol symbol in Value)
            {
                sb.Append(symbol.ToString());
            }
            return sb.ToString();
        }
        public Word(ISymbol[] symbols)
        {
            this.Value = symbols;
            this.Length = Value.Length;
        }
    }
}
