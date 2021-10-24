using System;

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")  // ToLower приводим ответ к верхнему регистру.
{
    Console.WriteLine("Ура, Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}