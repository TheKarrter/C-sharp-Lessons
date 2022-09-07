// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");  //string.Join - создает последовательность из элементов массива, которое разделены символом(запятой в нашем случае)
// // Сложность алгоритма O(1) - big-O-notation

// int summa = 0;
// for (int i = 0; i < n; i++)
//     summa += array[i];
// Console.WriteLine(summa);

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i,j] = (i+1) * (j+1);
        matrix[j,i] = (i+1) * (j+1);
        // Console.Write(i*j);
        // Console.Write("\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i,j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
// O(n^2 / 2)