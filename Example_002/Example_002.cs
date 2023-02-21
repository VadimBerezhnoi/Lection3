int[, ] matrix = new int[3, 4];

for (int rows = 0; rows < 3; rows++)
{
    for (int columns = 0; columns < 4; columns++)
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine();
}