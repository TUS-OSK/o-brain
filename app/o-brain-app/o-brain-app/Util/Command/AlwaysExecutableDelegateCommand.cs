using System;

namespace o_brain_app.Util.Command
{
    public class AlwaysExecutableDelegateCommand : DelegateCommandBase
    {

        public AlwaysExecutableDelegateCommand(Action<object> act)
            : base(act)
        {

        }

     
        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
