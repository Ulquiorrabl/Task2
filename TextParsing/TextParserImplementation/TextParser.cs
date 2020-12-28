using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enum.Statuses;
using Task2.Enum.Types;
using Task2.Factories.TextFactoryItems;
using Task2.Factories.WordFactoryItems;
using Task2.Factories.SymbolFactoryItems;
using Task2.Factories.SentenceFactoryItems;
using Task2.TextClasses.SentenceClass;
using Task2.TextClasses.SentenceParts;
using Task2.TextClasses.SentenceParts.WordClass;
using Task2.TextClasses.SymbolClass;

namespace Task2.TextParsing.TextParserImplementation
{
    class TextParser : ITextParser
    {
        ITextFactory textFactory;
        IWordFactory wordFactory;
        ISymbolFactory symbolFactory;
        ISentenceFactory sentenceFactory;
        
        public TextParser(ITextFactory textFactory, ISentenceFactory sentenceFactory, IWordFactory wordFactory, ISymbolFactory symbolFactory)
        {
            this.textFactory = textFactory;
            this.wordFactory = wordFactory;
            this.symbolFactory = symbolFactory;
            this.sentenceFactory = sentenceFactory;
        }

        public TextParsingStatus ParseLine(string line)
        {
            StringBuilder buffer = new StringBuilder();
            List<ISymbol> symbolsBuffer = new List<ISymbol>();
            List<ISentencePart> sentencePartsBuffer = new List<ISentencePart>();
            ISymbol tempSymbol;
            try
            {
                foreach (char ch in line)
                {
                    tempSymbol = symbolFactory.CreateSymbol(ch);
                    symbolsBuffer.Add(tempSymbol);
                    if(tempSymbol.SymbolType == SymbolType.WordSlpitter)
                    {
                        sentencePartsBuffer.Add((ISentencePart)wordFactory.CreateWord(symbolsBuffer.ToArray()));
                        symbolsBuffer.Clear();
                    }
                    if(tempSymbol.SymbolType == SymbolType.SentenceSplitter)
                    {
                        textFactory.AddSentence(sentenceFactory.CreateSentece(sentencePartsBuffer.ToArray()));
                    }
                }
                return TextParsingStatus.LineParsed;
            }
            catch
            {
                return TextParsingStatus.Error;
            }
        }

        public TextParsingStatus ParseSentence(ISentence sentence)
        {
            return TextParsingStatus.Error;
        }

        public TextParsingStatus ParseWord(IWord word)
        {
            return TextParsingStatus.Error;
        }
    }
}
