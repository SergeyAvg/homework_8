Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[rows, columns];
int[,] second_massive = new int[rows, columns];
int[,] third_array = new int[rows, columns];

fill_massive(massive);
print_massive_two(massive);

Console.WriteLine();

fill_massive(second_massive);
print_massive_two(second_massive);

Console.WriteLine();

if (massive.GetLength(0) != second_massive.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < second_massive.GetLength(1); j++)
    {
        third_array[i, j] = 0;
        for (int k = 0; k < massive.GetLength(1); k++)
        {
            third_array[i, j] += massive[i, k] * second_massive[k, j];
        }
    }
}

print_massive_two(third_array);


void fill_massive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void print_massive_two(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}