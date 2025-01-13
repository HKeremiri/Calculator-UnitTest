
using FluentAssertions;
using Domain;

namespace CalculatorTest
{
    public class CalculatorTests
    {
      
        [Fact]
        public void Sum_2_and_2_shouldbe_4()        
       => new Calculator()
                .Sum(2, 2)
                .Should().Be(4);

       

      

    }
}