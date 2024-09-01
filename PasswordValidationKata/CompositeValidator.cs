namespace PasswordValidationKata;

public class CompositeValidator : PassValidator
{
    private readonly List<PassValidator> validators;

    public CompositeValidator(List<PassValidator> validators)
    {
        this.validators = validators;
    }
    
    public Result Validate(Password password)
    {
        var reasons = new List<FailureReason>();
        foreach (var validator in validators)
        {
            var result = validator.Validate(password);
            reasons.AddRange(result);
        }
        return new Result(reasons.AsEnumerable());
    }
}