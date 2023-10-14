using System;
using System.Text;
using System.Text.RegularExpressions;

namespace JokesParser
{
    internal class Action
    {
        public Action(int index)
        {
            SelectAction(index)();
        }

        private string NumberConverter(char number) => number switch
        {
            '0' => "НОЛЬ",
            '1' => "ОДИН",
            '2' => "ДВА",
            '3' => "ТРИ",
            '4' => "ЧЕТЫРЕ",
            '5' => "ПЯТЬ",
            '6' => "ШЕСТЬ",
            '7' => "СЕМЬ",
            '8' => "ВОСЕМЬ",
             _ => "ДЕВЯТЬ"            
        };

        public StringAction SelectAction(int index) => index switch
        {
            1 => FindMaxLenghtWord,
            2 => NumbersToWords,
            3 => SortInterrogative,
            4 => ShowWithoutComma,
            5 => SameLetters,
            _ => IncorrectInput
        };

        public void FindMaxLenghtWord()
        {
            var joke = Joke.Value;
            var max = joke.Split(' ').OrderByDescending(x => x.Length).FirstOrDefault();

            Menu.ShowColoredResult("Самое длинное слово ", max);
        }

        public void NumbersToWords()
        {
            var joke = Joke.Value;
            var splittedWords = joke.Split(' ');

            for (int i = 0; i < splittedWords.Length; i++)
            { 
                for(int j = 0; j < splittedWords[i].Length; j++)
                {
                    if (char.IsNumber(splittedWords[i][j]))
                    {
                        int.TryParse(splittedWords[i][j].ToString(), out int value);
                        var newValue = NumberConverter(splittedWords[i][j]);

                        var sb = new StringBuilder(splittedWords[i]);
                        sb.Remove(j, 1);
                        sb.Insert(j, newValue);

                        splittedWords[i] = sb.ToString();
                        j += newValue.Length-1;
                    }
                }                
            }

            var result = string.Join(' ', splittedWords);
            Menu.ShowColoredResult("Заменили цифры на слова ", result);
        }

        

        public void SortInterrogative()
        {
            var joke = Joke.Value;
            var interrogative = new Regex(@"[\w\,\-\s]*\?");
            var exclamatory = new Regex(@"[\w\,\-\s]*\!");
            var matchesInterrogative = interrogative.Matches(joke);
            var matchesExclamatory = exclamatory.Matches(joke);
            var sb = new StringBuilder();

            foreach(Match match in matchesInterrogative)
            {
                sb.Append(match.Value);
            }

            foreach(Match match in matchesExclamatory)
            {
                sb.Append(match.Value);
            }

            var result = sb.ToString();
            Menu.ShowColoredResult("Вывели сперва вопросительные предложения, затем восклицательные при наличии. ", result);
        }

        public void ShowWithoutComma()
        {
            var joke = Joke.Value;
            var noComma = new Regex(@"[А-Я]+[^,]+\w[.!?]");
            var matches = noComma.Matches(joke);
            var sb = new StringBuilder();

            foreach(Match match in matches)
            {
                sb.Append(match.Value);
            }

            var result = sb.ToString();
            Menu.ShowColoredResult("Вывели предложения без зяпятых. ", result);
        }

        public void SameLetters()
        {
            var joke = Joke.Value;
            var same = new Regex(@"\b([A-zА-яЁё])[A-zА-яЁё]+?\1\b");
            var matches = same.Matches(joke);
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Value + " ");
            }

            var result = sb.ToString();
            Menu.ShowColoredResult("Слова начинающиеся и заканчивающиеся на одну букву. ", result);
        }

        public void IncorrectInput()
        {
            Console.WriteLine("Неверный ввод");
        }
    }



    public delegate void StringAction();
}
