Console.WriteLine("Tipo de dados string, object e dynamic");
Console.WriteLine();

string nome = "Curso de C#";
string titulo = "Curso de C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto e uma string";
valor = "Isto e uma string alterada";

object nota = 10;
object media = 8.5;
object materia = "fisica";
object ativa = true;
object letra = 'A';
dynamic nota2 = 9;

Console.WriteLine(nota);
Console.WriteLine(media);
Console.WriteLine(materia);
Console.WriteLine(ativa);
Console.WriteLine(letra);
Console.WriteLine(nota2);

Console.ReadKey();
