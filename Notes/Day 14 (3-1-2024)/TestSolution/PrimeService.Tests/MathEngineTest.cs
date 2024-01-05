using Xunit;
using Mathematics;

namespace Testing.UnitTests.Services
{
    public class MathEngineService_Addition
    {
        [Fact]
        public void AdditionTest()
        {
            //input Data
            int op1=3;
            int op2=4;

            //expected Data
            int expectedRestult=7;

            var engine = new MathEngine();
            int actualResult = engine.Addition(op1, op2);
            Console.WriteLine("expected  Value"+ expectedRestult);
            Console.WriteLine("actual Value"+ actualResult);
            int num=0;
            //Assert.Equal(expectedRestult,actualResult,num);
            Assert.Equal(actualResult,expectedRestult);
        }

          
    }
}