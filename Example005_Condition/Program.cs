Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower == "оля")
{
    Console.Write("Ура, это же Оля!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username + "!");
}