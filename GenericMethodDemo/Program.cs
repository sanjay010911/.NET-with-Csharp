using System;
namespace GenericMethodDemo
{
    public class Program
    {
        static void Swap<T>(T t1, T t2)
        {
            T temp;
            Console.WriteLine("Before swapping t1 :" + t1 + " t2 :" + t2);
            temp = t1;
            t1 = t2;
            t2 = temp;
            Console.WriteLine("After swapping t1 :" + t1 + " t2 :" + t2);
        }
        static void Main(string[] args)
        {
            Swap<int>(56, 32);
            Swap<string>("abc", "def");
        }
    }
}
