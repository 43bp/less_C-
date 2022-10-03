﻿// 
// void - это метод, который ничего не возвращает, здесь не будет return
// создаем два метода:
// 1. Наполняет любой массив рандомными числами от 1 до 10
// 2. Выводит наполненный массив в консоль

void FillArray(int[] collection)  // создаем новый метод и называем его FillArray для массива
{
    int length = collection.Length;  // определяем длину массива
    int index = 0;  // устанавливаем счетчик
    while (index < length) // пока счетчик меньше длины массива
    {
        collection[index] = new Random().Next(1,10); // кладем в массив в текущий индекс рандомное число от 1 до 10 (1 - не включительно)
        index++;
    }
}

void PrintArray(int [] col)  // создаем новый метод и называем его PrintArray для массива (называем массив как хотим, но лучше, чтоб названия не повторялись с другими методами)
{
    int count = col.Length; // обратите внимание, что переменные называем ПО НОВОМУ!!!
    int position = 0;
    while (position < count) // пока счетчик меньше длины массива
    {
        Console.WriteLine(col[position]); // выводим элемент с текущим индексом
        position++;
    }
}

int IndexOf(int [] coll, int find) // создаем новый метод для массива и переменной
{
    int count1 = coll.Length;
    int index1 = 0;
    int position1 = -1; // если введем элемент для поиска, которого нет в массиве, то будет не 0, а -1, чтобы понимать когда элемент не найден.

    while (index1 < count1)
    {
        if(coll[index1] == find)
        {
            position1 = index1;
            break; // чтоб не искать дальше!!!
        }
        index1++;
    }
    return position1;
}
int[] array = new int[10]; // создаем массив с 10-ю элементами (по умолчанию он наполнен нулями)

FillArray(array);  // вызываем метод наполнения массива рандомными числами
PrintArray(array);  // вызываем метод печати полученного массива
Console.WriteLine(); // чтобы отделить ответ от выведенного массива строкой

int res = IndexOf(array, 444); // вызываем метод поиска индекса элемента "4" в созданном нами массиве (45 строка)
Console.WriteLine(res);