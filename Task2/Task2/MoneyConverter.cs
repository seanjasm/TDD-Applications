using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MoneyConverter
    {
        private static bool isGreat;
        private static string join;

        public static string GetMoneyWord(double money)
        {
            string[] words = money.ToString().Split('.');
            int counter = words[0].Length-1;
            string word = "";
            int[] array = new int[words[0].Length];
            bool teen = false;
            bool showThousand = true;

            join = " And ";
            isGreat = false;

                        
            foreach(char c in words[0])
            {
                array[counter] = int.Parse(c.ToString());
                counter--;
            }

           

            for (int i = array.Length - 1; i >= 0; i--)
            {               

                if (i == 0)
                {
                    word += TurnMoneyToWords(array[i]) + " ";
                }
                else if (i % 3 == 1)
                {

                    if (array[i] == 1)
                    {
                        string value = TurnDigitToTeens(array[i - 1]);

                        if (value != "")
                        {
                            word += value + " " + GetPlaceValue(i-1) + " ";
                            isGreat = false;
                            i--;
                        }

                    }
                    else
                    {
                        string value = TurnDigitToTens(array[i]);

                        if (value != "")
                        {
                            word += value + " ";
                            isGreat = false;
                            value = TurnMoneyToWords(array[i - 1]);

                            word += value != "" ? value + " " : "";
                            word += GetPlaceValue(i -1) + " ";
                            i--;
                        }
                    }
                }
                else if (i % 3 == 2)
                {
                    isGreat = false;
                    string value = TurnMoneyToWords(array[i]);
                    word += value != "" ? value + " Hundred " : "";
                }
                else if (i % 3 == 0)
                {
                    isGreat = false;
                    string value = TurnMoneyToWords(array[i]);
                    word += value != "" ? value + " " : "";
                    word +=  GetPlaceValue(i) + " ";
                }

                counter--;
                if (array.Length > 2)
                {
                    isGreat = true;
                }
            }

            return word.Trim();
            
        }

        private static string GetPlaceValue(int value)
        {
            if (value >= 2)
            {
                if (value % 6 == 1)
                {
                    return "Hundred";
                }
                else if (value % 6 == 3)
                {
                    return "Thousand";
                }
                else if (value % 6 == 0)
                {
                    return "Million";
                }
            }
            return "";
        }

        private static string TurnMoneyToWords(int digit)
        {
            string digitAsString = "";

            if (digit == 1)
            {
                digitAsString += "One";
            }
            else if (digit == 2)
            {
                digitAsString += "Two";
            }
            else if (digit == 3)
            {
                digitAsString += "Three";
            }
            else if (digit == 4)
            {
                digitAsString += "Four";
            }
            else if (digit == 5)
            {
                digitAsString += "Five";
            }
            else if (digit == 6)
            {
                digitAsString += "Six";
            }
            else if (digit == 7)
            {
                digitAsString += "Seven";
            }
            else if (digit == 8)
            {
                digitAsString += "Eight";
            }
            else if (digit == 9)
            {
                digitAsString += "Nine";
            }

            if (digitAsString != "" && isGreat)
            {
                digitAsString = "And " + digitAsString;
            }

            return digitAsString;
        }

        private static string TurnDigitToTens(int digit)
        {
            string digitAsString = "";

            if (digit == 2)
            {
                digitAsString += "Twenty";
            }
            else if (digit == 3)
            {
                digitAsString += "Thirty";
            }
            else if (digit == 4)
            {
                digitAsString += "Forty";
            }
            else if (digit == 5)
            {
                digitAsString += "Fifty";
            }
            else if (digit == 6)
            {
                digitAsString += "Sixty";
            }
            else if (digit == 7)
            {
                digitAsString += "Seventy";
            }
            else if (digit == 8)
            {
                digitAsString += "Eighty";
            }
            else if(digit  == 9)
            {
                digitAsString += "Ninety";
            }

            if (digitAsString != "" && isGreat)
            {
                digitAsString = "And " + digitAsString;
            }

            return digitAsString;
        }


        private static string TurnDigitToTeens(int digit)
        {
            string digitAsString = "";

            if (digit == 0)
            {
                digitAsString = "Ten";
            }
            else if (digit == 1)
            {
                digitAsString = "Eleven";
            }
            else if (digit == 2)
            {
                digitAsString = "Twelve";
            }
            else if (digit == 3)
            {
                digitAsString = "Thirteen";
            }
            else if (digit == 4)
            {
                digitAsString = "Forteen";
            }
            else if (digit == 5)
            {
                digitAsString = "Fifteen";
            }
            else if (digit == 6)
            {
                digitAsString = "Sixteen";
            }
            else if (digit == 7)
            {
                digitAsString = "Seventeen";
            }
            else if (digit == 8)
            {
                digitAsString = "Eighteen";
            }
            else if (digit == 9)
            {
                digitAsString = "Nineteen";
            }

            if (digitAsString != "" && isGreat)
            {
                digitAsString = "And " + digitAsString;
            }

            return digitAsString;
        }
    }
}
