using System;
namespace EvenOdd
{
    class Even_Or_odd
    {
        static void main(String[] args){
            int i;
            Console.Write("Enter a Number : ");
            i=int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.Write("Entered number is an even number");
                Console.Read();

            }
            else
                Console.Write("Odd Number");
        }
    }
}