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

namespace WPFExample.ViewModels;

public class AuthorsViewModel : ViewModel
{
  public AuthorsViewModel()
  {
    _authors = Database.GenerateRandomAuthors();
    _currentAuthor = _authors.FirstOrDefault()!;

    FooCommand = new RelayAsyncCommand(Foo);
  }

  private readonly IList<IAuthor> _authors;
  public IList<IAuthor> Authors => _authors;

  private IAuthor _currentAuthor;
  public IAuthor CurrentAuthor
  {
    get => _currentAuthor;
    set
    {
      if (_currentAuthor != value)
      {
        _currentAuthor = value;
        RaisePropertyChanged();
        AuthorViewModel = new AuthorViewModel(_currentAuthor);
      }
    }
  }

  private AuthorViewModel _authorViewModel;
  public AuthorViewModel AuthorViewModel
  {
    get => _authorViewModel;
    set
    {
      if (_authorViewModel != value)
      {
        _authorViewModel = value;
        RaisePropertyChanged();
      }
    }
  }




  public IList<Book> Books => _currentAuthor.Books;


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
