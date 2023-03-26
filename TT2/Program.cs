void NewArray (int[]a)
{
    for (int i = 0; i < a.Length; i++)
        a[i] = new Random().Next(1, 101);
}

int SUMMA (int[] b)
{
    int sum = 0;
        {
            for (int i = 1; i < b.Length; i+= 2)
            sum += b[i];
        }  
    return sum;

}

Console.Clear();
Console.WriteLine("Введите количество элеметов массива: ");
int n = int.Parse(Console.ReadLine()!);
int []q = new int [n];
NewArray(q);
Console.WriteLine($"Стартовый массив: [{string.Join(", ", q)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях: {SUMMA(q)}");

