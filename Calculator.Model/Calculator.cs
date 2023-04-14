namespace Calculator.Model
{
    public class Calculator
    {
        public int Add(int v1, int v2)
           => v1+v2;
        public decimal Add(decimal v1, decimal v2)
            => v1+v2;
        public int Sub(int v1, int v2)
            => v1-v2;
        public int Mul(int v1, int v2)
            => v1*v2;
        public decimal Div(int v1, int v2)
            => v1/v2;
    }
}