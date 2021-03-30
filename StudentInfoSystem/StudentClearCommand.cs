using System;
using System.Windows.Input;

namespace StudentInfoSystem
{
    internal class StudentClearCommand : ICommand
    {
        private StudentViewModel viewModel;

        public StudentClearCommand(StudentViewModel viewModel)
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
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.ClearForm();
        }
    }
}