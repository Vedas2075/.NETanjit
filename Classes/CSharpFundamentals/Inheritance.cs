namespace Interitance ;
public class BasicCalculator
    {
        public string brand = string.Empty;
        public double Sum(double operand1, double operand2) => operand1 + operand2;
        public double Subtract(double operand1 ,double operand2) => operand1 - operand2;
        public double Multiply(double operand1, double operand2) => operand1 * operand2;
        public double Divide(double operand1, double operand2) => operand1 / operand2;
    }
    public class ScientificCalculator: BasicCalculator
        {
            public double Sin(double angle ) => Math.Sin(angle);
        }