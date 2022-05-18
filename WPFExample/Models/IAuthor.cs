using System;
using System.Collections.Generic;

namespace WPFExample.Models;

public interface IAuthor
{
  String? FirstName { get; set; }
  String? LastName { get; set; }
  
  String? ImageName { get; set; }

  IList<Book> Books { get; }

}