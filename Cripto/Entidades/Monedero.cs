namespace Pav.Entidades
{
    public class Monedero
    {
        #region Atributos
        private Usuario usuario;
        private Criptomoneda cripto;
        private int monto;
        #endregion

        #region Accesores
        public void setIdUsuario(Usuario usuario) { this.usuario = usuario; }
        public Usuario getIdUsuario() { return this.usuario; }   
        public void setIdCripto(Criptomoneda cripto) { this.cripto = cripto; }
        public Criptomoneda getIdCripto() { return this.cripto; }
        public void setMonto(int monto) { this.monto = monto; }
        public int getMonto() { return this.monto; }
        #endregion

        public Monedero(Usuario usuario, Criptomoneda cripto)
        {
            this.usuario = usuario;
            this.cripto = cripto;
            this.monto = 0;
        }
    }
}
