// See https://aka.ms/new-console-template for more information
using poo_desafio_cel;

Console.WriteLine("Testando app desafio smartphone.");

Nokia nokia = new Nokia("1298989-8989", "N95", "12121212", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");



Iphone iphone = new Iphone("1295858-5757", "X", "5454547", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Messenger");


