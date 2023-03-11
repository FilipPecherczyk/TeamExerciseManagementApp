using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeamExerciseManagementApp.ViewModels;

namespace TeamExerciseManagementApp.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel _viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "ProfileContent")
            {
                _viewModel.SelectedViewModel = new ProfileContentViewModel();
            }
            else if (parameter.ToString() == "TreningCalendar")
            {
                _viewModel.SelectedViewModel = new CalendarContentViewModel();
            }
        }
    }
}
