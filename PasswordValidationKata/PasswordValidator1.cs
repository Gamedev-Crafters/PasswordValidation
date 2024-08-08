namespace PasswordValidationKata;

public enum FailureReason {
    TooShort,
    NoUppercase,
    NoLowercase,
    NoNumber,
    NoUnderscore
}
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

	public IEnumerable<FailureReason> FailureReasons(Password password)
	{
        var reasons = new List<FailureReason>();
        if (password.IsShorterOrEqualTo(8))
            reasons.Add(FailureReason.TooShort);
		return reasons.AsEnumerable();
	}
}