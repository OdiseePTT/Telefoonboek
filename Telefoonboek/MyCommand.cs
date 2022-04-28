using System;
using System.Windows.Input;

namespace Telefoonboek
{
    internal class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action action;

        public MyCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return action != null;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}