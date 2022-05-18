using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFExample.ViewModels;

public abstract class ViewModel : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler? PropertyChanged;
  public void RaisePropertyChanged([CallerMemberName] String? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

  public void InvokeOnUiThread(Action callback) => Application.Current.Dispatcher.Invoke(callback);

}
