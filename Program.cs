using System;

namespace AssignmentStatements
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 5;
           int y = 7*8;
           string fName = "Jim";
           string lName = "Smyth";
           string fullName = fName + lName;
           bool bigNumber = false;
           const int MYIDEAOFBIGNUMBER = 100;
         
           x = x + y;
           x = y^3;
   //     x *= 100;
        bigNumber = (x >= MYIDEAOFBIGNUMBER);
        y = 47;
        bigNumber = (y == 47);
        y = 99;
        bigNumber = !bigNumber;
        bigNumber = (y != x);
           x = x + 2;
        y = y % 5;
     lName = lName + y.ToString();
           x += 2;
           x = 4;
           fullName  = $"{fName} {lName} is the best looking person in the world!";
           Console.WriteLine(x);
           Console.WriteLine(y);
           Console.WriteLine(fName);
           Console.WriteLine(lName);
           Console.WriteLine(fullName);
           Console.Write("Value of big number test = ");
           Console.WriteLine(bigNumber);
        }
    }
}
