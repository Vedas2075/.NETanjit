// Language Integrated Query (LiNQ)
// Method Syntaxs
using System.Linq;
using System.collections.Generic;
publiic class Query 
{
        byte[] numbers = {23,34,53,12,45,67,43,67};
        List<Person> people = new()
            {
                new Person { Name = "Ram", Address = "ktm" , Gen = 'm'},
                new Person { Name = "Ram1", Address = "ktm" , Gen = 'm'},
                new Person { Name = "Hari", Address = "ktm" , Gen = 'm'},
                new Person { Name = "Harilaxmi", Address = "cht" , Gen = 'f'},
                new Person { Name = "Laxman", Address = "cht" , Gen = 'm'},


            }
        
        public void Test()
            {
               // List all odd numbers
                var odddNumbers = numbers.Where(number=> number % 2 ! = 0);

                // list all even numbers greater than 50
                var numbersGreaterThan50 = numbers.Where(x => x > 50 && x % 2 == 0);
                numbersGreaterThan50 = from num in numbers 
                                        where num > 50 && num % 2 == 0
                                        select num ;

                // Get swuares of all elements 
                var Squares = numbers. Select (y => y * y );

                // Check if collection has number greater taan 100
                var x = numbers.Any (x => x > 100);
                var y = numbers.All (x => x >100); 
                
                //Skip and take 
                var z = numbers.Skip(5).Take(4);

                // ordering 
                var orderedNumbers = numbers.OrderBy(x => x ). Select (x = > x);
                 // Expression Syntax
                var orderedNumbers1 = from number  in numbers 
                                orderby x 
                                select x;
               // List all males whose name start with letter "h/H"
                var males = people.Where


            // List all persons who lives in kathmandu 


               
                
            }


}