using PasswordValidationKata;

namespace Tests;

public class Tests3 {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator3();
		Assert.IsTrue(sut.IsValid("Hol_aaaaaaaaaaaaa"));
	}

	[Test]
	public void LessEqualThan16Characters_Fail() {
		var sut = new PasswordValidator3();
		Assert.IsFalse(sut.IsValid("Hol_aaaaaaaaaaaa"));
	}

	[Test]
	public void NoCapitalLetter_Fail() {
		var sut = new PasswordValidator3();
		Assert.IsFalse(sut.IsValid("hol_aaaaaaaaaaaaa"));
	}

	[Test]
	public void NoLowercaseLetter_Fail() {
		var sut = new PasswordValidator3();
		Assert.IsFalse(sut.IsValid("HAA_AAAAAAAAAAAAA"));
	}

	[Test]
	public void NoUnderscore_Fail() {
		var sut = new PasswordValidator3();
		Assert.IsFalse(sut.IsValid("Holaaaaaaaaaaaaa"));
	}
}