using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KretaProject.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;

        private readonly StudentViewModel _studentViewModel;
        private readonly ControlPanelViewModel _controlPanelViewModel;
        private readonly SchoolClassViewModel _schoolClassViewModel;

        public MainViewModel()
        {
            _studentViewModel=new StudentViewModel();
            _controlPanelViewModel=new ControlPanelViewModel();
            _schoolClassViewModel=new SchoolClassViewModel();
            CurrentView=_controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowStudentView()
        {
            CurrentView = _studentViewModel;
        }

        [RelayCommand]
        private void ShowControlPanel()
        {
            CurrentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowSchoolClass()
        {
            CurrentView = _schoolClassViewModel;
        }

    }
}
