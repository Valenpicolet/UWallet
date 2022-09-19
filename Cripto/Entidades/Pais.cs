namespace Pav.Entidades
{
    public class Pais
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Accesores
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return nombre; }
        #endregion

        public Pais(string nombre) 
        { 
            this.nombre = nombre; 
        }    
    }
}
