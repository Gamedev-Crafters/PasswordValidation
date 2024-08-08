namespace PasswordValidationKata;

public class Password {
    private string password;

    public Password(string password) {
        this.password = password;
    }

    public bool IsShorterOrEqualTo(int length)
    {
        return password.Length <= length;
    }

    public bool DoesNotUnderscore()
    {
        return !password.Contains('_');
    }

    public bool DoesNotNumber()
    {
        return !password.Any(Char.IsNumber);
    }

    public bool DoesNotLowerCaseLetters()
    {
        return password.ToUpper() == password;
    }

    public bool DoesNotUpperCaseLetters()
    {
        return password.ToLower() == password;
    }
}