// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, -567, 89, 223-> 3 */
Console.WriteLine("введите произвольное количество чисел через запятую");
string inputS=Console.ReadLine();
string[] array =inputS.Split(',');
int count=0;
for (int i=0; i<array.Length; i++)
{
    if(Convert.ToInt32(array[i])>0) count++;
}
Console.WriteLine("количество чисел больше 0 равно "+count);