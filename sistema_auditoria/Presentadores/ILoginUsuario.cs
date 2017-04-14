using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_auditoria.Presentadores
{
    interface ILoginUsuario
    {
        string ingresarUsuario(string user, string password);
    }
}
