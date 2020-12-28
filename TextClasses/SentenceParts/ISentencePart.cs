using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Task2.TextClasses.SymbolClass;

namespace Task2.TextClasses.SentenceParts
{
    interface ISentencePart
    {
        List<ISymbol> Value { get; }
        int Length { get; }
        string ToString();
    }
}