using System;

class Program
{
  static void Main()
  {
    // Запрашиваем у пользователя количество строк
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());

    // Исходный массив строк
    string[] strings = new string[n];

    // Пользователь вводит строки
    for (int i = 0; i < n; i++)
    {
      Console.Write($"Введите строку {i + 1}: ");
      strings[i] = Console.ReadLine();
    }

    // Создаем новый массив для строк, длина которых <= 3
    string[] newStrings = new string[strings.Length];

    // Обходим все строки в исходном массиве
    int j = 0;
    for (int i = 0; i < strings.Length; i++)
    {
      // Если длина строки <= 3, добавляем ее в новый массив
      if (strings[i].Length <= 3)
      {
        newStrings[j] = strings[i];
        j++;
      }
    }

    // Уменьшаем размер нового массива до фактического количества добавленных строк
    Array.Resize(ref newStrings, j);

    // Выводим новый массив
    Console.WriteLine("Новый массив строк:");
    foreach (string s in newStrings)
    {
      Console.WriteLine(s);
    }
  }
}
