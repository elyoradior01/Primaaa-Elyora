using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input Angka: ");
		int input = Convert.ToInt32(Console.ReadLine());

		int faktor = 0;

		for (int i = 1; i <= input; i++)
		{

			if (input % i == 0)
			{
				faktor++;
			}


		}
		if (faktor == 2)
		{
			Console.WriteLine("Bilangan  Prima");
		}
		else
		{
			Console.WriteLine("Bilangan Bukan Prima");
		}




	}
}