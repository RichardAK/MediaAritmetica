double n1, n2, n3, media ;

Console.WriteLine("Média Aritmética de 3 números\n");

Console.Write("digite o primeiro numero:");
n1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("digite o segundo numero:");
n2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("digite o terceiro numero:");
n3 = Convert.ToDouble(Console.ReadLine()!);

media = (n1+n2+n3)/3;

Console.WriteLine($"Média:{media:N1}");