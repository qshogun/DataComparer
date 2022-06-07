using DataComparerMVVM.Commands;
using DataComparerMVVM.Core;
using DataComparerMVVM.MVVM.Model;
using System.Windows;

namespace DataComparerMVVM.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand InitializeViewCommand { get; set; }
        public RelayCommand CompareViewCommand { get; set; }
        public RelayCommand ExitApplication { get; set; }
        public InitializeViewModel InitializeVM { get; set; }
        public CompareViewModel CompareVM { get; set; }
        

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            InitializeVM = new InitializeViewModel();
            CompareVM = new CompareViewModel();
            CurrentView = InitializeVM;

            InitializeViewCommand = new RelayCommand(o =>
            {
                CurrentView = InitializeVM;
            });

            CompareViewCommand = new RelayCommand(o =>
            {
                CurrentView = CompareVM;
            });

            ExitApplication = new RelayCommand(o =>
            {
                Application.Current.Shutdown();
            });
        }
    }
}