namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine("Instalando app " + nomeApp + " no dispositvo Iphone");
            System.Console.WriteLine($"Dados do aparelho > Numero: {Numero}");
        }
    }
}