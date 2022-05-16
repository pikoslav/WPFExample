using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPFExample.Models;

namespace WPFExample.ModelViews;

public class AuthorModelView : ModelView
{
  private readonly IAuthor _author;

  public AuthorModelView(IAuthor author) => _author = author;

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
    }
  }
  public String LastName
  {
    get => _author.LastName;
    set
    {
      _author.LastName = value;
      RaisePropertyChanged();
    }
  }

  public IList<Book> Books => _author.Books;
}
