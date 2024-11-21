Console.WriteLine("Operadores aritmeticos");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potencia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor minimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"Valor maximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");

//Console.WriteLine($"soma de x + y = {x + y}");
//Console.WriteLine($"subtracao de x - y = {x - y}");
//Console.WriteLine($"multiplicao de x * y = {x * y}");
//Console.WriteLine($"divisao de x / y = {(double) x / y}");
//Console.WriteLine($"modulo de x % y = {x % y}");

Console.ReadKey();
