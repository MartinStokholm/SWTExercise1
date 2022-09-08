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

        [Test]
        public void AccumulatorSuccess() {
            uut.Add(7);
            Assert.That(uut.Accumulator, Is.EqualTo(7));

        }

        [Test]
        public void AddNumberAndClear() {
            uut.Add(5);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void AddNumbers() {
            uut.Add(5);
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void MinusNumber() {

            uut.Subtract(5);
            Assert.That(uut.Accumulator, Is.EqualTo(-5));
        }

        [Test]
        public void MultiplyTwoNumberTogether() {
            uut.Multiply(5);
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void PowerNumber() {
            uut.Power(5);
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        [Test]
        public void DivideNumber() {
            uut.Divide(5);
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        [TestCase(5, 7, ExpectedResult = 12)]
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(-4.5, -5, ExpectedResult = -9.5)]
        [DefaultFloatingPointTolerance(0.05)]
        public double AddTwoNumbersTogether(double param1, double param2) {

            uut.Add(param1);
            return uut.Add(param2);
        }

        [TestCase(-5, 2, ExpectedResult = 3)]
        [TestCase(9.5, 3, ExpectedResult = -12.5)]
        [TestCase(5.5, 5, ExpectedResult = -10.5)]
        [DefaultFloatingPointTolerance(0.05)]
        public double MinusTwoNumberTogether(double param1, double param2)
        {
            uut.Subtract(param1);
            return uut.Subtract(param2);
        }

        [TestCase(-5, 2, ExpectedResult = -10)]
        [TestCase(9.5, 3, ExpectedResult = 28.5)]
        [TestCase(5.5, 0, ExpectedResult = 0)]
        [DefaultFloatingPointTolerance(0.05)]
        public double AddNumberAndMultiplyNumber(double param1, double param2) {
            uut.Add(param1);
            return uut.Multiply(param2);
        }

        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(9.5, 3.6, ExpectedResult = 3309.8245965342797812403250546094)]
        [TestCase(5.5, -4, ExpectedResult = 0.00109282152858411310702820845571)]
        [TestCase(5.5, 0, ExpectedResult = 1)]
        [TestCase(0, 5.5, ExpectedResult = 0)]
        [TestCase(-5.5, 0, ExpectedResult = 1)]
        [TestCase(0, -5.5, ExpectedResult = Double.PositiveInfinity)]
        [DefaultFloatingPointTolerance(0.05)]
        public double AddNumberAndPowerOfNumber(double param1, double param2)
        {
            uut.Add(param1);
            return uut.Power(param2);
        }


        [TestCase(-5, 2, ExpectedResult = -2.5)]
        [TestCase(9.5, 3, ExpectedResult = 3.166666666666667)]
        [TestCase(5.5, 5, ExpectedResult = 1.1)]
        [DefaultFloatingPointTolerance(0.05)]
        public double AddNumberAndDivideNumber(double param1, double param2) {
            uut.Add(param1);
            return uut.Divide(param2);
        }


        [TestCase(5, 3, ExpectedResult = 1.66)]
        [TestCase(-4.5, -5, ExpectedResult = 0.9)]
        [TestCase(-4.5, 0, ExpectedResult = 0)]
        [DefaultFloatingPointTolerance(0.05)]
        public double DivideTwoNumbers(double param, double param2) 
        {
            return uut.Divide(param, param2);
        }

        [Test]
        public void DivideTwoNumberDivideByZeroExeption() 
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(10, 0)); 
        }

        //public void AccumulatorFail()
        //{

        //}


    }
}