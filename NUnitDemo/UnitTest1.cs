namespace NUnitDemo
{
    public class Tests
    {
        Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestCase(2,8)]
        [TestCase(3,-1)]
        public void DoesCubeOfEvenNumberGiveExpectedResult(int input,int expectedResult)
        {
            int actualResult = _calculator.CubeOfEvenNumber(input);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}