namespace Tests;

public class PasswordValidator3 {
    public bool IsValid(string password) {
        if (password.Length <= 16)
            return false;
        if (password.ToLower() == password)
            return false;
        if (password.ToUpper() == password)
            return false;
		if (!password.Contains('_'))
			return false;
        return true;
    }
}