using PasswordValidationKata;

namespace Tests;

public class Validator1WithReason {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator1();
		Assert.AreEqual(new FailureReason[]{},sut.FailureReasons("Hola1234_"));
	}
	
	[Test]
	public void LessThan8CharShouldGiveReason() {
		var sut = new PasswordValidator1();
        
		Assert.AreEqual(new[]{FailureReason.TooShort}, sut.FailureReasons("Hola123_"));
	}

	[Test]
	public void NoUppercaseGiveReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{FailureReason.NoUppercase}, sut.FailureReasons("hola1234_"));
	}

	[Test]
	public void NoLowercaseGiveReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{FailureReason.NoLowercase}, sut.FailureReasons("HOLA1234_"));
	}

	[Test]
	public void NoNumbersGiveReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{FailureReason.NoNumber}, sut.FailureReasons("HOLAasdpfkoj_"));
	}

	[Test]
	public void NoUnderscoreReason() {
		var sut = new PasswordValidator1();

		Assert.AreEqual(new[]{FailureReason.NoUnderscore}, sut.FailureReasons("HOLAasdp123"));
	}
}