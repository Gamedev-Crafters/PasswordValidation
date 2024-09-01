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
        return new Result(validators.SelectMany(validator => validator.Validate(password)));
    }
}