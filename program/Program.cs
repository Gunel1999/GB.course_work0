﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Ввод массива с клавиатуры
Console.WriteLine("Введите элементы массива через пробел:");
string[] array = Console.ReadLine().Split(' ');

// Функция формирования нового массива
string[] NewArray(string[] inputArray)
{
    // Счетчик элементов массива
    int count = 0;

    // Цикл подсчета элементов массива
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3) count++;
    }

    // Создание нового массива размером count
    string[] resultArray = new string[count];

    // Счетчик для нового массива
    int j = 0;

    // Цикл заполнения нового массива
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            // Заполнение нового массива
            resultArray[j] = inputArray[i];
            j++;
        }
    }
    // Возврат нового массива
    return resultArray;
}

// Вывод массива на экран
void PrintArray(string[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i]);
        if (i < inputArray.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

// Вывод результата
PrintArray(NewArray(array));