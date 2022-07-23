void Zadacha25()
{
    Console.WriteLine("Введите число, которое нужно возвести в степень, то есть число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение степени числа A, то есть число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    int result = A;
    while(i < B)
    {
        result = result * A;
        i++;
    }
    Console.WriteLine(result);
}

//Zadacha25();

void Zadacha27()
{
   Console.WriteLine("Введите число: ");
   int number = Convert.ToInt32(Console.ReadLine()); 
   int figure = 0;
   int summ = 0;
   while(number > 0)
   {
        figure = number % 10;
        summ = summ + figure;
        number = number / 10;
   }
    Console.WriteLine(summ);
}
//Zadacha27();

void Zadacha29()
{
    Console.WriteLine("Введите первый элемент массива:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второй элемент массива:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третий элемент массива:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите четвертый элемент массива:");
    int d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите пятый элемент массива:");
    int e = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите шестой элемент массива:");
    int f = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите седьмой элемент массива:");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите восьмой элемент массива:");
    int h = Convert.ToInt32(Console.ReadLine());
    
    int[] array = {a, b, c, d, e, f, j, h};
   
    void PrintArray(int[] arr)
    {
        int count = arr.Length;
        for(int i = 0; i < count; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
    PrintArray(array);
    
    void Selection(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            int Maxposition = i;
            for(int j = i + 1; j < arr.Length; j++)
            {
                if (Math.Abs(arr[j]) > Math.Abs(arr[Maxposition]))
                {
                    Maxposition = j;
                }
            }
        int temp = arr[i];
        arr[i] = arr[Maxposition];
        arr[Maxposition] = temp;
        }
    }
    Selection(array);
    Console.WriteLine();
    PrintArray(array);
}
//Zadacha29();

