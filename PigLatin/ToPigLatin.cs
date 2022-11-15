using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class ToPigLatin
    {


        public string ConvertToPigLatin(string sentence)
        {
            List<string> pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                pigWords.Add(word.Substring(1) + word.ElementAt(0) + "ay");
            }

            return string.Join(" ", pigWords);
        }
    }
}
