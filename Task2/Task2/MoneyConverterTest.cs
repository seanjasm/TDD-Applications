using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task2
{
    public class MoneyConverterTest
    {
        [Fact]
        public void Number1()
        {
            string actual = MoneyConverter.GetMoneyWord(1);
            string expected = "One";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number2()
        {
            string actual = MoneyConverter.GetMoneyWord(2);
            string expected = "Two";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number3()
        {
            string actual = MoneyConverter.GetMoneyWord(3);
            string expected = "Three";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number4()
        {
            string actual = MoneyConverter.GetMoneyWord(4);
            string expected = "Four";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number5()
        {
            string actual = MoneyConverter.GetMoneyWord(5);
            string expected = "Five";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number6()
        {
            string actual = MoneyConverter.GetMoneyWord(6);
            string expected = "Six";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number7()
        {
            string actual = MoneyConverter.GetMoneyWord(7);
            string expected = "Seven";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number8()
        {
            string actual = MoneyConverter.GetMoneyWord(8);
            string expected = "Eight";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number9()
        {
            string actual = MoneyConverter.GetMoneyWord(9);
            string expected = "Nine";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number0()
        {
            string actual = MoneyConverter.GetMoneyWord(0);
            string expected = "";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number11()
        {
            string actual = MoneyConverter.GetMoneyWord(11);
            string expected = "Eleven";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number12()
        {
            string actual = MoneyConverter.GetMoneyWord(12);
            string expected = "Twelve";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number13()
        {
            string actual = MoneyConverter.GetMoneyWord(13);
            string expected = "Thirteen";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number14()
        {
            string actual = MoneyConverter.GetMoneyWord(14);
            string expected = "Forteen";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number15()
        {
            string actual = MoneyConverter.GetMoneyWord(15);
            string expected = "Fifteen";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number16()
        {
            string actual = MoneyConverter.GetMoneyWord(16);
            string expected = "Sixteen";

            Assert.Equal(expected, actual);
        }
       
        [Fact]
        public void Number17()
        {
            string actual = MoneyConverter.GetMoneyWord(17);
            string expected = "Seventeen";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number18()
        {
            string actual = MoneyConverter.GetMoneyWord(18);
            string expected = "Eighteen";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number19()
        {
            string actual = MoneyConverter.GetMoneyWord(19);
            string expected = "Nineteen";
            Assert.Equal(expected, actual);
        }
        public void Number20()
        {
            string actual = MoneyConverter.GetMoneyWord(20);
            string expected = "Twenty";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number30()
        {
            string actual = MoneyConverter.GetMoneyWord(30);
            string expected = "Thirty";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number40()
        {
            string actual = MoneyConverter.GetMoneyWord(40);
            string expected = "Forty";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number50()
        {
            string actual = MoneyConverter.GetMoneyWord(50);
            string expected = "Fifty";
     
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number60()
        {
            string actual = MoneyConverter.GetMoneyWord(60);
            string expected = "Sixty";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number70()
        {
            string actual = MoneyConverter.GetMoneyWord(70);
            string expected = "Seventy";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number80()
        {
            string actual = MoneyConverter.GetMoneyWord(80);
            string expected = "Eighty";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Number90()
        {
            string actual = MoneyConverter.GetMoneyWord(90);
            string expected = "Ninety";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number100()
        {
            string actual = MoneyConverter.GetMoneyWord(100);
            string expected = "One Hundred";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number200()
        {
            string actual = MoneyConverter.GetMoneyWord(200);
            string expected = "Two Hundred";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Number300()
        {
            string actual = MoneyConverter.GetMoneyWord(300);
            string expected = "Three Hundred";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number301()
        {
            string actual = MoneyConverter.GetMoneyWord(301);
            string expected = "Three Hundred And One";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number309()
        {
            string actual = MoneyConverter.GetMoneyWord(309);
            string expected = "Three Hundred And Nine";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number310()
        {
            string actual = MoneyConverter.GetMoneyWord(310);
            string expected = "Three Hundred And Ten";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number345()
        {
            string actual = MoneyConverter.GetMoneyWord(345);
            string expected = "Three Hundred And Forty Five";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number999()
        {
            string actual = MoneyConverter.GetMoneyWord(999);
            string expected = "Nine Hundred And Ninety Nine";

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void number1000()
        {
            string actual = MoneyConverter.GetMoneyWord(1000);
            string expected = "One Thousand";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number1555()
        {
            string actual = MoneyConverter.GetMoneyWord(1555);
            string expected = "One Thousand Five Hundred And Fifty Five";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number10555()
        {
            string actual = MoneyConverter.GetMoneyWord(10555);
            string expected = "Ten Thousand Five Hundred And Fifty Five";

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void number10005()
        {
            string actual = MoneyConverter.GetMoneyWord(10005);
            string expected = "Ten Thousand And Five";

            Assert.Equal(expected, actual);
        }
        

        [Fact]
        public void number100000()
        {
            string actual = MoneyConverter.GetMoneyWord(100000);
            string expected = "One Hundred Thousand";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number199544()
        {
            string actual = MoneyConverter.GetMoneyWord(199544);
            string expected = "One Hundred And Ninety Nine Thousand Five Hundred And Forty Four";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number0000001()
        {
            string actual = MoneyConverter.GetMoneyWord(0000001);
            string expected = "One";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void number945000()
        {
            string actual = MoneyConverter.GetMoneyWord(945000);
            string expected = "Nine Hundred And Forty Five Thousand";

            Assert.Equal(expected, actual);
        }
    }
}
