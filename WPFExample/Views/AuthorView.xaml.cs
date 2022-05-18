using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WPFExample.Models;
using WPFExample.ModelViews;
using WPFExample.UI;

namespace WPFExample.Views;

public partial class AuthorView : UserControl
{
  public AuthorView() => InitializeComponent();
  public AuthorView(IAuthor author) : this()
  {
    DataContext = new AuthorModelView(author);
  }




  public ICommand BarCommand { get; set; }

}
