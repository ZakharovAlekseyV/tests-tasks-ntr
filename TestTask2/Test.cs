using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTasks;
using Xunit;

namespace TestTask2
{
    public class Test
    {
        [Theory]
        [InlineData(new[] { 3, 5, -1, 1 }, 8)]
        [InlineData(new[] { 5, 3, -6, 7, 12}, 19)]
        [InlineData(new[] { 5, 3, 0, 7, 12}, 27)]
        public void SummCalculatorTest(int [] input, int expected)
        {
            // arrange

            // act
            var result = Calculator.Calculate(input);

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] {1, 4, 4, 4}, 4, 1)]
        [InlineData(new[] {0, 1, 4, 4, 4, 4}, 4, 2)]
        [InlineData(new[] {1, 2, 4, 5, 9, 22}, 7, 4)]
        public void SearcherTests(int [] input, int searched, int expected)
        {
            // arrange

            //act
            var result = IndexSearcher.Search(input, searched);

            // asert
            Assert.Equal(expected, result);
        }
    }
}
