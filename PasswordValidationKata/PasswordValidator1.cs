namespace PasswordValidationKata;

public class PasswordValidator1 {
	public bool IsValid(Password password) {
		if (password.IsShorterOrEqualTo(8))
			return false;
		if (password.DoesNotUpperCaseLetters())
			return false;
		if (password.DoesNotLowerCaseLetters())
			return false;
		if (password.DoesNotNumber())
			return false;
		if (password.DoesNotUnderscore())
			return false;
		return true;
	}

	public string[] FailureReasons(Password password)
	{
		return new[]{"Too few chars"};
	}
}