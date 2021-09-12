using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharsGenerator
{
	interface IWriter
	{
		void Write(char[] chars);
		void Write(string message);
	}
}
