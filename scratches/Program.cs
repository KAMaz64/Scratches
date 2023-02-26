/* 
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
 */


/* Console.Clear();

Console.WriteLine("Введите элементы нового массива через пробел");

string[] newArray = Console.ReadLine().Split(" ");
Console.WriteLine();

int NumberOfShort = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i].Length <= 3)
    {
        NumberOfShort++;
    }
}

int x = NumberOfShort;

string[] newArrayShort = new string[x]; 
int j = 0;

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i].Length <= 3)
    {
        newArrayShort[j] = newArray[i];
        j++;
    }
}

Console.WriteLine("Массив из элементов заданного массива, длина которых не превышает 3:");
PrintArray(newArrayShort);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
} */

Console.Clear();

Console.WriteLine("Введите элементы нового массива через запятую и пробел");

string[] newArray = Console.ReadLine().Split(", ");
Console.WriteLine();

int y = 3;
int len = newArray.Length;
int x = NumberOfShort(newArray, len, y);

string[] newArrayShort = CreateArrayOfShortElements(newArray, len, x, y);

Console.WriteLine("Массив из элементов заданного массива, длина которых не превышает 3:");
PrintArray(newArrayShort);

int NumberOfShort (string [] inarray, int inarraylen, int shortsize)
{
    int shortElements = 0;
    for (int i = 0; i < inarraylen; i++)
    {
        if (inarray[i].Length <= shortsize)
        {
            shortElements++;
        }
    }
    return shortElements; 
}

string [] CreateArrayOfShortElements (string[] originalarray, int originalarraylen, int numberofshort, int sizeofshort)
{
    int j = 0;
    string[] shortArray = new string[numberofshort];

    for (int i = 0; i < originalarraylen; i++)
    {
        if (originalarray[i].Length <= sizeofshort)
        {
            shortArray[j] = originalarray[i];
            j++;
        }
    }
    return shortArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}