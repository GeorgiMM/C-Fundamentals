using System;

namespace P04WordInPlural
{
    class P04WordInPlural
    {
        static void Main(string[] args)
        {

            string word;

            word = Console.ReadLine();

            if (word.EndsWith('y'))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||  word.EndsWith('s') ||  word.EndsWith("x") || word.EndsWith("z"))
            {
                word += "es";
            }
            else if (word.EndsWith("ch") || word.EndsWith("sh"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
