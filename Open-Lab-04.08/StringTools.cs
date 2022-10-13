using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int A = 0;
            for (int i = 0; i < strings.Length ; i++)
            {
                if (strings[i].Length == 4)
                {
                    A++;
                }
            }

            int k = 0;
            string[] four_letters = new string[A];
            for (int j = 0; j < strings.Length; j++)
            {
                if (strings[j].Length == 4)
                {
                    four_letters[k] = strings[j];
                    k++;
                }
            }
            return four_letters;       
        }
    }
}
