using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSlow.Helpers
{
    public class RandomText
    {
        private string Content => _builder.ToString();

        private string[] _words = { "anemone", "wagstaff", "man", "the", "for", "and", "a", "with", "bird", "fox" };
        StringBuilder _builder = new StringBuilder();

        public string RandomWords(int minWords = 1, int maxWords = 10)
        {
            _builder = new StringBuilder();
            AddSentence(Constants.Random.Next(minWords, maxWords + 1));
            return Content;
        }

        public string RandomSentences()
        {
            _builder = new StringBuilder();
            AddContentParagraphs(2, 2, 4, 5, 12);
            return Content;
        }

        private void AddContentParagraphs(int numberParagraphs, int minSentences, int maxSentences, int minWords, int maxWords)
        {
            for (var i = 0; i < numberParagraphs; i++)
            {
                AddParagraph(Constants.Random.Next(minSentences, maxSentences + 1), minWords, maxWords);
                _builder.Append($"{Environment.NewLine}{Environment.NewLine}");
            }
        }

        private void AddParagraph(int numberSentences, int minWords, int maxWords)
        {
            for (var i = 0; i < numberSentences; i++)
            {
                var count = Constants.Random.Next(minWords, maxWords + 1);
                AddSentence(count);
            }
        }

        private void AddSentence(int numberWords)
        {
            var b = new StringBuilder();
            // Add n words together.
            for (int i = 0; i < numberWords; i++) // Number of words
            {
                b.Append(_words[Constants.Random.Next(_words.Length)]).Append(" ");
            }
            var sentence = $"{b.ToString().Trim()}. ";
            // Uppercase sentence
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);
            // Add this sentence to the class
            _builder.Append(sentence);
        }
    }
}
