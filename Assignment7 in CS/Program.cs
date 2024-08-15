// See https://aka.ms/new-console-template for more information
class Assignment7
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("enter c:");
        int c = int.Parse(Console.ReadLine());
        if(a>b && a>c)
        {
            Console.WriteLine($"{a} is the greatest among three");
        }
        else if(b>c)
        {
            Console.WriteLine($"{b} is the greatest among three");
        }
        else
        {
            Console.WriteLine($"{c} is the greatest among three");
        }
    }
}
