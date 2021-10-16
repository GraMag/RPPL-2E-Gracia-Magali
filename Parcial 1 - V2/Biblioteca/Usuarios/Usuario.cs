using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{ 
    public abstract class Usuario
    {
        readonly int id;
        string nombre;
        string apellido;
        string password;
        string email;
        string dni;
        DateTime fechaNac;
        string telefono;

        public Usuario(int id)
        {
            this.id = id;
        }

        public Usuario(int id, string nombre, string apellido, string password)
            :this (id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.password = password;
        }

        public Usuario(int id, string nombre, string apellido, string email, string dni, DateTime fechaNac)
            : this (id, nombre, apellido, dni)
        {
            this.email = email;
            this.dni = dni;
            this.fechaNac = fechaNac;
        }

        public Usuario(int id, string nombre, string apellido, string email, string dni, DateTime fechaNac, string telefono)
            : this (id, nombre, apellido, email, dni, fechaNac)
        {
            this.telefono = telefono;
        }

        public int Id
        {
            get 
            { 
                return id; 
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
                if(!string.IsNullOrEmpty(value))
                    nombre = value.Trim();
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
                if (!string.IsNullOrEmpty(value))
                    apellido = value.Trim();
            }
        }

        public virtual string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    email = value.ToLower();
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    password = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre y apellido: {nombre} {apellido}");
            sb.AppendLine($"Email: {Email}");
        
            return sb.ToString();
        }
    }
}
