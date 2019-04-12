using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TinyEd.Helpers
{
    internal class RelayCommand : ICommand
    {
        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecuteFunc = null)
        {
            this.executeAction = executeAction ?? throw new ArgumentNullException(nameof(executeAction));
            this.canExecuteFunc = canExecuteFunc ?? new Func<object, bool>(x => true);
        }

        private readonly Action<object> executeAction;
        private readonly Func<object, bool> canExecuteFunc;

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => canExecuteFunc.Invoke(parameter);

        public void Execute(object parameter) => executeAction.Invoke(parameter);
    }
}
