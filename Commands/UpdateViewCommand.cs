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
            switch (parameter.ToString())
            {
                case "ProfileContent":
                    _viewModel.SelectedViewModel = new ProfileContentViewModel();
                    break;
                case "TreningCalendar":
                    _viewModel.SelectedViewModel = new CalendarContentViewModel();
                    break;
                case "Results":
                    _viewModel.SelectedViewModel = new ReslutsContentViewModel();
                    break;
                case "GroupResults":
                    _viewModel.SelectedViewModel = new GroupResultsContentViewModel();
                    break;
            }
        }
    }
}
