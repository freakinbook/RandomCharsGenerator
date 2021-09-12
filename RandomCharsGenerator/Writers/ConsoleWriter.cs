using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharsGenerator
{
	class ConsoleWriter : IWriter
	{
		public void Write(char[] chars)
		{
			Console.WriteLine(chars);
		}

		public void Write(string message)
		{
			Console.WriteLine(message);
		}
	}
}
