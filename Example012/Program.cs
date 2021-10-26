using System;

void FillArray(int[] collection)  // Заполнение массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);    // Генерация случайного числа
        index++;
    } 
}

void PrintArray(int[] box)   // Печать массива
{
    int count = box.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(box[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;  // если элемента нет в массиве то ставить = -1 (элемент не найден)
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // определили массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
