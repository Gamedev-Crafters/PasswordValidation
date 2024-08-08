using PasswordValidationKata;

namespace Tests;

public class Validator1WithReason {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator1();
		Assert.AreEqual(new string[]{},sut.FailureReasons("Hola1234_"));
	}
	
	[Test]
	public void LessThan8CharShouldGiveReason() {
		var sut = new PasswordValidator1();
        
		Assert.AreEqual(new[]{"Too few chars"}, sut.FailureReasons("Hola123_"));
	}

	// [Test]
	// public void NoUppercaseShouldFail() {
	// 	var sut = new PasswordValidator1();
	// 	Assert.IsFalse(sut.IsValid("hola1234_"));
	// }
 //
 //    [Test]
 //    public void NoLowercaseShouldFail() {
 //        var sut = new PasswordValidator1();
 //        Assert.IsFalse(sut.IsValid("HOLA1234_"));
 //    }
 //
	// [Test]
	// public void NoNumberShouldFail() {
	// 	var sut = new PasswordValidator1();
	// 	Assert.IsFalse(sut.IsValid("Holaholahola_"));
	// }
 //
 //    [Test]
 //    public void NoUnderscoreShouldFail()
 //    {
 //        var sut = new PasswordValidator1();
 //        Assert.IsFalse(sut.IsValid("Hola12347298734289374238947"));
	// }
}