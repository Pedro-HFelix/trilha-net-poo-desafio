using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Nokia tijolão", "123456789", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();
System.Console.WriteLine("----------");

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("123456789", "Iphone 13", "123456789", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();