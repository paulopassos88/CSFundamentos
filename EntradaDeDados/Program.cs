Console.WriteLine("Entrada de dados\n");

Console.WriteLine("\nIforne o seu nome");
string nome = Console.ReadLine();

Console.WriteLine("\nIforne sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O seu nome e " + nome);

Console.WriteLine($"Sua idade e {idade}");

Console.ReadKey();
