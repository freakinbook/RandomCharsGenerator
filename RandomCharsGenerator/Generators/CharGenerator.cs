using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharsGenerator
{
	class CharGenerator : IGenerator<char[]>
	{
		Random rand = new Random();
		const int max_length = 1000;
		char[] chars;
		GeneratorOptions go = GeneratorOptions.LettersAndNumbers;

		public CharGenerator()
		{
			chars = new char[rand.Next(max_length)];
		}

		public CharGenerator(int length)
		{
			chars = new char[length];
		}

		public CharGenerator(int length, GeneratorOptions go)
		{
			chars = new char[length];
			this.go = go;
		}

		public char[] Generate()
		{
			int numberChance = 1;
			if(go == GeneratorOptions.LettersAndNumbers)
			{
				numberChance = 2;
			}
			for (int i = 0; i < chars.Length; i++)
			{
				// isLower and isNumber are always 0 or 1
				int isLower = rand.Next(2);
				int isNumber = rand.Next(numberChance);
				int asciiCode = isNumber*rand.Next(48,58) + (1-isNumber)*(rand.Next(65, 91) + 32*isLower);
				chars[i] = (char)asciiCode;
			}
			return chars;
		}
	}
}
