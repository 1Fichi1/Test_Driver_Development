using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;


namespace Test_Driver_Development
{
    [TestClass]
    public class StringCheckTests
    {

        [TestMethod]
        public void CheckShortestWord_IfHaveShortestWord_CorrectReturned()
        {
            // arrange
            string input = "я ТУТТУТУ  и тутту";
            // act
            // assert
            StringAssert.Contains("я", StringCheck.CheckShortestWord(input));
        }

        [TestMethod]
        public void CheckCountWords_IfHaveSomethingWord_CorrectReturned()
        {
            // arrange
            string input = "Друзья пришли ко мне в гости";
            // act
            // assert
            Assert.AreEqual(6, StringCheck.CheckCountWords(input));
        }

        [TestMethod]
        public void CheckCountChars_FindCountCharsInString_CorrectReturned()
        {
            // arrange
            string input = "На улице дождь";
            // act
            // assert
            Assert.AreEqual(14, StringCheck.CheckCountChars(input));
        }

        [TestMethod]
        public void CheckNineChar_FindNineCharInAString_CorrectReturned()
        {
            // arrange
            string input = "Завтра бтдет солнечный день";
            // act
            // assert
            Assert.AreEqual('т', StringCheck.CheckNineChar(input));
        }

        [TestMethod]
        public void CheckCountDigits_CheckCountDigitsInAString_CorrectReturned()
        {
            // arrange
            string input = "В этом году я собрал 1500 яблок";
            // act
            // assert
            Assert.AreEqual(4, StringCheck.CheckCountDigits(input));
        }

        [TestMethod]
        public void CheckMaxDigitsInARow_MaxDigitsInAString_CorrectReturned()
        {
            // arrange
            string input = "Моя зарплата за месяц 202300 рублей!";
            // act
            // assert
            Assert.AreEqual(6, StringCheck.CheckMaxDigitsInARow(input));
        }

        [TestMethod]
        public void CheckCountAMCombinations_CountAMInAString_CorrectReturned()
        {
            // arrange
            string input = "ШК, как же я люблю ШК, ШК";
            // act
            // assert
            Assert.AreEqual(3, StringCheck.CheckCountAMCombinations(input));
        }
    }
}
