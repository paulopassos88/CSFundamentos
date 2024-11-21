Console.WriteLine("Struct DateTime\n");

DateTime dataAtual = DateTime.Now;
DateTime dataHoje = new DateTime(2024, 11, 20);
DateTime dataHoraHoje = new DateTime(2024, 11, 20, 21, 10, 30);

Console.WriteLine(dataAtual);
Console.WriteLine(dataHoje);
Console.WriteLine(dataHoraHoje);

//extrair informacoes da data atual

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Second);

Console.WriteLine(dataAtual.AddDays(30));

Console.ReadKey();
