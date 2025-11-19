using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka : ");
        string input = Console.ReadLine();

        if (!ValidasiAngka(input))
        {
            Console.WriteLine("Input tidak valid! Hanya angka tanpa huruf atau desimal.");
            return;
        }
        
        int number = int.Parse(input);

        int reversed = ReverseAngka(number);

        int difference = Math.Abs(number - reversed);

        Console.WriteLine($"Angka input : {number}");
        Console.WriteLine($"Angka reverse : {reversed}");
        Console.WriteLine($"Selisih : {difference}");
    }

    static bool ValidasiAngka(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c)) return false;
        }
        return true;
    }

    static int ReverseAngka(int num)
    {
        int reversed = 0;

        while (num > 0)
        {
            reversed = reversed * 10 + (num % 10);
            num /= 10;
        }

        return reversed;
    }
}
