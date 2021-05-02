using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI2
{
	class Coder
	{
		int publicKey;
		int mod;

		public Coder(int publicKey, int mod)
        {
			this.publicKey = publicKey;
			this.mod = mod;
        }

		public string CodeMessage(string message)
        {
			var result = new StringBuilder();
			foreach (var symbol in message)
			{
				result.Append((char)CodeSymble(symbol, publicKey, mod));
			}

			return result.ToString();
		}

		int CodeSymble(int a, int pow, int mod)
		{
			int result = 1;
			while (pow != 0)
			{
				while (pow % 2 == 0)
				{
					pow = pow / 2;
					a = (a * a) % mod;
				}

				pow = pow - 1;
				result = (result * a) % mod;
			}

			return result;
		}
	}
}
