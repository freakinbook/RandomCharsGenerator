using System;
using Unity;

namespace RandomCharsGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			IUnityContainer container = new UnityContainer();
			// checking the first argument for specified output way
			// uses console output by default
			switch (args[0].ToLower())
			{
				case "console":
					{
						container.RegisterType<IWriter, ConsoleWriter>("console");
						break;
					}
				case "file":
					{
						container.RegisterType<IWriter, FileWriter>("file");
						break;
					}
				case "both":
					{
						container.RegisterType<IWriter, ConsoleWriter>("console");
						container.RegisterType<IWriter, FileWriter>("file");
						break;
					}
				default:
					{
						Console.WriteLine("Unspecified output way. Using default: console output\n");
						container.RegisterType<IWriter, ConsoleWriter>("console");
						break;
					}
			}
			container.RegisterType<IGenerator<char[]>, CharGenerator>();
			var generator = container.Resolve<IGenerator<char[]>>();
			// resolving all IWriters because we can have many simultaneously
			var writers = container.ResolveAll<IWriter>();
			var output = generator.Generate();
			foreach (var writer in writers)
			{
				writer.Write(output);
			}
		}
	}
}
