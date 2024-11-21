Console.WriteLine("Constantes");

double raio, perimetro, area;

const double PI = 3.14;

Console.Write("Informe o raio do circulo : ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine($"Perimetro = {perimetro}");
Console.WriteLine($"Area = {area}");
