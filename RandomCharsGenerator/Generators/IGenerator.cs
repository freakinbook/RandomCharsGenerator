using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharsGenerator
{
	interface IGenerator<T> 
	{
		T Generate();
	}

	enum GeneratorOptions
	{
		Letters = 1,
		LettersAndNumbers = 2,
	}
}
