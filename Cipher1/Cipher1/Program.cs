using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher1
{
    class Program
    {
        static void Main(string[] args)
        {                                      // 0    1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23   24   25
            string[] alphabet = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[,] tabulaRecta = new string[26, 26];
            string input;
            string plainText;
            string key = "";


            // Initialize the tabula recta
            for (int i = 0; i < 26; i++) // Set the first column
                tabulaRecta[i, 0] = alphabet[i];

            for (int j = 0; j < 26; j++) // These loops load the tabula recta, row by row
            {
                for (int k = 1; k < 26; k++)  // First column is already set, start at 1
                {
                    int tupac; // Wraps the index around

                    if (j + k > 25)
                    {
                        tupac = (j + k) - 26;

                        tabulaRecta[j, k] = alphabet[tupac];
                    }
                    else
                    {
                        tupac = j + k;

                        tabulaRecta[j, k] = alphabet[tupac];
                    }

                }

            }

            // Get all the input and convert it to upper case, remove the spaces
            Console.Write("Enter message: ");
            input = Console.ReadLine().ToUpper();

            plainText = input.Replace(" ", string.Empty);
            Console.WriteLine("\nYour plaintext: " + plainText);

            bool badInput = true;
            while (badInput) // Error handling, checking key length
            {
                Console.Write("\nEnter key (less characters than message): ");
                input = Console.ReadLine().ToUpper();
                input = input.Replace(" ", string.Empty);

                if (input.Length <= plainText.Length)
                    badInput = false;
                else
                    Console.Write("\nToo long, try again.\n");

            }

            Console.WriteLine("\nYour key: " + input);

            // NOTE TO SELF: FIGURE OUT HOW TO REPEAT THE KEY ENOUGH TIMES TO MATCH THE MESSAGE

            Console.ReadLine();
        }
    }
}
