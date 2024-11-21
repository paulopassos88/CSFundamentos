Console.WriteLine("Conversao de tipos\n");

int valor1 = 123;
double valor2 = 12.45;
decimal valor3 = 12.456789m;

string s1 = valor1.ToString();
string s2 = valor2.ToString();
string s3 = valor3.ToString();

double valor4 = Convert.ToDouble(valor1);

int valor5 = 100000;
Console.WriteLine(Convert.ToByte(valor5)); // OverflowException

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
