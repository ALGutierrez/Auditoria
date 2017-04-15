using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_auditoria.Modelo
{
    public class Usuario
    {
        int idusuario;
        string usuario;
        string contraseña;
        string tipo;
        Auditor auditor;

        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }

        public string Nombreusuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        internal Auditor Auditor
        {
            get
            {
                return auditor;
            }

            set
            {
                auditor = value;
            }
        }
    }
}
