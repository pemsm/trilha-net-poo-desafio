using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia_x30 = new Nokia(numero: "8195554444", modelo: "Nokia X30", imei: "353612652099685", memoria: 64);
nokia_x30.Ligar();
nokia_x30.ReceberLigacao();
nokia_x30.InstalarAplicativo("Google Authenticator");
Console.WriteLine("\n");
nokia_x30.Especificacoes();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone_15ProMax = new Iphone(numero: "81988884444", modelo: "iPhone 15 Pro Max", imei: "356303483762819", memoria: 128);
iphone_15ProMax.Ligar();
iphone_15ProMax.ReceberLigacao();
iphone_15ProMax.InstalarAplicativo("Instagram");
iphone_15ProMax.InstalarAplicativo("Telegram");
Console.WriteLine("\n");
iphone_15ProMax.Especificacoes();


