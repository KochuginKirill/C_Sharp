Console.WriteLine("Enter username");
string username = Console.ReadLine();

if (username.ToLower() == "kirill")
{
    Console.WriteLine("You are the best! Hi man!");
}
else
{
    Console.Write("Hello! ");
    Console.WriteLine(username);
}