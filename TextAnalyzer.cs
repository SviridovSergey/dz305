using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz0306
{
    internal class TextAnalyzer
    {
        interface IProblemAnalyzer
    {
        int CheckProblems(string text);
        List<string> ListProblems { get; }
    }

    class SpellingAnalyzer : IProblemAnalyzer
    {
        public List<string> ListProblems { get; private set; } = new List<string>() { "Mispelled words" };

        public int CheckProblems(string text)
        {
            // Проверка на орфографические ошибки
            int numProblems = 0;
            // Примерная реализация, надо использовать библиотеку для проверки правописания
            // здесь код проверки текста на орфографические ошибки и подсчет их количества
            return numProblems;
        }
    }

    class LengthAnalyzer : IProblemAnalyzer
    {
        public List<string> ListProblems { get; private set; } = new List<string>() { "Text length exceeds limit" };
        public int MaxLength { get; }

        public LengthAnalyzer(int maxLength)
        {
            MaxLength = maxLength;
        }

        public int CheckProblems(string text)
        {
            // Проверка на превышение максимальной длины текста
            int numProblems = 0;
            if (text.Length > MaxLength)
            {
                numProblems++;
            }
            return numProblems;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string textToAnalyze = "Some sample text to analyze";

            IProblemAnalyzer spellingAnalyzer = new SpellingAnalyzer();
            IProblemAnalyzer lengthAnalyzer = new LengthAnalyzer(50);

            int numSpellingProblems = spellingAnalyzer.CheckProblems(textToAnalyze);
            int numLengthProblems = lengthAnalyzer.CheckProblems(textToAnalyze);

            Console.WriteLine("Number of spelling problems: " + numSpellingProblems);
            Console.WriteLine("Number of length problems: " + numLengthProblems);
        }
    }
}

    }
}
