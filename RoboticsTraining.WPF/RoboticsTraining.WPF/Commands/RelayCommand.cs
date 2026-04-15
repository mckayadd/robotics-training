using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RoboticsTraining.WPF.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action _action;
        private Func<bool>? _canExecute;

        public void Execute(object? parameter)
        {
            _action.Invoke();
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute.Invoke();
        }

        public RelayCommand(Action action)
        { 
            _action = action; 
            _canExecute = null;
        }

        public RelayCommand(Action action, Func<bool>? canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }
    }
}
