using PasswordValidationKata;
using static PasswordValidationKata.FailureReason;

namespace Tests;

public class Validator1WithReason {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator1();
		Assert.AreEqual(new FailureReason[]{},sut.Validate("Hola1234_"));
	}
	
	[Test]
	public void LessThan8CharShouldGiveReason() {
		var sut = new PasswordValidator1();
        
		Assert.AreEqual(new[]{TooShort}, sut.Validate("Hola123_"));
	}

	[Test]
	public void NoUppercaseGiveReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{NoUppercase}, sut.Validate("hola1234_"));
	}

	[Test]
	public void NoLowercaseGiveReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{NoLowercase}, sut.Validate("HOLA1234_"));
	}

	[Test]
	public void NoNumbersGiveReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{NoNumber}, sut.Validate("HOLAasdpfkoj_"));
	}

	[Test]
	public void NoUnderscoreReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{NoUnderscore}, sut.Validate("HOLAasdp123"));
	}

	[Test]
	public void MultipleReasons()
	{
		var sut = new PasswordValidator1();
		Assert.AreEqual(new[] { TooShort, NoNumber, NoUnderscore },
			sut.Validate("HOLAasdp"));
	}

	[Test]
	public void MultipleReasonsUnordered()
	{
		var sut = new PasswordValidator1();

		var result = sut.Validate("HOLAasdp");

		Assert.IsTrue(result.Contains(TooShort, NoUnderscore, NoNumber));
	}
}


