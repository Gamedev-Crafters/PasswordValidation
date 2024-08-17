namespace PasswordValidationKata;

public enum FailureReason {
    TooShort,
    NoUppercase,
    NoLowercase,
    NoNumber,
    NoUnderscore
}

public class PasswordValidator {

	public bool IsValid(Password password) {
		return Validate(password).IsValid();
	}

	public Result Validate(Password password)
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
		var failureReasons = reasons.AsEnumerable();
		return new Result(failureReasons);
	}
}