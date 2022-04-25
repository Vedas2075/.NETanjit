// Methods m1 = new();
// var s = m1.Sum();
// s = m1.Sum(23.4, 22.411);
// s = m1.Sum(34.21);
// s = m1.Sum(2.3, 4.6, 12.44);

// var x = m1.Greet("Anjit", "Silwal", "Dr. ");
// x = m1.Greet("Anjit", "Silwal");
// Console.WriteLine(x);

// public class Program
// {
//     public static void Main()
//     {
//         Calculator calculator1 = new();
//         calculator1.operand1 = 31.7;
//         calculator1.operand1 = 89.7;
//         var s = calculator1.Sum();
//         var d = calculator1.Subtract();
//         var m = calculator1.Multiply();
//         var di = calculator1.Divide();

//         Calculator calculator2 = new(43.6, 76.3);
//         var s2 = calculator1.Sum();
//         var d2 = calculator1.Subtract();
//         var m2 = calculator1.Multiply();
//         var di2 = calculator1.Divide();





//     }
// }

using ABC;
public class Program
{
    public static void Main()
    {
        BasicCalculator calculator1 = new(34.6, 35.6);
        var y = BasicCalculator.brand;

        var s2 = calculator1.Sum();
        var d2 = calculator1.Subtract();
        var m2 = calculator1.Multiply();
        var di2 = calculator1.Divide();
    }
}
