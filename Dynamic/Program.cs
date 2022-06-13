//   dynamic d= "Akshay";
//  Console.WriteLine(d);
//    d= 38;
//   Console.WriteLine(d);
//    d = 44.95;
//    System.Console.WriteLine(d);
//   d = true;
//    System.Console.WriteLine(d);
using System;

class GFG
{
    public static void add(dynamic s1, dynamic s2)
    {
        Console.WriteLine(s1 + s2);
    }
    static public void Main()
    {

        add("hello", "world");
        add("hii", 2.0);
        add(2, 8);
    }
}
