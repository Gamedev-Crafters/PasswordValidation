namespace PasswordValidationKata;

public class PasswordValidator1 {
	public bool IsValid(string password) {
		if (IsShorterOrEqualTo(password, 8))
			return false;
		if (DoesNotUpperCaseLetters(password))
			return false;
		if (DoesNotLowerCaseLetters(password))
			return false;
		if (DoesNotNumber(password))
			return false;
		if (DoesNotUnderscore(password))
			return false;
		return true;
	}

    private static bool IsShorterOrEqualTo(string password, int length)
    {
        return password.Length <= length;
    }

    private static bool DoesNotUnderscore(string password)
    {
        return !password.Contains('_');
    }

    private static bool DoesNotNumber(string password)
    {
        return !password.Any(Char.IsNumber);
    }

    private static bool DoesNotLowerCaseLetters(string password)
    {
        return password.ToUpper() == password;
    }

    private static bool DoesNotUpperCaseLetters(string password)
	{
		return password.ToLower() == password;
	}
}