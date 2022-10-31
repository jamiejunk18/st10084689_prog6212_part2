using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace st10084689_prog6212_part2.Core
{
    class RelayCommand : ICommand
    {
        private Action<Object> _execute;
        private Func<Object, bool> _canExecute;




        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this._canExecute == null || this.CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            this._execute(parameter);
        }
    }
}

