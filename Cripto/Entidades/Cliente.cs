namespace Pav.Entidades
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string email;
        private int telefono;
        private Ciudad ciudad;
        private Usuario usuario;
        #endregion

        #region Accesores
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return this.nombre; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public string getApellido() { return this.apellido; }
        public void setEmail(string email) { this.email = email; }
        public string getEmail() { return this.email; }
        public void setTelefono(int telefono) { this.telefono = telefono; }
        public int getTelefono() { return telefono; }
        public void setCiudad(Ciudad ciudad) { this.ciudad = ciudad; }
        public Ciudad getIdCiudad() { return ciudad; }
        public void setIdUsuario(Usuario usuario) { this.usuario = usuario; }
        public Usuario getIdUsuario() { return usuario; }
        #endregion  

        public Cliente(string nombre,string apellido,string email,int telefono,Ciudad ciudad, Usuario usuario) 
        { 
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.ciudad = ciudad;
            this.usuario = usuario;
        }
    }

}
