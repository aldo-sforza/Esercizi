namespace Calculator.Model
{
    public class Calculator
    {
        public int Add(int v1, int v2)
        {
            return v1+v2;
        }
        public double Add(double v1, double v2) => v2 + v2;
        public double Substract(double v1, double v2) => v2 - v1;

        public double Multiply(double v1, double v2) => v1*v2;

        public double Divide(double v1, double v2) => v1 / v2;
    }
}