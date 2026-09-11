Console.WriteLine("+--- Primeiro Caractere ---+");
Console.Write("|Digite algo....:");

string txtdigitado = Console.ReadLine()!;

Console.WriteLine(txtdigitado.Trim().Substring(0,1));