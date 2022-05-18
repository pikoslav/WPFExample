using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFExample.UI
{
  public class RelayAsyncCommand : ICommand
  {
    private readonly Func<Task> _execute;
    private readonly Func<Boolean>? _canExecute;

    public RelayAsyncCommand(Func<Task> execute) : this(execute, null) { }
    public RelayAsyncCommand(Func<Task> execute, Func<bool>? canExecute) => (_canExecute, _execute) = (canExecute, execute);

    public async void Execute(Object? parameter)
    {
      await Task.Run(_execute);
    }

    public async Task ExecuteAsync(Object? parameter)
    {
      await _execute();
    }

    public Boolean CanExecute(Object? parameter) => _canExecute?.Invoke() ?? true;

    public event EventHandler? CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }
  }
}
