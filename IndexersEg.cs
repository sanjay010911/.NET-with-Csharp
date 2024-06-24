/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Book
{
    
    int g;
    string s;
    public int this[int i]
    {
        get{
            return g;
        }
        set{
            g=value;
        }
        
    }
     public string this[string a]
    {
        get{
            return s;
        }
        set{
            s=value;
        }
        
    }
}
class IndexersEg {
  static void Main() {
      Book b=new Book();
        b[9]=1234;
        b["name"]="sanjay";
    Console.WriteLine(b[0]);
    Console.WriteLine(b["name"]);
    
  }
}