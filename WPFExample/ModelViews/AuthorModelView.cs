using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

using WPFExample.Models;
using WPFExample.UI;

namespace WPFExample.ModelViews;

public class AuthorModelView : ModelView
{
  private readonly IAuthor _author;

  public AuthorModelView(IAuthor author)
  {
    _author = author;

    FooCommand = new RelayAsyncCommand(Foo);
  }


  public String Code
  {
    get => _author.Code;
    set
    {
      _author.Code = value;
      RaisePropertyChanged();
    }
  }

  public String FirstName
  {
    get => _author.FirstName;
    set
    {
      _author.FirstName = value;
      RaisePropertyChanged();
      RaisePropertyChanged(nameof(FullName));
    }
  }

  public String LastName
  {
    get => _author.LastName;
    set
    {
      _author.LastName = value;
      RaisePropertyChanged();
      RaisePropertyChanged(nameof(FullName));
    }
  }

  public String FullName
  {
    get => String.Concat(FirstName ?? String.Empty, " ", LastName ?? String.Empty).Trim();
  }

  public IList<Book> Books => _author.Books;


  private Boolean _isUiEnabled = true;
  public Boolean IsUiEnabled
  {
    get => _isUiEnabled;
    set
    {
      _isUiEnabled = value;
      RaisePropertyChanged();
    }
  }

  public ICommand FooCommand { get; set; }
  public async Task Foo()
  {
    IsUiEnabled = false;
    try
    {
      Debug.WriteLine("Foo1");
      await Task.Delay(2000);
      Debug.WriteLine("Foo2");
      await Task.Delay(2000);
      Debug.WriteLine("Foo3");
    }
    finally
    {
      IsUiEnabled = true;
    }
  }
}
