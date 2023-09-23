// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


System.Console.WriteLine("Введите массив чисел");

string text = Console.ReadLine();

string[] words = text.Split(new char[] { ' ' });

/*foreach (string s in words)  для вывода в терминал
{
    Console.WriteLine(s);
}*/

int[] num = new int[words.Length];
for (int i = 0; i < words.Length; i++)
{
    num[i] = Convert.ToInt32(words[i]);
}
//System.Console.WriteLine(string.Join(' ', num));

int Positiv(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}
int res = Positiv(num);
System.Console.WriteLine(res);