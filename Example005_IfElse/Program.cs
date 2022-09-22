Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура это МАША");
}
else
{
    Console.Write("Привет - ");
    Console.WriteLine(username);
}
