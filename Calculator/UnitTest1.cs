using Domain;

namespace CalculatorTest
{
    public class UnitTest1
    {
      
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();
            if (calculator.sum(1, 2) == 3)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                throw new Exception("Test Failed");
            }
        
        }
        [Fact]
        public void Test2()
        {
            // Hatalý test denemesi

      var calculator = new Calculator();
            if (calculator.divide(4, 2) == 2)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                throw new Exception("Test Failed");
            }
        }

    
    }
}