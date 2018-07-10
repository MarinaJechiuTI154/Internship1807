
using System.Linq;


namespace ConsoleApp1
{
    class ParameterModifier
    {
        public static void Recursive( int number, ref int value,  ref int iteration)
        {
            if (number == 1)
            {
                iteration++;
                return;
            }
            else
            {
                iteration++;
                value = value * number;
                Recursive(number - 1, ref  value, ref iteration);
             }
        }

        public static void VowelsAndConsonants(string text, out int vowels, out int consonants)
        {
            string allVowels = "aeiou";
            string allConsonants = "bcdfghjklmnpqrstvwxyz";
            vowels = 0;
            consonants = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (allVowels.Contains(text.ToLower()[i])) vowels++;
                else if (allConsonants.Contains(text.ToLower()[i])) consonants++;
            }
        }
    }
}
