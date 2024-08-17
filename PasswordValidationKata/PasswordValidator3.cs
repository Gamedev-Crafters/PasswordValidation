using PasswordValidationKata;

namespace Tests;

public class PasswordValidator3 {
    public bool IsValid(Password password) {
        if (password.IsShorterOrEqualTo(16))
            return false;
        if (password.DoesNotLowerCaseLetters())
            return false;
        if (password.DoesNotUpperCaseLetters())
            return false;
		if (password.DoesNotUnderscore())
			return false;
        return true;
    }
}
