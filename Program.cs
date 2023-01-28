using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111112221", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("");
System.Console.WriteLine("");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "789101", modelo: "Modelo 2", imei: "222222221", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
