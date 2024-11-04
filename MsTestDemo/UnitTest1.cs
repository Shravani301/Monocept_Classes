namespace MsTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2,8)]
        [DataRow(3,-1)]
        [DataRow(4,-1)]

        public void DoesCubeOfNumberGiveExpectedResult(int input,int expectedResult)
        {
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeOfEvenNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Violating the DRY principle repetation of code with different input so we are passing input and expected result using DataRow.
        //public void DoesEvenNumberCube_4_Gives_64()
        //{
        //    int input = 4;
        //    int expectedResult = 64;
        //    Calculator calculator = new Calculator();
        //    int actualResult = calculator.CubeOfEvenNumber(input);
        //    Assert.AreEqual(expectedResult,actualResult);
        //}
        //[TestMethod]
        //public void DoesOddNumberCube_3_GivesNegative_1()
        //{
        //    int input = 5;
        //    int expectedResult = -1;
        //    Calculator calculator = new Calculator();
        //    int actualResult = calculator.CubeOfEvenNumber(input);
        //    Assert.AreEqual(expectedResult, actualResult);

        //}
    }
}