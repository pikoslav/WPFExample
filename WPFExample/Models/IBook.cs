using System;
using System.Collections.Generic;

namespace WPFExample.Models;


public interface IBook
{
  String Title { get; set; }
  Int32 Year { get; set; }

}