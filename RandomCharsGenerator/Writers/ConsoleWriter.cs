using System;

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
