
namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização específica para a classe Iphone pode ser feita aqui
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string Telegram)
        {
            Console.WriteLine($"Instalando o aplicativo {Telegram} em um iPhone...");
            // Lógica para instalar o aplicativo em um iPhone
        }
    }
}
