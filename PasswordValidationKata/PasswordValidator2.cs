using PasswordValidationKata;

namespace Tests;

public class PasswordValidator2 {
    public bool IsValid(Password password) {
        if (password.IsShorterOrEqualTo(6))
            return false;
        if (password.DoesNotUpperCaseLetters())
            return false;
        if (password.DoesNotLowerCaseLetters())
            return false;
        if (password.DoesNotNumber())
            return false;
        return true;
    }
}