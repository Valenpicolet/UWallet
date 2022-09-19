namespace Pav.Entidades
{
    public class Ciudad
    {
        #region Atributos
        private string nombre;
        private Pais pais;
        #endregion

        #region Accesores
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public Pais getPais() { return pais; }
        public void setPais(Pais pais) { this.pais = pais; }
        #endregion

        public Ciudad(string nombre, Pais pais) 
        { 
            this.nombre = nombre;
            this.pais = pais;
        }
    }

    


}
