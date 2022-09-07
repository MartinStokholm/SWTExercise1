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
        public double AddTwoNumbersTogether(double param1)
        {
            return uut.Add(param1);

        }

        [TestCase(-5, ExpectedResult = 5)]
        [TestCase(9.5, ExpectedResult = -9.5)]
        [TestCase(5.5, ExpectedResult = -5.5)]
        [DefaultFloatingPointTolerance(0.05)]
        public double MinusTwoNumberTogether(double param1)
        {

            return uut.Subtract(param1);
        }

        //[TestCase(0, ExpectedResult = 0)]
        //[TestCase(0, ExpectedResult = 0)]
        //[TestCase(2.4, ExpectedResult = 12.48)]
        //[TestCase(-4.2, ExpectedResult = -23.52)]
        //[TestCase(-3.1, ExpectedResult = 8.99)]
        //[DefaultFloatingPointTolerance(0.05)]

        //public double MultiplyTwoNumberTogether(double param1)
        //{
        //    return uut.Multiply(param1);
        //}

        //[TestCase(0, ExpectedResult = 1)]
        //[TestCase(0, ExpectedResult = 0)]
        //[TestCase(2.4, ExpectedResult = 94.863349)]
        //[TestCase(-4.2, ExpectedResult = Double.NaN)]
        //[TestCase(-3.1, ExpectedResult = Double.NaN)]
        //[DefaultFloatingPointTolerance(0.05)]
        //public double PowerOfTwoNumberTogether(double param1)
        //{
        //    return uut.Power(param1);
        //}

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
        //public void DivideOfTwoNumbers(double param1)
        //{
        //    double TestNumber = uut.Divide(param1);
        //    Assert.That(TestNumber, Is.EqualTo(Math.DivRem(param1)));
        //}

        //public void DivideWithZero(double param1, double param2)
        //{
        //    double TestNumber = uut.Divide(param1, param2);
        //    Assert.That(TestNumber, Is.EqualTo(Math.DivRem(param1, param2)));
        //}

        //public void accumulatorsuccess()
        //{

        //    assert.that();

        //}

        //public void accumulatorfail()
        //{

        //}

        
    }
}