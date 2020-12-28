using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.TextClasses.TextClass
{
    interface IText
    {
        int Length { get; }

        string GetText();
    }
}
