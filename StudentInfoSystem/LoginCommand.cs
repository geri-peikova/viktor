using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem
{
    class LoginCommand : ICommand
    {
        private LoginViewModel viewModel;

        public LoginCommand(LoginViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.CanCheck;
        }

        public void Execute(object parameter)
        {
            viewModel.SaveChanges();
        }
    }
}
