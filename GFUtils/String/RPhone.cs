using System.Text.RegularExpressions;

namespace GFUtils.String;

public static class RPhone
{
	private static readonly System.Text.RegularExpressions.Regex PhoneRegex =
		new(@"1(3[0-9]|4[01456879]|5[0-35-9]|6[2567]|7[0-8]|8[0-9]|9[0-35-9])\d{8}");

	private static readonly System.Text.RegularExpressions.Regex PhoneRegexAlone =
		new(@"^1(3[0-9]|4[01456879]|5[0-35-9]|6[2567]|7[0-8]|8[0-9]|9[0-35-9])\d{8}$");


	public static bool IsPhone(this string data) => PhoneRegexAlone.IsMatch(data);
	public static Match MatchPhone(this string data) => PhoneRegex.Match(data);
	public static string MatchFirstPhone(this string data) => MatchPhone(data).Groups[0].Value;
}