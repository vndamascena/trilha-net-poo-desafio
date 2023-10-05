

namespace DesafioPOO
{
    using DesafioPOO.Models;

    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma instância de Iphone
            Iphone iphone = new Iphone("123456", "iPhone 12", "IMEI12345", 64);

            // Chamar o método InstalarAplicativo para o iPhone
            iphone.InstalarAplicativo("Telegram");

            // Criar uma instância de Nokia
            Nokia nokia = new Nokia("789012", "Nokia 3310", "IMEI67890", 16);

            // Chamar o método InstalarAplicativo para o Nokia
            nokia.InstalarAplicativo("WhatsApp");

            // Outras operações com os objetos, se necessário
        }
    }
}
