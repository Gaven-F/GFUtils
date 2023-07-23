using System.Text.RegularExpressions;

namespace GFUtils.String;

public static class REmail
{
	private static readonly Regex EmailRegex =
		new(
			@"[A-Za-z0-9!#$%&'+/=?^_`{|}~-]+(.[A-Za-z0-9!#$%&'+/=?^_`{|}~-]+)*@([A-Za-z0-9]+(?:-[A-Za-z0-9]+)?.)+[A-Za-z0-9]+(-[A-Za-z0-9]+)?");

	private static readonly Regex EmailRegexAlone =
		new(@"^[A-Za-z0-9!#$%&'+/=?^_`{|}~-]+(.[A-Za-z0-9!#$%&'+/=?^_`{|}~-]+)*@([A-Za-z0-9]+(?:-[A-Za-z0-9]+)?.)+[A-Za-z0-9]+(-[A-Za-z0-9]+)?$");


	public static bool IsEmail(this string data)
	{
		return EmailRegexAlone.IsMatch(data);
	}

	public static Match MatchEmail(this string data)
	{
		return EmailRegex.Match(data);
	}

	public static string MatchFirstEmail(this string data)
	{
		return MatchEmail(data).Groups[0].Value;
	}
}