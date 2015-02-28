using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class TestAnagrams
    {
        public bool testPhrases(string alpha_, string beta_)
        {
            //**Test for appropriate string content - if not, they are not valid anagrams of each other.
            if(string.IsNullOrWhiteSpace(alpha_) || string.IsNullOrWhiteSpace(beta_))
            {
                return false;
            }

            //Store local, working versions of the passed strings
            string workingAlpha = alpha_;
            string workingBeta = beta_;

            //Remove punctuation
            workingAlpha = RemovePunctuation(workingAlpha);
            workingBeta = RemovePunctuation(workingBeta);

            //Remove whitespace
            workingAlpha = workingAlpha.Replace(" ", "");
            workingBeta = workingBeta.Replace(" ", "");

            //**Test if both strings are the same length - if not, they are not anagrams of each other.
            if (workingAlpha.Length != workingBeta.Length)
                return false;

            //Make consistent case for testing
            workingAlpha = workingAlpha.ToUpper();
            workingBeta = workingBeta.ToUpper();

            //Convert strings to char arrays
            char[] arrayAlpha = workingAlpha.ToCharArray();
            char[] arrayBeta = workingBeta.ToCharArray();

            //Sort arrays
            Array.Sort(arrayAlpha);
            Array.Sort(arrayBeta);


            //Debuging output to console for visual comparison
            //Console.WriteLine(alpha_ + "\n" + workingAlpha + "\n" + new string(arrayAlpha) + "\n");
            //Console.WriteLine(beta_ + "\n" + workingBeta + "\n" + new string(arrayBeta) + "\n");


            //**Compare arrays - if any two letters don't match, the strings are not anagrams of each other.
            for (int i = 0; i < arrayAlpha.Length; ++i )
            {
                if(arrayAlpha[i] != arrayBeta[i])
                {
                    return false;
                }
            }

            //**If we get this far, the strings are anagrams of each other - Hazzah!!!
            return true;
        }

        private string RemovePunctuation(string passedString_)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in passedString_)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
