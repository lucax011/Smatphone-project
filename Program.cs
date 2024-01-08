using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        // Testes
        Smartphone iphone = new Iphonec("123456789", "iPhone X", "ABC123", 64);
        iphone.InstalarAplicativo("WhatsApp");

        Smartphone nokia = new Nokia("987654321", "Nokia 3310", "XYZ789", 8);
        nokia.InstalarAplicativo("Snake");
    }
}