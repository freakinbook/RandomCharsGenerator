using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharsGenerator
{
	class FileWriter : IWriter
	{
		private const string path = "output.txt";
		public void Write(char[] chars)
		{
			using (StreamWriter sw = new StreamWriter(path))
			{
				sw.WriteLine(chars);
			}
		}

		public void Write(string message)
		{
			using (StreamWriter sw = new StreamWriter(path))
			{
				sw.WriteLine(message);
			}
		}

		public FileWriter()
		{
			File.WriteAllText(path, String.Empty);
		}
	}
}
