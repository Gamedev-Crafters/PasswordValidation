namespace PasswordValidationKata;

public class PasswordValidator1 {
	public bool IsValid(string password) {
		if (Password.IsShorterOrEqualTo(password, 8))
			return false;
		if (Password.DoesNotUpperCaseLetters(password))
			return false;
		if (Password.DoesNotLowerCaseLetters(password))
			return false;
		if (Password.DoesNotNumber(password))
			return false;
		if (Password.DoesNotUnderscore(password))
			return false;
		return true;
	}
}