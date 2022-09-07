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
        [Test]
        public void AccumulatorCleared()
        {
            uut.Clear();
            Assert.Zero(uut.Accumulator);
        }

       
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-4.5, ExpectedResult = -4.5)]
        [DefaultFloatingPointTolerance(0.05)]
        public double AddTwoNumbersTogether(double param)
        {
            return uut.Add(param);

        }

        [TestCase(-5, ExpectedResult = 5)]
        [TestCase(9.5, ExpectedResult = -9.5)]
        [TestCase(5.5, ExpectedResult = -5.5)]
        [DefaultFloatingPointTolerance(0.05)]
        public double MinusTwoNumberTogether(double param)
        {

            return uut.Subtract(param);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(2.4, ExpectedResult = 0)]
        [TestCase(-4.2, ExpectedResult = 0)]
        [DefaultFloatingPointTolerance(0.05)]
        public double MultiplyTwoNumberTogether(double param) {
            return uut.Multiply(param);
        }

        [TestCase(0, ExpectedResult = 1)]
        [TestCase(2.4, ExpectedResult = 0)]
        [TestCase(-4.2, ExpectedResult = Double.PositiveInfinity)]
        [TestCase(-3.1, ExpectedResult = Double.PositiveInfinity)]
        [DefaultFloatingPointTolerance(0.05)]
        public double PowerOfTwoNumberTogether(double param) {
            return uut.Power(param);
        }

        //[TestCase(0, 0)]
        //[TestCase(0, 5)]
        //[TestCase(5, 0)]
        //[TestCase(2, 5)]
        //[TestCase(3, -1)]
        //[TestCase(-4, 5)]
        //[TestCase(-3, -2)]
        //[TestCase(2.4, 5.2)]
        //[TestCase(3.3, -1.2)]
        //[TestCase(-4.2, 5.6)]
        //[TestCase(-3.1, -2.9)]
        //public void DivideOfTwoNumbers(double param)
        //{
        //    double TestNumber = uut.Divide(param);
        //    Assert.That(TestNumber, Is.EqualTo(Math.DivRem(param)));
        //}

        //public void DivideWithZero(double param, double param2)
        //{
        //    double TestNumber = uut.Divide(param, param2);
        //    Assert.That(TestNumber, Is.EqualTo(Math.DivRem(param, param2)));
        //}

        //public void Accumulatorsuccess()
        //{

        //    assert.that();

        //}

        //public void accumulatorfail()
        //{

        //}


    }
}