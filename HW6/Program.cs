Main();

void Main()
{
    bool isWorking = true;
    while(isWorking){
        Console.WriteLine("Input task");
        string task = Console.ReadLine();

        switch(task){
            case "exit": isWorking = false; break;
            case "t41": Task41(); break;
            case "t43": Task43(); break;
            default: break;
        }
    }
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Введите {argument}:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}

//вывод массива на экран
void PrintArray(int [] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length -1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void Task41(){
    int number = ReadInt("количество элементов массива");
    int [] array = new int[number];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
         array[i] = ReadInt($"{i} -элемент массива");
    }

    PrintArray(array); 

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше 0");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Task43(){
    int b1 = ReadInt("b1");
    int k1 = ReadInt("k1");
    int b2 = ReadInt("b2");
    int k2 = ReadInt("k2");

    double x = 0;
    double y = 0;

    x = (double)(b1 - b2) / (k2 - k1);
    y = (double) k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых = ({x}; {y})");
}