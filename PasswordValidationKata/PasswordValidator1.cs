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
        if (password.DoesNotUpperCaseLetters())
	        reasons.Add(FailureReason.NoUppercase);
        if (password.DoesNotLowerCaseLetters())
	        reasons.Add(FailureReason.NoLowercase);
        if (password.DoesNotNumber())
	        reasons.Add(FailureReason.NoNumber);
        if (password.DoesNotUnderscore())
	        reasons.Add(FailureReason.NoUnderscore);
		return reasons.AsEnumerable();
	}
}