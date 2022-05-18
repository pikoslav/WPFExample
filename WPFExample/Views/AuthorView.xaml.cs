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
using WPFExample.ViewModels;
using WPFExample.UI;

namespace WPFExample.Views;

public partial class AuthorView : UserControl
{
  public AuthorView() => InitializeComponent();
  public AuthorView(IAuthor author) : this()
  {
    DataContext = new AuthorViewModel(author);
  }




  public ICommand BarCommand { get; set; }

  private void Button_Click(Object sender, RoutedEventArgs e)
  {
    var ripple = new RippleEffect();
    //ripple.Center = new Point(0.5, 0.25);
    ripple.Amplitude = 0.1;
    myGrid.Effect = ripple;
  }
}
