using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.Models;
public class Author : IAuthor
{
  public String Code { get; set; }

  public String FirstName { get; set; }
  public String LastName { get; set; }

  public IList<Book> Books { get; }



}
