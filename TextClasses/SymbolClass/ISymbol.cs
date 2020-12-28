using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Types;

namespace Task2.TextClasses.SymbolClass
{
    interface ISymbol
    {
        char Value { get; }
        SymbolType SymbolType { get; }

        string ToString();
    }
}
