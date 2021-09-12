using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharsGenerator
{
	class StringGenerator : IGenerator<string>
	{
		Random rand = new Random();
		const int max_length = 1000;
		int length;
		GeneratorOptions go = GeneratorOptions.LettersAndNumbers;

		public StringGenerator()
		{
			this.length = rand.Next(max_length);
		}

		public StringGenerator(int length)
		{
			this.length = length;
		}

		public StringGenerator(int length, GeneratorOptions go)
		{
			this.length = length;
			this.go = go;
		}


		public string Generate()
		{
			int numberChance = 1;
			if (go == GeneratorOptions.LettersAndNumbers)
			{
				numberChance = 2;
			}
			StringBuilder sb = new StringBuilder(length);
			for (int i = 0; i < length; i++)
			{
				// isLower and isNumber are always 0 or 1
				int isLower = rand.Next(2);
				int isNumber = rand.Next(numberChance);
				int asciiCode = isNumber * rand.Next(48, 58) + (1 - isNumber) * (rand.Next(65, 91) + 32 * isLower);
				sb.Append((char)asciiCode);
			}
			return sb.ToString();
		}
	}
}
