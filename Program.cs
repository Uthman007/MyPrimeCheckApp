using System;

namespace MyPrimeCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
         // printing out welcome message
         Console.WriteLine("Hello, you are welcome to prime number checker App"); 

         // variable declaration
         int n, i, m=0, flag=0; 

          // printing a message to get user's preffered number
          Console.Write("Enter the Number to check: ");  

         // assigning user's input to an int variable n and converting user's input to an integer 
         //n = int.Parse(Console.ReadLine()); 
         n = Convert.ToInt32(Console.ReadLine());

         // dividing user's input by 2 and then storing it in int variable m
         m=n/2; 

         for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0)    
            {    
             Console.Write(n + " " + "is not a Prime number.");    
             flag=1;    
             break; 
                
            }    
          } 
          if (flag==0)    
           Console.Write(n + " " + "is Prime number.");

           /*int n = Convert.ToInt32(Console.ReadLine()); 
           int a = 0;
         for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine("{0} is a Prime Number", n);
         } else {
            Console.WriteLine("Not a Prime Number");
         }*/
         
        }
    }
}
