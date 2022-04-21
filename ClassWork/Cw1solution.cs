
class  GreatestNumber
{
     byte gNumber(int x1, int x2, int x3)
     {
         byte gNum;
         if (x1>x2)
         {
             if(x1>x2)
             {
                 greatest = x1;
             }
             else
             gNum=x3;
         }
         else 
         {
             if(x2>x3)
            {
             gNum=x2;
            }
            else
            gNum=x3;
         }
         return gNum;  
     }
}
