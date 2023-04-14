namespace Calculator.Model
{
    public class Calculator
    {
        public int Add(int v1, int v2)
        {
            return v1+v2;
        }

        public double AddDouble(double d1, double d2)
            => d1 + d2;

        public double Subtract(int s1, int s2)
            => s1 - s2;
    }
}