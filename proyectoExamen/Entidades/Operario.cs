using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operario
    {
        private string user;
        private string password;


        public Operario(string user, string pass)
        {
            this.user = user;   
            this.password = pass;
        }
        
        #region GetterSetters
        public string Password { 
            get 
            {
                return password;
            } 
            set 
            {
               this.password = value.ToUpper();
            }
        }
        public string User
        {
            get
            {
                return user.ToUpper();
            }
            set
            {
                this.user = value.ToUpper();
            }
        }
        #endregion 

    }
}
