// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] -> [“-2”]
// [“Russia”, “Denmark”, “Kazan”] -> [] 


string[] GetArray(string[] collection)
{
    int len = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= 3) ++len;
    }
    string[] result = new string[len];
    int el = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= 3)
        {
            result[el] = collection[i];
            ++el;
        }
    }
    return result;
}

void PrintArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i]);
        if (i != myArray.Length - 1) Console.Write(",");
    }
}

Console.Clear();

Console.Write("Введите масссив через запятую: ");
string[] array = Array.ConvertAll(Console.ReadLine()!.Split(','), Convert.ToString); 
string[] answer = GetArray(array);
// PrintArray(answer);

Console.WriteLine(String.Join(", ", answer));