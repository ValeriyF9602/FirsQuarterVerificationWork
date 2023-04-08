/*****************************************************************************************************************************

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

*****************************************************************************************************************************/


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] GenerateStringArray(int length) // Метод генерации массива
{
    string[] array = new string[length];
    return array;
}

void FillStringArray(string[] array) // Метод ручного ввод элементов массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
}

int LessThanFourCount(string[] array) // Метод определения размера нового массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
        if (array[i].Length < 4) count++;
    return count;
}

void FillLessThanFourElements(string[] origArr, string[] newArr) // Метод заполнения нового массива строками, длина которых <= 3 символам
{
    int count = 0;
    for (int i = 0; i < origArr.Length; i++)
    {
        if (origArr[i].Length < 4)
        {
            newArr[count] = origArr[i];
            count++;
        }
    }
}

void PrintStringArray(string[] array) // Метод вывода массива в консоль
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


string[] originalArray = GenerateStringArray(
    ReadInt("Укажите размер массива: "));
FillStringArray(originalArray);

string[] newArray = GenerateStringArray(
    LessThanFourCount(originalArray));
FillLessThanFourElements(originalArray, newArray);

PrintStringArray(newArray);