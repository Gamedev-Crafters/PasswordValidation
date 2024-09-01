namespace PasswordValidationKata;

public class ShortAndFormatValidator : PassValidator
{
    public Result Validate(Password password)
    {
        var reasons = new List<FailureReason>();
        if (password.IsShorterOrEqualTo(8))
            reasons.Add(FailureReason.TooShort);
        if (password.DoesNotUpperCaseLetters())
            reasons.Add(FailureReason.NoUppercase);
        if (password.DoesNotLowerCaseLetters())
            reasons.Add(FailureReason.NoLowercase);
        var failureReasons = reasons.AsEnumerable();
        return new Result(failureReasons);
    }
}