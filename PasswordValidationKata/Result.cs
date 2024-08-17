using System.Collections;

namespace PasswordValidationKata;

public class Result : IEnumerable<FailureReason>
{
    private readonly IEnumerable<FailureReason> failures;

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
        return !failures.Any();
    }
}