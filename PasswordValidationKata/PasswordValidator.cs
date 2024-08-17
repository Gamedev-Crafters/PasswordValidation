using System.Collections;

namespace PasswordValidationKata;

public enum FailureReason {
    TooShort,
    NoUppercase,
    NoLowercase,
    NoNumber,
    NoUnderscore
}

public class Result : IEnumerable<FailureReason>
{
	private IEnumerable<FailureReason> failures;

	public Result(IEnumerable<FailureReason> failures) {
		this.failures = failures;
	}

	public bool Contains(params FailureReason[] failures)
	{
		return failures.All(fail => this.failures.Contains(fail));
	}

	public IEnumerator<FailureReason> GetEnumerator() {
		return failures.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	public bool IsValid(){
		return failures.Count()==0;
	}
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