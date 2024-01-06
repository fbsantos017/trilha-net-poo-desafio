using DesafioPOO.Models;


// limpar console
Console.Clear();

Console.WriteLine("Smartphone nokia:");

Smartphone nokia = new Nokia("00000-0000", "Nokia", "909090909090", 64);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

// Espacamento no console
Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");

Smartphone iphone = new Iphone("11111-1111", "Apple", "707070707070", 32);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");