using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite jedan karakter: ");
        char karakter = Console.ReadKey().KeyChar; // Čita karakter sa tastature
        Console.WriteLine($"\nASCII kod unetog karaktera '{karakter}' je: {(int)karakter}");
    }
}
