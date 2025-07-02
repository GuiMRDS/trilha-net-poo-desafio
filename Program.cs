using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123", modelo:"Modelo Nokia Tijolao", imei: "111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654", modelo:"Modelo Iphone 12 mini", imei: "222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");