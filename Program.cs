using TreinoHeranca.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Automovel automovel = new AutomovelLuxo
        (
            placa: "FXR9915",
            modelo: "Mercedes",
            combustivel: Combustivel.Gasolina,
            cor: "Azul",
            ano: 2
        );
        Console.Write(automovel.PrecoAutomovel());
    }
}