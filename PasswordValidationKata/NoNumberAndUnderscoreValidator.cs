namespace PasswordValidationKata;

public class NoNumberAndUnderscoreValidator : PassValidator
{
    public Result Validate(Password password)
    {
        var reasons = new List<FailureReason>();
        if (password.DoesNotNumber())
            reasons.Add(FailureReason.NoNumber);
        if (password.DoesNotUnderscore())
            reasons.Add(FailureReason.NoUnderscore);
        var failureReasons = reasons.AsEnumerable();
        return new Result(failureReasons);
    }
}