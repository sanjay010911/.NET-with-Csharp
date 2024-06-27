/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class GenericDelegate{
    public delegate T AddDelegate<T>(T param1,T param2);
    public static int AddNumber(int val1,int val2)
    {
        return val1+val2;
    }
  
    public static string Concat(string v1,string v2)
    {
        return v1+v2;
    }
    static void Main() {
      AddDelegate<int> sum=AddNumber;
      AddDelegate<string> concat=Concat;
       Console.WriteLine(sum(10,20));
        Console.WriteLine(concat("Suresh","Gopi"));
  } 
  
}