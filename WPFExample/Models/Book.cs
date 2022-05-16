using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.Models;
public class Book : IBook
{
  public String Title { get; set; }
  public Int32 Year { get; set; }
}
