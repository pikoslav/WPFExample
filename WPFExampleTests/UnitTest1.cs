using System;

using Moq;
using Xunit;

using WPFExample.Models;
using WPFExample.Views;
using WPFExample.ModelViews;

namespace WPFExampleTests;
public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    const String title = "The Lord Of The Rings";
    
    var mock = new Mock<IAuthor>();
    mock.SetupGet(x => x.FirstName).Returns("Dejan");
    mock.SetupGet(x => x.LastName).Returns("Stanič");
    // mock.VerifyGet(x => x.);

    var mview = new AuthorModelView(mock.Object);
    Assert.Equal("Dejan Stanič", mview.FullName);

  }
}