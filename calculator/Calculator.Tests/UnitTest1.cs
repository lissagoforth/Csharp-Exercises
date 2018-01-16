using System;
using Xunit;

namespace calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int res = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(83, res);
        }
        [Fact]
        public void SubtractTwoIntegers()
        {
            // Given this input to the method
            int res = _calculator.Subtract(35, 15);

            // We are asserting that the output should be this
            Assert.Equal(20, res);
        }
        [Fact]
        public void MultiplyTwoIntegers()
        {
            // Given this input to the method
            int res = _calculator.Multiply(6, 5);

            // We are asserting that the output should be this
            Assert.Equal(30, res);
        }
        [Fact]
        public void DivideTwoIntegers()
        {
            // Given this input to the method
            int res = _calculator.Divide(45, 5);

            // We are asserting that the output should be this
            Assert.Equal(9, res);
        }
    }
}