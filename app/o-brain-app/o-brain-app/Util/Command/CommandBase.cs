using System;
using System.Windows.Input;

namespace o_brain_app.Util.Command
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged = delegate { };

        protected void NotifyCanExecuteChanged()
        {
            this.CanExecuteChanged(this, new EventArgs());
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
