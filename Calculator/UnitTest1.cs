namespace Calculator
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            if(sum(1, 2) == 3)
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
      
            if (divide(4, 2) == 2)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                throw new Exception("Test Failed");
            }
        }

        int sum(int a, int b)
        {
            return a + b;
        }
        int divide(int a, int b)
        {
            return a * b;
        }
    }
}