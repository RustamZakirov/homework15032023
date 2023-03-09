int FindNewMatrixLength(string[] matrix, int c)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= 3)
            c++;
    }
    return c;
}

void InputNewMatrix(string[] matrix, string[] newmatrix)
{
    int v = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= 3)
        {
            newmatrix[v] = matrix[i];
            v++;
        }
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
int c = 0;
string[] newmatrix = new string [FindNewMatrixLength(matrix, c)];
InputNewMatrix(matrix, newmatrix);
Console.Write($"[{string.Join(", ", matrix)}] -> "); Console.Write($"[{string.Join(", ", newmatrix)}]");