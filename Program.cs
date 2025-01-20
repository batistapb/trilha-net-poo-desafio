using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "99311343", modelo: "modelo 1", imei: "111111", memoria: 64) ;
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "8899123", modelo: "modelo 2", imei: "222222", memoria: 320);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");


// TODO: Realizar os testes com as classes Nokia e Iphone