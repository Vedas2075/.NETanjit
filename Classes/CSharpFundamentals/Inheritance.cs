/*namespace Interitance ;
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
        */

        namespace Inheritance;
        public class Converter
            {
                public string fromUnits;
                public string toUnits;
                public double fromUnitValue;
                public double toUnitValue;
               
            }

            public class LengthConverter: Converter
                {
                    public double convert(string fromUnit, string to Unit)
                        {
                            if(fromUnit == "cm" && toUnits == "m")
                                {
                                    return fromUnitValue /100;
                                }

                                else if (fromUnit =="m") && toUnits == "cm")
                                {
                                    
                                }
                        }
                    
                }