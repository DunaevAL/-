// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] stringArray = new string[3];

for (int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine("Введите строку");
    stringArray[i] = Console.ReadLine();
}

int count = 0;
foreach (string str in stringArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];
int a = 0;
foreach (string str in stringArray)
{
    if (str.Length <= 3)
    {
        newArray[a] = str;
        a++;
    }
}

Console.WriteLine("Строки длиной меньше или равной 3 символам:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}
