using lab1;

Matrix matrix = new Matrix(new int[][]
{
new int[] { 2, 5, 3, 7, 8 },
new int[] { 1, 3, 4, 6, 1 },
new int[] { 0, 0, 6, 15, 0 }
});

SortMatrix sorter = new SortMatrix();

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("Установите способ сортировки:");
    Console.WriteLine("1 – По сумме элементов строк матрицы");
    Console.WriteLine("2 – По максимальному элементу в строке матрицы");
    Console.WriteLine("3 – По минимальному элементу в строке матрицы");
    Console.WriteLine("0 - Выход из программы");
    Console.WriteLine("");
    switch (char.ToLower(Console.ReadKey(true).KeyChar))
    {
        case '1':
            Console.WriteLine("По сумме элементов строк матрицы");
            sorter.SortingMatrix(matrix, SortingOrder(), new SortBySum()); ; break;
        case '2': 
            Console.WriteLine("По максимальному элементу в строке матрицы");
            sorter.SortingMatrix(matrix, SortingOrder(), new SortByMaxElement()); ; break;
        case '3':
            Console.WriteLine("По минимальному элементу в строке матрицы");
            sorter.SortingMatrix(matrix, SortingOrder(), new SortByMinElement()); ; break;
        case '0': return;
        default: break;
    }
    for (int i = 0; i < matrix.Rows; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write(matrix[i][j].ToString() + " ");
        }
        Console.WriteLine();
    }
}


bool SortingOrder()
{
    while (true)
    {
        Console.WriteLine("");
        Console.WriteLine("1 – В порядке возрастания");
        Console.WriteLine("2 – В порядке убывания");
        Console.WriteLine("");

        switch (char.ToLower(Console.ReadKey(true).KeyChar))
        {
            case '1':
                Console.WriteLine("В порядке возрастания"); 
                return true;
            case '2':
                Console.WriteLine("В порядке убывания");
                return false;
            default: break;
        }
    }
}
