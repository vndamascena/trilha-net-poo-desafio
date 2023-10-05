

namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização específica para a classe Nokia pode ser feita aqui
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string WhatsApp)
        {
            Console.WriteLine($"Instalando o aplicativo {WhatsApp} em um Nokia...");
            // Lógica para instalar o aplicativo em um Nokia
        }
    }
}
