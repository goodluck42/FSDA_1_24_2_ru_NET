public static class StringExtensions
{
	public static string Capitalize(this string source)
	{
		return char.ToUpper(source[0]) + source[1..];
	}
}