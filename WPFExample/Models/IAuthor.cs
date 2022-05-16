using System;
using System.Collections.Generic;

namespace WPFExample.Models;

public interface IAuthor
{
  String Code { get; set; }

  String FirstName { get; set; }
  String LastName { get; set; }

  IList<Book> Books { get; }

}