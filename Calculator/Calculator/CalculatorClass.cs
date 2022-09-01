namespace Calculator
{
    public class CalculatorClass
    {
    
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        { return a - b; }

        public double Multiply(double a, double b)
        {
            return b * a;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Devide(double a, double b)
        {
            return a / b;
        }
    }
}