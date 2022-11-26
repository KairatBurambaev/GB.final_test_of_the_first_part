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
string[] Filter(string[] input)
{
    string[] result = new string[input.Length];
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            result[count] = input[i];
            count += 1;
        }
    }
    return result;
}
string[] filtered = Filter(input);
Print(filtered);
