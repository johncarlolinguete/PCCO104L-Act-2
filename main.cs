using System;

class Program
{
    static void Main(string[] args)
    {
        FooBar(30);
    }

    static void FooBar(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FooBar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
