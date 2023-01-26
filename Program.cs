
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] array = new string[n]; //создаем массив
for (int i = 0; i < array.Length; i++) //наполянем массив данными
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
}
string [] newarray = new string[array.Length];
Console.WriteLine($"[{string.Join(", ", array)}]"); //вывод начального массива для проверки

// for (int i = 0; i < array.Length; i++)
// {
// if (string [i] )


// }

// foreach (int element in numbers)

// string number = Convert.ToString(Console.ReadLine());
// int count = number.Length;


Console.WriteLine($"[{string.Join(", ", array)}]");
