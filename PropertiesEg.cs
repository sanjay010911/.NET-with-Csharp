/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Book
{
    
    private int id;
    public int Id
    {
        get{
            return id;
        }
        set{
            if(value<0)
                throw new Exception("Id should not be negative");
            else
                id=value;
        }
    }
    private string name;
    public string Name
    {
        get{
            return name;
        }
        set{
            name=value;
        }
    }
}
class PropertiesEg {
  static void Main() {
      try{
        Book b=new Book();
            b.Id=9;
            b.Name="sanjay";
        Console.WriteLine(b.Id);
        Console.WriteLine(b.Name);
      }catch(Exception e)
      {
          Console.WriteLine(e);
      }
    
  }
}