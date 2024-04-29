using DesafioPOO.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine($"Criando novo Nokia");
 Nokia nokia = new Nokia("1234","NGage","123456789",128);
Console.WriteLine($"Numero:{nokia.Numero}");
Console.WriteLine($"Modelo:{nokia.Modelo}");
Console.WriteLine($"IMEI:{nokia.IMEI}");
Console.WriteLine($"Memória:{nokia.Memoria}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("ZAP");


Console.WriteLine($"Criando novo iPhone");
 Iphone iphone = new Iphone("12345","15","12345678910",256);
Console.WriteLine($"Numero:{iphone.Numero}");
Console.WriteLine($"Modelo:{iphone.Modelo}");
Console.WriteLine($"IMEI:{iphone.IMEI}");
Console.WriteLine($"Memória:{iphone.Memoria}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ZAP");