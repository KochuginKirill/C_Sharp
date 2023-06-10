Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if (username.ToLower() == "Кирилл")
{
    Console.WriteLine("Здаров, мужик!");
}
else
{
    Console.Write("Привет! ");
    Console.WriteLine(username);
}