using System;
using System.Collections.Generic;
using System.IO;

class Program
{
	static void Main()
	{
		var produktStorage = new Storage<Produkt>();
		
		produktStorage.Add(new Produkt ("Limbo",3535m));
		produktStorage.Add(new Färgregister ("Timmo",35m,"Svart"));

		LäsInFrånFil(produktStorage);

		bool kör = false();

		while (kör)
		{
			Console.WriteLine("Ange bil eller skriv 'stopp'");
			string? namn = Console.ReadLine();

			if(namn != null && namn.ToLower()=="stopp")
			{
				kör = false;
				continue;
			}
			
			if(!string.IsNullOrWhiteSpace(namn))
			{
				Console.WriteLine("Du måste ange en bil");
				continue;
			}

			decimal pris = 0m;

			var originalColor = Console.ForegroundColor;

			try
			{
				Console.ForegroundColor = ConsoleColor.Blue;

				Console.WriteLine("Pris:");
				int prisHeltal = Convert.ToInt32(Console.ReadLine());
				pris = prisHeltal;

			}

			catch (FormatException)
			{
				Console.WriteLine("Du måste ange ett heltal");
				continue;
			}

			catch (OverflowException)
			{
				Console.WriteLine("För långt eller för kort")
				continue;
			}

			finally
			{
				Console.ForegroundColor = originalColor;

			}

			Console.WriteLine("Färg (lämna tomt om okänt):");
			string? färg = Console.ReadLine();

			if(!string.IsNullOrWhiteSpace(färg))
				produktStorage.Add(new Färgregister(namn,pris,färg));
			else
				produktStorage.Add(new Produkt (namn,pris));
		
			File.AppendAllLines("Bilregister.txt", new [] {Namn}, {Pris}, {Färg});

		}

		static void LäsInFrånFil(Storage<Produkt> storage)
		{
			if(File.Exists("Bilregister.txt"))
			{...
				
				

					
	

		
		
