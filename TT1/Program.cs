void NewArray (int[]a)
{
    for (int i = 0; i < a.Length; i++)
        a[i] = new Random().Next(100, 1000);
}

int POISK (int[] b)
{
    int sum = 0;
        for (int i = 0; i < b.Length; i++)
        { if(b[i]%2 == 0)
            sum += 1;
        }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите количество элеметов массива: ");
int n = int.Parse(Console.ReadLine()!);
int []q = new int [n];
NewArray(q);
Console.WriteLine($"Стартовый массив: [{string.Join(", ", q)}]");
Console.WriteLine($"Количество чётных элементов массива: {POISK(q)}");



 