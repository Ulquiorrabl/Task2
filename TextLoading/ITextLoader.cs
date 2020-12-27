using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Statuses;

namespace Task2.TextLoading
{
    interface ITextLoader
    {
        TextLoadingStatus OpenFile(string path);
        string GetNextLine();

    }
}
