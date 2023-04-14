namespace Calculator.Model
{
    public class Calculator
    {
        public int Add(int v1, int v2)
           => v1+v2;
        public double Add(double v1, double v2)
            => v1+v2;
        public int Sub(int v1, int v2)
            => v1-v2;
        public int Multiply(int v1, int v2)
            => v1*v2;
        public double Div(int v1, int v2)
            => v1/v2;
    }
}