string[] input = new string[6] { "supercontra", "cHo", "0.2f", "4.4", "VanillaIce", "=)" };
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
Print(input);

