using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Wprowadź ciąg znaków:");
		string tekst = Console.ReadLine();
		string odwroconyTekst = OdwrocCiag(tekst);
		Console.WriteLine("Odwrocony ciąg znaków: " + odwroconyTekst);
	}

	static string OdwrocCiag(string tekst)
	{
		char[] tablicaZnakow = tekst.ToCharArray();
		Array.Reverse(tablicaZnakow);
		return new string(tablicaZnakow);
	}
}