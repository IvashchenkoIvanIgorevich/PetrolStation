using System;
using System.Windows.Input;

namespace PetrolStation
{
    public class RelayComand : ICommand
    {
        #region Constructor

        public RelayComand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion

        #region Implementation interface

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion

        #region Data

        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        #endregion
		
		//commit
    }
}
