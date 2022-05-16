using System;

using Moq;
using Xunit;

using WPFExample.Models;


namespace WPFExampleTests;
public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    const String title = "The Lord Of The Rings";
    
    var mock = new Mock<IBook>();

    mock.SetupGet(x => x.Title).Returns(title);
    Assert.Equal(title, mock.Object.Title);


    mock.VerifyGet(x => x.Title);

  }
}