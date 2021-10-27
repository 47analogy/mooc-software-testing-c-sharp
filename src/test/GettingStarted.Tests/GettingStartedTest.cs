using Xunit;
using Getting.Started; // important


namespace Getting.UnitTests.Started // scopes the class
{
  public class GettingStartedTest
  {
    [Fact] // attribute declares a test method that's run by the test runner
    public void addFiveTo20() // method
    {
      int result = new GettingStarted().addFive(20); // invokes the function and assigns to variable
      Assert.Equal(25, result); // assertion
    }

    [Fact]
    public void addFiveToZero()
    {
      int result = new GettingStarted().addFive(0);
      Assert.Equal(5, result);
    }

    [Fact]
    public void addFiveToMinus20()
    {
      int result = new GettingStarted().addFive(-20);
      Assert.Equal(-15, result);
    }
  }
}
