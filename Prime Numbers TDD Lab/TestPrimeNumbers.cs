using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Prime_Numbers_TDD_Lab
{
    public class TestPrimeNumbers
    {
        [Fact]
        public void TestIndexes()
        {
            //arrange
            PrimeNumbers pn = new PrimeNumbers();
            int expected = 3;

            //act
            int actual = pn.GetPrime(1);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0,2)]
        [InlineData(2,5)]
        [InlineData(7,19)]
        [InlineData(10,31)]
        [InlineData(12,39)]
        public void TestAll(int input, int expected)
        {
            //arrange
            PrimeNumbers pn = new PrimeNumbers();

            //act
            int actual = pn.GetPrime(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
