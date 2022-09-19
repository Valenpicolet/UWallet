namespace Pav.Entidades
{
    public class Perfil
    {
        #region Atributos
        private string descripcion;
        #endregion

        #region Accesores
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public string getDescripcion() { return this.descripcion; }
        #endregion

        public Perfil(string descripcion) 
        { 
            this.descripcion = descripcion; 
        }

    }
}
