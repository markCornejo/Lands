

namespace Lands.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {

        public LoginViewModel()
        {
            this.IsRemembered = true;
        }


        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }


        public ICommand LoginCommand
        {
            get;
            set;
        }

    }
}
