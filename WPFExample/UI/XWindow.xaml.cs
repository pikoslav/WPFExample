using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPFExample.UI;
/// <summary>
/// Interaction logic for XWindow.xaml
/// </summary>
public partial class XWindow : Window
{
  public static void Execute(UserControl userControl) => new XWindow(userControl).Show();

  //
  //

  private readonly UserControl? _userControl;

  private XWindow() => InitializeComponent();
  public XWindow(UserControl userControl) : this()
  {
    _userControl = userControl;
    Content = userControl;
  }

}
