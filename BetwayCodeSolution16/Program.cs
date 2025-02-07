using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetwayCodeSolution16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Za^B8g@E2jH*kWl!MoPqXr7YvT1c$Fs3Ud9IwZ&yX0pLkV6sHqN^tB4rA+oZ%gFj";
            string output = ReformatAlternatingCase(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }
        static string ReformatAlternatingCase(string s)
        {
            char[] result = new char[s.Length];
            bool upper = true; 
            int alphaIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    result[i] = upper ? char.ToUpper(s[i]) : char.ToLower(s[i]);
                    upper = !upper; 
                }
                else
                {
                    result[i] = s[i]; 
                }
            }
            return new string(result);
        }
    }
}
