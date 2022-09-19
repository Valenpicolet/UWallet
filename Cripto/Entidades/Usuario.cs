using System;

namespace Pav.Entidades
{
    public class Usuario
    {
        #region Atributos
        private string nombre;
        private string contrasenia;
        private Perfil perfil;
        private DateTime fecha_alta;
        #endregion

        #region Accesores
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return this.nombre; }
        public void setContrasenia(string contrasenia) { this.contrasenia = contrasenia; }
        public string getContrasenia() { return this.contrasenia; }
        public void setPerfil(Perfil perfil) { this.perfil = perfil; }
        public Perfil getPerfil() { return this.perfil; }
        public void setFechaAlta(DateTime fecha_alta) { this.fecha_alta = fecha_alta; }
        public DateTime getFechaAlta() { return this.fecha_alta; }
        #endregion

        public Usuario(string nombre,string contrasenia,Perfil perfil,DateTime fecha_alta) 
        { 
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.perfil = perfil;
            this.fecha_alta = fecha_alta;
        }
    }
}
