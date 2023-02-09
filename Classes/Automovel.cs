using TreinoHeranca.Classes;
namespace TreinoHeranca.Classes
{
    public  class Automovel
    {
        public Automovel(string placa, string modelo, Combustivel combustivel, string cor , int ano)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
            this.Cor = cor;
            this.Ano = ano;
        }
        public string Placa {get ; protected set ;}
        public string Modelo{ get ; protected set ;}
        public Combustivel Combustivel {get ; protected set ;}
        public string Cor {get ; protected set ; }
        public int Ano {get ; protected set;}
        public virtual double PrecoAutomovel()
        {
            return 12000 * this.Ano;
        }
        
    }

}