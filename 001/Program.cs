void FindString (string[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length < 3)
            Console.Write($"{matrix[i]}, ");
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк в массиве");
int b = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string [b];
for (int i = 0; i < b; i++)
{
    Console.WriteLine("Введите данные массива");
    matrix[i] = Convert.ToString(Console.ReadLine());
}
Console.Write($"[{string.Join(", ", matrix)}]");
FindString(matrix);