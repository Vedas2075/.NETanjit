
public class collection 
{
    byte[] ages = {23,45,34,34,23,56,76,76};
    //List 
    List <string> names = new();
        
        // stack 
        Stack<decimal> marks = new();
        Queue<short> sales = new();
        Dictionary<string, double>nameMarks = new()
            {
                 ["anjit"] =45,
                 ["anjit1"] = 50,
                 ["anjit2"] = 40
            };
    void Test()
        {
            names.Add("anjit");
            names.Remove("anjit");
            var x = names.Contains("Ram");

            marks.Push(45.67m);
            var y = marks.Pop();
            nameMarks.Add("Ram ,12");
            print<int>(45);


        void Print<V>(V parameter)
        {
            Console.writeline(parameter);
        }
    
       
}
