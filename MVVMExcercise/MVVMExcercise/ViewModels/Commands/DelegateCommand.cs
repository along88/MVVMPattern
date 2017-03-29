using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMExcercise.ViewModels.Commands
{
    public class DelegateCommand : ICommand
    {

        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute )
        {
            if(execute == null)
            {
                throw new Exception("This some ol' bullshit!");
            }
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public DelegateCommand(Action<object> execute) : this(execute, null)
        {

        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(parameter == null)
            {
                return true;
            }
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
