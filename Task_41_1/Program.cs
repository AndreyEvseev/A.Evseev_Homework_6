// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// Ввод чисел в строку с разделением пробелом

int NumDigit(string[] mass) // подсчет количества не пустых элементов массива
{
    int num = mass.Length;
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        if(mass[i] == "") count++;
    }
    num = num - count;
    return num;
}

int[] stringToDigit(string[] mass) // перевод элементов текстового массива 
// в числа с удалением пустых элементов
{
    int dim = NumDigit(mass);
    int[] masd = new int[dim];
    int j = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if(mass[i] != "") 
        {
            masd[j] = Convert.ToInt32(mass[i]);
            j++;
        }
    }
    return masd;
}

void PrintArrStr(string[] mas) // печать текстового массива
{
    Console.Write("Текстовый массив: {");
    for (int i = 0; i < mas.Length; i++)
    {
        if(i == mas.Length -1) Console.Write(mas[i]);
        else Console.Write(mas[i] + "; ");
    }
    Console.WriteLine("}");
}

void PrintArrDigit(int[] mas) // печать числового массива
{
    Console.Write("Числовой массив: {");
    for (int i = 0; i < mas.Length; i++)
    {
        if(i == mas.Length -1) Console.Write(mas[i]);
        else Console.Write(mas[i] + "; ");
    }
    Console.WriteLine("}");
}

void PositiveNum(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] > 0) result++;
    }
    Console.WriteLine("Пользователь ввел " + result + " чисел больше 0.");
}

Console.WriteLine("Введите целые числа, разделённые пробелом: ");
string str = Console.ReadLine();
string[] arrStr = str.Split(' '); // перевод строки в текстовый массив
PrintArrStr(arrStr); // визуальная проверка текстового массива
int M = NumDigit(arrStr);
int[] arr = new int[M];
arr = stringToDigit(arrStr);
PrintArrDigit(arr); // визуальная проверка цифрового массива
PositiveNum(arr);


