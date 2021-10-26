using System;

int [] array = {1, 12, 31, 18, 4, 15, 16, 17, 18};

int n = array.Length;  // кол-во элементов массива
int find = 18;  // загадываем искомое число

int index = 0; // установливаем индекс

while (index < n)   // Цикл пока индекс меньше n
{
    if (array[index] == find)   // условие индекс элемента равен искомому
    {
        Console.WriteLine(index);
        break;     // если условие выполняется
    }
    index++;
}
