using System;
using System.Windows.Input;

namespace StudentInfoSystem
{
    internal class StudentCheckCommand : ICommand
    {
        private StudentViewModel viewModel;

        public StudentCheckCommand(StudentViewModel viewModel)
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