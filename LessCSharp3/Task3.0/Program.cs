// цикл for

// for(int i = 0; i < count; i++) // 
// {
//    result = result + text;
//}

// Цикл в цикле
// Вывести таблицу умножения на экран

for (int i = 2; i < 10; i++) // насальное значение; условие; инкремент
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); // для перехода на новую строку
}