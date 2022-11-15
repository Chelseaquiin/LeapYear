using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class ToEnglish
    {
        public string Word { get; set; }
        public string ConvertToEnglish(string pigLatin)
        {
            List<string> englishWords = new List<string>();

            foreach (string word in pigLatin.Split(' '))
            {

                string newWord = word.Substring(0, word.Length - 2);
                englishWords.Add(newWord.ElementAt(newWord.Length - 1) + newWord.Substring(0, newWord.Length - 1));

            }
            return string.Join(" ", englishWords);


        }
    }
}
