/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3
символа.Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.При решении
не рекомендуется пользоваться коллекциями, лучше обоитись исключительно массивами. */

string[] Length(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arr = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[index] = array[i];
            index++;
        }
    }
    return arr;
}

Console.Clear();
Console.WriteLine("Введите предложение или несколько слов");
string message = Console.ReadLine();
string[] array = message.Split(" ");
Console.Write('[' + string.Join(",", array) + ']');
string [] arr = Length(array);
Console.WriteLine();
Console.Write('[' + string.Join(",", arr) + ']');

