using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_auditoria.Modelo
{
    class Auditor
    {
        int idauditor;
        string nombre;
        string apellido;
        string mail;
        string competencias;
        string nombreCompleto;
        public int Idauditor
        {
            get
            {
                return idauditor;
            }

            set
            {
                idauditor = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Competencias
        {
            get
            {
                return competencias;
            }

            set
            {
                competencias = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return apellido + ", " + nombre;
            }

            set
            {
                nombreCompleto = value;
            }
        }
    }
}
