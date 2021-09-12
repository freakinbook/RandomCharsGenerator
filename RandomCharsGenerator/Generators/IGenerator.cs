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
