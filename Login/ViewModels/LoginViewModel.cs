namespace Login.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {
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
        public bool IsRemember
        {
            get;
            set;
        }
        public ICommand LoginCommand
        {
            get;
            set;
        }
        public ICommand LoginFacebookCommand
        {
            get;
            set;
        }
        public ICommand LoginGmailCommand
        {
            get;
            set;
        }

        public LoginViewModel()
        {
            this.IsRemember = true;
        }
    }
}
