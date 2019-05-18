using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiamondKata
{
    public class DiamondKataTest
    {
        [Fact]
        public void LetterA()
        {
            string actual = DiamondKataCreator.GetShape("A");
            string expected = "A\n";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LetterB()
        {
            string actual = DiamondKataCreator.GetShape("B");
            string expected = " A \nB B\n A \n";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LetterC()
        {
            string actual = DiamondKataCreator.GetShape("C");
            string expected = "  A  \n B B \nC   C\n" +
                              " B B \n  A  \n";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LetterD()
        {
            string actual = DiamondKataCreator.GetShape("D");
            string expected = "   A   \n  B B  \n C   C \nD     D\n" +
                              " C   C \n  B B  \n   A   \n";

            Assert.Equal(expected, actual);
        }


    }
}
