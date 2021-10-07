using System;
using System.Collections.Generic;
using System.Text;

namespace WordFinder1

{
    static class Finder
    {

        public static bool Find(this string str, string word)
        {
            string[] arr = str.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                char[] newstr = arr[i].ToCharArray();

                string mergestr = string.Empty;
                if (word.Length <= str.Length)
                {
                    for (int j = 0; j < newstr.Length; j++)
                    {
                        if (word[0] == newstr[j])
                        {
                            for (int y = j; y < word.Length; y++)
                            {
                                mergestr += newstr[y];
                            }
                            if (word == mergestr)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
