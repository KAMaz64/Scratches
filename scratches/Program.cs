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

Console.WriteLine("Введите элементы нового массива через пробел");

string[] newArray = Console.ReadLine().Split(" ");
Console.WriteLine();

int y = 3;
int x = NumberOfShort(newArray, y);

string[] newArrayShort = CreateArrayOfShortElements(newArray, x, y);

Console.WriteLine("Массив из элементов заданного массива, длина которых не превышает 3:");
PrintArray(newArrayShort);

int NumberOfShort (string [] inarray, int shortsize)
{
    int shortElements = 0;
    for (int i = 0; i < inarray.Length; i++)
    {
        if (inarray[i].Length <= shortsize)
        {
            shortElements++;
        }
    }
    return shortElements; 
}

string [] CreateArrayOfShortElements (string[] originalArray, int numberofshort, int sizeofshort)
{
    int j = 0;
    string[] shortArray = new string[numberofshort];

    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= sizeofshort)
        {
            shortArray[j] = originalArray[i];
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