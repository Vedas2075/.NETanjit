public class Exeptionhandling
{
    public double compute (double x, double y, double z)
    {
        double c = 0 ;
        try
        {
            double value = (x + y)/z;
             c = value * x / (y + z);
            
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally 
        {
            if (char == 0)
                c = 20;

        }
        return c;
    
    }
    public void Test()
    {
        var v = compute (23,45,0);
    }
}