Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() =="женя")
{
    Console.WriteLine("Хой Жентос");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}