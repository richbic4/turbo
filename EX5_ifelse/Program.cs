Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "diana")
{
    Console.WriteLine("Ура, это же DIANA!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}