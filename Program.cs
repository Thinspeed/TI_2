using System;

namespace TI2
{
	class Program
	{
		bool IsNumberPrime(int number)
		{
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}

			return true;
		}

		static void Main(string[] args)
		{
			int p = int.Parse(Console.ReadLine());
			int q = int.Parse(Console.ReadLine());
			var decoder = new Decoder(p, q);
			var coder = new Coder(decoder.PublicKey, decoder.Mod);
			string message = "BSUIR";
			var result = coder.CodeMessage(message);
			result = decoder.DeCodeMessage(result);
			Console.WriteLine(result);
		}
	}
}
