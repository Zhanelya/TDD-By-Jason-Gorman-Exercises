using System;
using Xunit;
using PrimeNumbers;
using System.Collections.Generic;

namespace PrimeNumbers.Tests
{
    [Trait("Prime Numbers", "Prime Numbers Generator Generates Correct Sequence")]
    public class PrimeNumbersGeneratorTests
    {
        private PrimeNumbersGenerator _primeNumbersGenerator = new PrimeNumbersGenerator();
        private List<int> _primeNumbers = new List<int>();

        public PrimeNumbersGeneratorTests()
        {
            _primeNumbers = _primeNumbersGenerator.GetNumbers(1000);
        }
        [Theory(DisplayName = "First Two Numbers Are Index Plus Two")]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        public void FirstTwoNumbersAreIndexPlusTwo(int index, int expected)
        {
            Assert.Equal(expected, _primeNumbers[index]);
        }

        [Fact(DisplayName = "Third Number In Sequence Is Five")]
        public void ThirdNumberInSequenceIsFive()
        {
            Assert.Equal(5, _primeNumbers[2]);
        }

        [Fact(DisplayName = "Fourth Number In Sequence Is Seven")]
        public void FourthNumberInSequenceIsSeven()
        {
            Assert.Equal(7, _primeNumbers[3]);
        }

        [Fact(DisplayName = "Fifth Number In Sequence Is Eleven")]
        public void FifthNumberInSequenceIsEleven()
        {
            Assert.Equal(11, _primeNumbers[4]);
        }

        [Fact(DisplayName = "Sixth Number In Sequence Is Thirteen")]
        public void SixthNumberInSequenceIsThirteen()
        {
            Assert.Equal(13, _primeNumbers[5]);
        }

        [Fact(DisplayName = "Seventh Number In Sequence Is Seventeenth")]
        public void SeventhNumberInSequenceIsSeventeen()
        {
            Assert.Equal(17, _primeNumbers[6]);
        }

        [Fact(DisplayName = "Eighth Number In Sequence Is Nineteen")]
        public void EighthNumberInSequenceIsNineteen()
        {
            Assert.Equal(19, _primeNumbers[7]);
        }

        [Fact(DisplayName = "Last Number In Sequence Is 997")]
        public void LastNumberInSequenceIs997()
        {
            Assert.Equal(997, _primeNumbers[_primeNumbers.Count-1]);
        }

        [Fact(DisplayName = "Generatinga Sequence With Upper Bound 2 Throws Exception")]
        public void GeneratingASequenceWithUpperBound2ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _primeNumbersGenerator.GetNumbers(2));
        }
    }
}
