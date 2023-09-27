using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ArrayUsers
    {
        private List<Operario> operarios;
        private List<Supervisor> supervisor;
        
        public ArrayUsers(Operario operario, Supervisor supervisor)
        {
            this.operarios = new List<Operario>();
            this.supervisor = new List<Supervisor>();
        }
        
    }
}
