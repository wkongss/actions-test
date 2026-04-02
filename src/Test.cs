using Allure.NUnit;
using NUnit.Framework;
using App;

namespace MyTest;

[AllureNUnit]
[TestFixture]
public class MyTest
{
    [Test]
    [Description("This always passes")]
    public void Pass()
    {
        Assert.That(Dummy.ReturnTrue(), Is.True);
    }
}
