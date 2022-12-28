const int qt = 3;   // количество символов
// string[] str = { "123", "asdf", "someworld", "654321", "cat", "*_*", "Hello World!" };
// string[] str = { "1234", "asdf", "someworld", "654321", "cats", "<*_*>", "Hello World!" };
string[] str = UserFillArray();
int count = 0;

foreach (var s in str)
{
    if (s.Length <= qt) count++;
}

if (count == 0)
{
    Console.WriteLine($"В заданном массиве нет элементов, длина которых меньше либо равна {qt} символам.");
}
else CreateResultArray(str, count);

// Заполнение массива пользователем
string[] UserFillArray()
{
    Console.Write("Введите желаемое количество строк: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"\nВведите строку №{i + 1}:");
        array[i] = Console.ReadLine();
    }
    return array;
}

// Создание и вывод нового массива с искомыми элементами
void CreateResultArray(string[] arr, int c)
{
    int k = 0;
    string[] result = new string[c];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= qt)
        {
            result[k] = arr[i];
            k++;
        }
    }
    Console.WriteLine($"\n[ \"{String.Join("\", \"", result)}\" ]");
}
