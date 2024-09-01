namespace PasswordValidationKata;

public interface PassValidator
{
    public Result Validate(Password password);
}