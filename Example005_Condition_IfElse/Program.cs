Console.Write("Введите имя пользовотеля: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}