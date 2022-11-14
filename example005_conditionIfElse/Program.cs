Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine("Ух ты, это же Маша!");
}
else 
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}