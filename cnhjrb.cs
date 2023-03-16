/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/


////////////задание 7////////////


Console.WriteLine("Дайте слово(Находит самое длинное слово и ставит его в начало): ");

string w = Console.ReadLine();
string[] words7 = w.Split(' ');
string longest = "";

foreach (string wod in words7)
{
    if (word.Length > longest.Length)
    {
        longest = word;
    }
}

w = longest + " " + w.Replace(longest, "");

Conole.WriteLine("Новая строка: " + w);




//////////задание 9////////////


Console.WriteLine("Введите слово к заданию 9(Меняет все 'т' на 'Т'): ");

string q = Console.ReadLine();
string upg = q.Replace('a', 'A');

Console.WriteLine("Обновлённая строка:" + upg);




///////////////////задание 10//////////////////


Console.WriteLine("Введите слово(Определяет первая или последняя буква встречается чаще): ");

string kk = Console.ReadLine();

int kk1 = 0;
int kk2 = 0;

for (int i = 0; i < kk.Length; i++)
{
    if (kk[i] == k[0])
    {
        kk1++;
    }
    if (kk[i] == kk[kk.Lemgth - 1])
    {
        kk2++;
    }
}

if (kk1 > kk2)
{
    Console.WriteLine("Первая буква встречается чаще");
}
else if (kk1 < kk2)
{
    Console.WriteLine("Последняя буква встречается чаще");
}
else
{
    Console.WriteLine("И первая, и последняя буквы встречаются одинаково");
}
