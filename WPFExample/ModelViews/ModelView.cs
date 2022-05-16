using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.ModelViews;

public abstract class ModelView : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler? PropertyChanged;

  public void RaisePropertyChanged([CallerMemberName] String? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
