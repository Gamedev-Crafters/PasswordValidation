namespace PasswordValidationKata;

public class PasswordValidator1 {
	public bool IsValid(string password) {
		if (password.Length <= 8)
			return false;
		if (password.ToLower() == password)
			return false;
		if (password.ToUpper() == password)
			return false;
		if (!password.Any(Char.IsNumber))
			return false;
		if (!password.Contains('_'))
			return false;
		return true;
	}
}