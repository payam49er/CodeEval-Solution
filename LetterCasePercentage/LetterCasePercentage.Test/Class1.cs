using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LetterCasePercentage.Test
{
    [TestFixture]
    public class LetterCaseTest
    {
        [Test]
        public void TestThePercentageOfLowerAndUpperCaseLetters()
        {
            LetterPercentage letterPercentage = new LetterPercentage();

            var lowerPercentage = letterPercentage.CalculatePercentage("thisTHIS");
           
            Assert.AreEqual(50, lowerPercentage);
        }
    }
}
