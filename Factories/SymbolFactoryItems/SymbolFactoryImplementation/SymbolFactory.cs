using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.TextClasses.SymbolClass;
using Task2.TextClasses.SymbolClass.SymbolImplementation;

namespace Task2.Factories.SymbolFactoryItems.SymbolFactoryImplementation
{
    class SymbolFactory : ISymbolFactory
    {
        public ISymbol CreateSymbol(char symbol)
        {
            return new Symbol(symbol);
        }
    }
}
