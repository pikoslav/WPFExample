using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFExample.UI
{
  public class RelayCommand : ICommand
  {
    private readonly Action _execute;
    private readonly Func<Boolean>? _canExecute;

    public RelayCommand(Action execute) : this(execute, null) { }
    public RelayCommand(Action execute, Func<bool>? canExecute) => (_canExecute, _execute) = (canExecute, execute);

    public void Execute(Object? parameter) => _execute.Invoke();
    public Boolean CanExecute(Object? parameter) => _canExecute?.Invoke() ?? true;

    public event EventHandler? CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }
  }
}
