int a = 25;
int b = 5;

if (b * b == a)
    Console.WriteLine("true");
else
    Console.WriteLine("false");

//Console.Write("Enter a number: ");
//string str1 = Console.ReadLine()!;

//Console.WriteLine(str1 + str1);

//int num1 = int.Parse(str1);
//Console.WriteLine(num1 + num1);

Console.Write("Enter a number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(num1 * num1);