using System.Text.RegularExpressions;

namespace GFUtils.String;

public static class RPhone
{
	private static readonly Regex PhoneRegex =
		new(@"1(3[0-9]|4[01456879]|5[0-35-9]|6[2567]|7[0-8]|8[0-9]|9[0-35-9])\d{8}");

	private static readonly Regex PhoneRegexAlone =
		new(@"^1(3[0-9]|4[01456879]|5[0-35-9]|6[2567]|7[0-8]|8[0-9]|9[0-35-9])\d{8}$");


	public static bool IsPhone(this string data)
	{
		return PhoneRegexAlone.IsMatch(data);
	}

	public static Match MatchPhone(this string data)
	{
		return PhoneRegex.Match(data);
	}

	public static string MatchFirstPhone(this string data)
	{
		return MatchPhone(data).Groups[0].Value;
	}
}