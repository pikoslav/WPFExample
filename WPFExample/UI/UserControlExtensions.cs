using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFExample.UI;
public static class UserControlExtensions
{
  public static void ShowWindow(this UserControl userControl)
  {
    var window = new Window();
    window.Content = userControl;
    window.Show();
  }
}
