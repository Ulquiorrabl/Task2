using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SymbolClass;

namespace Task2.Factories.SymbolFactoryItems
{
    interface ISymbolFactory
    {
        ISymbol CreateSymbol(char symbol);
    }
}
