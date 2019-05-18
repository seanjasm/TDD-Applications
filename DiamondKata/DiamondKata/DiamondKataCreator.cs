using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
    class DiamondKataCreator
    {
        private static List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H",
        "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

        public static string GetShape(string letter)
        {
            int index = letters.IndexOf(letter);//Getthe position of the letter to determine the length
            string diamond = "";
            int length = index * 2 + 1;//length is 2n + 1
            

            for (int i = 0; i <= index; i++)
            {
                //sends each character to be printed from beginning of list
                diamond += AddSpaces(letters[i].ToCharArray()[0], i, length);
            }

            for (int i = index-1; i >= 0; i--)
            {
                //sends each character to be printed in reverse order except the last printed letter   
                //sends i as the postion away from center eg. A is 0 away and C is 2 away from middle
                diamond += AddSpaces(letters[i].ToCharArray()[0], i, length);
            }

            return diamond;
        }

        /// <summary>
        ///  Returns the string with the letter printed in the correct postion from the middle
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="awayFromMiddle">The index of the letter in the list serves as the position away from th middle</param
        /// <param name="length">The length is useed to set the size of the character array</param>
        /// <returns>string</returns>
        private static string AddSpaces(char letter, int awayFromMiddle, int length)
        {            
            char[] word = new char[length];
            int middle = length / 2;//the length is always an odd number. The position is legnth divided by 2
            string newWord = "";

            //sets the letter in the correct distance away from the middle, on the left and on the right
            word[middle + awayFromMiddle] = letter;
            word[middle - awayFromMiddle] = letter;

            //Replaces \0 with an empty space 
            foreach(char c in word)
            {
                newWord += c.ToString() == "\0"? " ": c.ToString();
            }
            
            return newWord + "\n";
        }
    }
}
