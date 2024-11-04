namespace XUnitTestDemo
{
    public class UnitTest1
    {
        Calculator _calculator;
        public UnitTest1()
        {
            _calculator = new Calculator();
        }
        //[Fact]
        //with fact work only for one input 
        //public void DoesCubeOfEvenNumber_2_Gives_8()
        //{
        //    int input = 2;
        //    int expectedResult = 8;
        //    int actualResult = _calculator.CubeOfEvenNumber(input);
        //    Assert.Equal(expectedResult, actualResult);

        //}

        [Theory]
        [InlineData(2, 8)]
        [InlineData(3, 8)]
        public void DoesCubeOfEvenNumberGiveExpectedResult(int number, int expectedResult)
        {
            int actualResult=_calculator.CubeOfEvenNumber(number);
            Assert.Equal(expectedResult, actualResult);
        }
        
    }
}