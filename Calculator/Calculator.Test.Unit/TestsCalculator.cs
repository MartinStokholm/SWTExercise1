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

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, 5, ExpectedResult = 5)]
        [TestCase(2.4, 5.2, ExpectedResult = 7.6)]
        [TestCase(-4.2, 5.6, ExpectedResult = 1.4)]
        [TestCase(-3.1, -2.9, ExpectedResult = -6)]
        [DefaultFloatingPointTolerance(0.05)]
        public double AddTwoNumbersTogether(double param1, double param2)
        {
            return uut.Add(param1, param2);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, 5, ExpectedResult = -5)]
        [TestCase(2.4, 5.2, ExpectedResult = -2.8)]
        [TestCase(-4.2, 5.6, ExpectedResult = -9.8)]
        [TestCase(-3.1, -2.9, ExpectedResult = -0.2)]
        [DefaultFloatingPointTolerance(0.05)]
        public double MinusTwoNumberTogether(double param1, double param2)
        {

            return uut.Subtract(param1, param2);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
<<<<<<< Updated upstream
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
=======
        [TestCase(0, 5, ExpectedResult = 0)]
        [TestCase(2.4, 5.2, ExpectedResult = 12.48)]
        [TestCase(-4.2, 5.6, ExpectedResult = -23.52)]
        [TestCase(-3.1, -2.9, ExpectedResult = 8.99)]
        [DefaultFloatingPointTolerance(0.05)]
>>>>>>> Stashed changes
        public double MultiplyTwoNumberTogether(double param1, double param2)
        {
            return uut.Multiply(param1, param2);
        }

        [TestCase(0, 0, ExpectedResult = 1)]
        [TestCase(0, 5, ExpectedResult = 0)]
        [TestCase(2.4, 5.2, ExpectedResult = 94.863349)]
        [TestCase(-4.2, 5.6, ExpectedResult = Double.NaN)]
        [TestCase(-3.1, -2.9, ExpectedResult = Double.NaN)]
        [DefaultFloatingPointTolerance(0.05)]
        public double PowerOfTwoNumberTogether(double param1, double param2)
        {
            return uut.Power(param1, param2);
        }

    }
}