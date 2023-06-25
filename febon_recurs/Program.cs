double Fibonachi(int number)
{
    if(number == 1 || number == 2) return 1;
    else return Fibonachi(number - 1) + Fibonachi(number - 2);
}
for(int i =1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonachi(i)}");
}