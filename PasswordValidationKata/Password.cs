namespace PasswordValidationKata;

public class Password
{
    public static bool IsShorterOrEqualTo(string password, int length)
    {
        return password.Length <= length;
    }

    public static bool DoesNotUnderscore(string password)
    {
        return !password.Contains('_');
    }

    public static bool DoesNotNumber(string password)
    {
        return !password.Any(Char.IsNumber);
    }

    public static bool DoesNotLowerCaseLetters(string password)
    {
        return password.ToUpper() == password;
    }

    public static bool DoesNotUpperCaseLetters(string password)
    {
        return password.ToLower() == password;
    }
}