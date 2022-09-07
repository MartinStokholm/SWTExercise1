namespace Calculator
{
    public class CalculatorClass
    {
    
        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
        public double Add(double addend)
        {
            return Accumulator += addend; 
        }

        public double Subtract(double subtractor)
        {
            return Accumulator -= subtractor;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }

        public double Power(double exp)
        {
            return Accumulator = Math.Pow(Accumulator, exp);
        }

        public double Divide( double divisor)
        {
            if (divisor == 0) return 0;
            return Accumulator /= divisor;
        }

        public double Divide(double dividend, double divisor) {
            if (divisor == 0) return 0;
            return dividend /= divisor;
        }
    }
}