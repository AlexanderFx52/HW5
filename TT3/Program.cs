void NewArray (double[]a)
{
    for (int i = 0; i < a.Length; i++)
        a[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

double MAX (double[] b)
{
    double max = 0;
        for (int i = 0; i < b.Length; i++)
            {
              if(b[i] > max)
              max = b[i];
            }     
        return max; 
}

double MIN (double[] b)
{
    int i = 0;
    double min= b[i];
        while (i < b.Length)
         {
            if(b[i] < min)
            min = b[i];
            i++;
         }
    return min;
        
}



Console.Clear();
Console.WriteLine("Введите количество элеметов массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
double []q = new double [n];
NewArray(q);
Console.WriteLine($"Стартовый массив: [{string.Join(", ", q)}]");
Console.WriteLine($"Элемент массива с максимальным значением: {MAX(q)}");
Console.WriteLine($"Элемент массива с минимальным значением: {MIN(q)}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {MAX(q) - MIN(q)}");
