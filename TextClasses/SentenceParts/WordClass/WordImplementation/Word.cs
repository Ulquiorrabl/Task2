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
        public List<ISymbol> Value { get; }
        public int Length
        {
            get
            {
                return Value.Count;
            }
        }
        public bool IsBeginsWithVowel { get; private set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(ISymbol symbol in Value)
            {
                sb.Append(symbol.ToString());
            }
            return sb.ToString();
        }
        public Word(List<ISymbol> symbols, bool isBeginsWithVowel = false)
        {
            this.Value = new List<ISymbol>();
            this.IsBeginsWithVowel = isBeginsWithVowel;
            foreach (ISymbol symbol in symbols)
            {
                Value.Add(symbol);
            }
        }
    }
}
