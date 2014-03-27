namespace DemoMvvm.WP.ViewModel
{
    using System;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        #region Fields

        private readonly Action _executeActionNoParameters;

        private readonly Action<object> _executeActionWithParameters;

        #endregion

        #region Constructors and Destructors

        public RelayCommand(Action executeAction)
        {
            this._executeActionNoParameters = executeAction;
        }

        public RelayCommand(Action<object> executeAction)
        {
            this._executeActionWithParameters = executeAction;
        }

        #endregion

        #region Public Events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region Public Methods and Operators

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (this._executeActionNoParameters != null)
            {
                this._executeActionNoParameters();
            }
            else
            {
                this._executeActionWithParameters(parameter);
            }
        }

        #endregion
    }
}