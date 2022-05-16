using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPFExample.Models;

namespace WPFExample.ModelViews;

public class BookModelView : ModelView
{
  private readonly IBook _book;

  public BookModelView(IBook book)
  {
    _book = book;
  }

  public String Title
  {
    get => _book.Title;
    set
    {
      _book.Title = value;
      RaisePropertyChanged();
    }
  }

  public Int32 Year
  {
    get => _book.Year;
    set
    {
      _book.Year = value;
      RaisePropertyChanged();
    }
  }
}
