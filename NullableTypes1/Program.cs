Console.WriteLine("Nullable Types\n");

//Nullable<int> valor1 = null;
//Nullable<double> valor2 = null;
//Nullable<bool> valor3 = null;

int? valor1 = null;
double? valor2 = null;
bool? valor3 = null;
int valor4 = valor1 ?? 0;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);

int? x = 4;
int y = 3;
int? result = x * y;

Console.WriteLine(result);

int? valor5 = null;
if (valor5.HasValue)
{
    Console.WriteLine($"valor e {valor5.Value}");
} 
else
{
    Console.WriteLine("Nao possui um valor");
}

Console.ReadKey();
