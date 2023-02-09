namespace TreinoHeranca.Classes
{
    public  class AutomovelLuxo : Automovel
    {
        public AutomovelLuxo
        (
            string placa
            , string modelo
            , Combustivel combustivel
            , string cor 
            , int ano
        )
        :
        base
        (
            placa,
            modelo,
            combustivel,
            cor,
            ano
        )
        {

        }
        public override double PrecoAutomovel()
        {
            return (12000 * this.Ano) + 2000 + 1500 + 800;
        }
    }
}