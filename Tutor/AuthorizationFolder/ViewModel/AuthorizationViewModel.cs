using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace Tutor.Authorization.ViewModel
{
    public class AuthorizationViewModel : INotifyPropertyChanged
    {
        public AuthorizationViewModel()
        {

        }

        private bool OnSignInCanExecute(object obj)
        {
            if (Login != null && Login != string.Empty && Password != null && Password != string.Empty)
                return true;
            return false;
        }

        private void OnSignInExecuted(object obj)
        {
            //TODO: Authorization in db
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand SignInCommand { get; set; }
    }
}
