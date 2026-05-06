using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Juft son");
        }
        else
        {
            Console.WriteLine("Toq son");
        }
    }
}
