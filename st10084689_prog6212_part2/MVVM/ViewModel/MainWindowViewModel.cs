using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using st10084689_prog6212_part2.Core;
using System.Windows;

namespace st10084689_prog6212_part2.MVVM.ViewModel
{
    class MainWindowViewModel: ObversableObject
    {
        public RelayCommand ShowSignInView { get; set; }

        public RelayCommand ShowLogInView { get; set; }


        private object _CurrentView;

        public object CurrentView
        {
            get { return _CurrentView; }
            set
            {
                _CurrentView = value;
                OnPropertyChanged();
            }
        }

        public LogInViewModel LogInVM { get; set; }
        public SignInViewModel SignInVM { get; set; }

        public MainWindowViewModel()
        {
            LogInVM = new LogInViewModel();
            SignInVM = new SignInViewModel();
            CurrentView = SignInVM;

            Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;


            ShowSignInView = new RelayCommand(o => {CurrentView = SignInVM; });
            ShowLogInView = new RelayCommand(o => {CurrentView = LogInVM;});

        }
    }
}
