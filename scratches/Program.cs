
Console.Clear();

Console.WriteLine("Введите элементы нового массива через пробел");

string[] newArray = Console.ReadLine().Split(" ");
Console.WriteLine();

Console.WriteLine("Массив из элементов заданного массива, длина которых не превышает 3:");
PrintArrayOfShortElements(newArray);

void PrintArrayOfShortElements(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}

