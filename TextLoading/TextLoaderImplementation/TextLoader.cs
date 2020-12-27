﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task2.Enum;

namespace Task2.TextLoading.TextLoaderImplementation
{
    class TextLoader : ITextLoader
    {
        StreamReader sr;

        public string GetNextLine()
        {
            return sr.ReadLine();
        }

        public TextLoadingStatus OpenFile(string path)
        {
            try
            {
                sr = new StreamReader(path);
                return TextLoadingStatus.FileOpened;
            }
            catch
            {
                return TextLoadingStatus.FileNotFound;
            }
        }
    }
}
