Console.WriteLine("Введите значение m таблицы: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение n таблицы: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {        
            array[i,j] = new Random().Next(0,100);      
            Console.Write(array[i,j] + ", ");
    }
    Console.WriteLine();
}