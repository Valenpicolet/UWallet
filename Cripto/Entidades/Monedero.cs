namespace Pav.Entidades
{
    public class Monedero
    {
        #region Atributos
        private Usuario usuario;
        private Criptomoneda cripto;
        private int saldo;
        #endregion

        #region Accesores
        public void setIdUsuario(Usuario usuario) { this.usuario = usuario; }
        public Usuario getIdUsuario() { return this.usuario; }   
        public void setIdCripto(Criptomoneda cripto) { this.cripto = cripto; }
        public Criptomoneda getIdCripto() { return this.cripto; }
        public void setSaldo(int monto) { this.saldo = saldo; }
        public int getSaldo() { return this.saldo; }
        #endregion

        public Monedero(Usuario usuario, Criptomoneda cripto, int saldo)
        {
            this.usuario = usuario;
            this.cripto = cripto;
            this.saldo = 0;
        }
    }
}
