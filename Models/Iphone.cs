namespace DesafioPOO.Models
{
    public class Iphonec : Smartphone
    {
        // Chamando o construtor da classe base
        public Iphonec(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone.");
        }
    }
}