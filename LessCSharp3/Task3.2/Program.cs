// Упорядочивание массива
// Метод выбора минимального (максимального)

int[] arr = {1, 3, 9, 5, 8, 2, 1, 3, 6};

void PrintArray(int[] array)  // напишем сначала метод печати массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // напишем метод для сортировки с меньшего к большему
{
    for (int i = 0; i < array.Length; i++) // задаем цикл до конца массива (почти до конца, так как сравниваем левый элемент с правым), здесь сразу используем метод Length
    {
        int minPos = i;  //вводим переменную с индексом минимального элемента
       
        for (int j = i + 1; j < array.Length; j++) // задаем цикл до конца массива с соседним элементом для сравнения (j = i + 1 )
        {
            if(array[j] < array[minPos]) minPos = j; // если элемент j меньше элемента minPos, то присваеваем minPos j.
        }

        int temporary = array [i];  // меняем элементы местами. запоминаем наш элемент
        array[i] = array[minPos]; // записываем в него элемент с минимальным значением
        array[minPos] = temporary;  // а в элемент с мин.знач. записываем запомненный нами элемент

    }
}

PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);
