using System;

class Program
{
    static void Main(string[] args)
    {
        string digiName = "DiiigggiiiOuuuttttsssssouuuurcceee";
        string newDigiName = RemoveDuplicates(digiName);
        Console.WriteLine(newDigiName);
    }

    static string RemoveDuplicates(string str)
    {
        string result = string.Empty;
        char previousChar = '\0'; // initialize to null character
        foreach (char c in str)
        {
            if (c != previousChar)
            {
                result += c;
                previousChar = c;
            }
        }
        return result;
    }
}
