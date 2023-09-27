namespace Entidades
{
    public class Supervisor
    {
        private string userSup;
        private string passwordSup;

        public Supervisor(string user,string pass)
        {
            this.userSup = user;    
            this.passwordSup = pass;
        }

        public string Password
        {
            get
            {
                return passwordSup;
            }
            set
            {
                this.passwordSup = value.ToUpper();
            }
        }
        public string User
        {
            get
            {
                return userSup;
            }
            set
            {
                this.userSup = value.ToUpper();
            }
        }
    }
}