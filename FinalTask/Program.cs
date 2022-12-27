
string[] arr = { "2", "werty", "2345", ";-)", "2a", "A-2", "-16"};

PrintArray(arr);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            if (i == array.Length - 1)
            {
                Console.Write($"'{array[i]}'");
            }
            else
            {
                Console.Write($"'{array[i]}', ");
            }
        }
    }
    Console.Write("]");
    Console.WriteLine();
}