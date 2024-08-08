namespace Tests;

public class PasswordValidator2 {
    public bool IsValid(string password) {
        if (password.Length <= 6)
            return false;
        if (password.ToLower() == password)
            return false;
        if (password.ToUpper() == password)
            return false;
        if (!password.Any(Char.IsNumber))
            return false;
        return true;
    }
}