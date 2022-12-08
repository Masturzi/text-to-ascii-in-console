using System;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        private static readonly string[][] LETTERS = {
            new[] {"  ##### ",
                   " #     #",
                   " #     #",
                   " #######",
                   " #     #",
                   " #     #",
                   " #     #"},  // A
            new[] {" ###### ",
                   " #     #",
                   " #     #",
                   " ###### ",
                   " #     #",
                   " #     #",
                   " ###### "},  // B
            new[] {"  ##### ",
                   " #     #",
                   " #      ",
                   " #      ",
                   " #      ",
                   " #     #",
                   "  ##### "},  // C
            new[] {" ###### ",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   " ###### "},  // D
            new[] {" #######",
                   " #      ",
                   " #      ",
                   " #####  ",
                   " #      ",
                   " #      ",
                   " #######"},  // E
            new[] {" #######",
                   " #      ",
                   " #      ",
                   " #####  ",
                   " #      ",
                   " #      ",
                   " #      "},  // F
            new[] {"  ##### ",
                   " #     #",
                   " #      ",
                   " #  ####",
                   " #     #",
                   " #     #",
                   "  ##### "},  // G
            new[] {" #     #",
                   " #     #",
                   " #     #",
                   " #######",
                   " #     #",
                   " #     #",
                   " #     #"},  // H
            new[] {" ###### ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   " ###### "},  // I
            new[] {"  ##### ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   " #  #    ",
                   "  ###   "},  // J
            new[] {" #     #",
                   " #   #  ",
                   " # #    ",
                   " ##     ",
                   " #  #   ",
                   " #    # ",
                   " #     #"},  // K
            new[] {" #      ",
                   " #      ",
                   " #      ",
                   " #      ",
                   " #      ",
                   " #      ",
                   " #######"},  // L
            new[] {" #     #",
                   " ##   ##",
                   " # # # #",
                   " #  #  #",
                   " #     #",
                   " #     #",
                   " #     #"},  // M
            new[] {" #     #",
                   " ##    #",
                   " # #   #",
                   " #  #  #",
                   " #   # #",
                   " #    ##",
                   " #     #"},  // N
            new[] {"  ##### ",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   "  ##### "},  // O
            new[] {" ###### ",
                   " #     #",
                   " #     #",
                   " ###### ",
                   " #      ",
                   " #      ",
                   " #      "},  // P
            new[] {"  ##### ",
                   " #     #",
                   " #     #",
                   " #  #  #",
                   " #   # #",
                   " #    # ",
                   "  ### # "},  // Q
            new[] {" ###### ",
                   " #     #",
                   " #     #",
                   " ###### ",
                   " #   #  ",
                   " #    # ",
                   " #     #"},  // R
            new[] {"  ##### ",
                   " #     #",
                   " #      ",
                   "  ##### ",
                   "       #",
                   " #     #",
                   "  ##### "},  // S
            new[] {" #######",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   "    #   "},  // T
            new[] {" #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   "  ##### "},  // U
            new[] {" #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   " #     #",
                   "  #   # ",
                   "   ###  "},  // V
            new[] {" #     #",
                   " #     #",
                   " #     #",
                   " #  #  #",
                   " # # # #",
                   " ##   ##",
                   " #     #"},  // W
            new[] {" #     #",
                   "  #   # ",
                   "   # #  ",
                   "    #   ",
                   "   # #  ",
                   "  #   # ",
                   " #     #"},  // X
            new[] {" #     #",
                   "  #   # ",
                   "   # #  ",
                   "    #   ",
                   "    #   ",
                   "    #   ",
                   "    #   "},  // Y
            new[] {" #######",
                   "      # ",
                   "     #  ",
                   "    #   ",
                   "   #    ",
                   "  #     ",
                   " #######" },  // Z
            };

        private const int MAX_WORD_LENGTH = 15;
        private const int MAX_LINES = 7;

        private static void PrintWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("The input string cannot be null or empty.");
            }

            if (word.Length > MAX_WORD_LENGTH)
            {
                throw new ArgumentException($"The input string cannot be longer than {MAX_WORD_LENGTH} characters.");
            }

            foreach (char c in word)
            {
                if (!char.IsLetter(c) || c < 'A' || c > 'Z')
                {
                    throw new ArgumentException("The input string can only contain letters from A to Z.");
                }
            }

            for (int line = 0; line < MAX_LINES; line++)
            {
                foreach (char c in word)
                {
                    int index = char.ToUpper(c) - 'A';

                    string letterLine = LETTERS[index][line];

                    Console.Write(letterLine);
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintWord("CSCHALLENGE");

            Console.ReadKey();
        }
    }
}
