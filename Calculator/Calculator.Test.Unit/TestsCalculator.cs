using Calculator;

namespace Calculator.Test.Unit
{
    public class TestsCalculator
    {
        private CalculatorClass uut;

        [SetUp]
        public void Setup()
        {
            uut = new CalculatorClass();
        }

        [TestCase(0, 0)]

        [TestCase(2, 5)]
        [TestCase(3, -1)]
        [TestCase(-4, 5)]
        [TestCase(-3, -2)]
        [TestCase(2.4, 5.2)]
        [TestCase(3.3, -1.2)]
        [TestCase(-4.2, 5.6)]
        [TestCase(-3.1, -2.9)]
        public void AddTwoNumbersTogether(double param1, double param2)
        {
            double TestNumber = uut.Add(param1, param2);
            Assert.That(TestNumber, Is.EqualTo(param1 + param2));
        }

        [TestCase(0, 0)]
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(2, 5)]
        [TestCase(3, -1)]
        [TestCase(-4, 5)]
        [TestCase(-3, -2)]
        [TestCase(2.4, 5.2)]
        [TestCase(3.3, -1.2)]
        [TestCase(-4.2, 5.6)]
        [TestCase(-3.1, -2.9)]
        public void MinusTwoNumberTogether(double param1, double param2)
        {

            double TestNumber = uut.Subtract(param1, param2);
            Assert.That(TestNumber, Is.EqualTo(param1 - param2));
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, 5, ExpectedResult = 0)]
        [TestCase(2.4, 5.2, ExpectedResult = 13.2)]
        //[TestCase(3.3, -1.2)]
        //[TestCase(-4.2, 5.6)]
        //[TestCase(-3.1, -2.9)]
        public double MultiplyTwoNumberTogether(double param1, double param2)
        {
            return uut.Multiply(param1, param2);
            //double TestNumber = uut.Multiply(param1, param2);
            //Assert.That(TestNumber, Is.EqualTo(param1 * param2));
        }

        [TestCase(0, 0)]
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(2, 5)]
        [TestCase(3, -1)]
        [TestCase(-4, 5)]
        [TestCase(-3, -2)]
        [TestCase(2.4, 5.2)]
        [TestCase(3.3, -1.2)]
        [TestCase(-4.2, 5.6)]
        [TestCase(-3.1, -2.9)]
        public void PowerOfTwoNumberTogether(double param1, double param2)
        {
            double TestNumber = uut.Power(param1, param2);
            Assert.That(TestNumber, Is.EqualTo(Math.Pow(param1, param2)));
        }
    }
}