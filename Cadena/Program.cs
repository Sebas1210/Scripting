using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese una cadena para verificar si es palíndroma:");
        string input = Console.ReadLine();

        bool espalindroma = EsPalindroma(input);

        Console.WriteLine($"La cadena \"{input}\" {(espalindroma ? "es" : "no es")} palíndroma.");
    }

    public static bool EsPalindroma(string input)
    {
        
        string cleanedInput = input.Replace(" ", "").ToLower();

        int length = cleanedInput.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (cleanedInput[i] != cleanedInput[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}