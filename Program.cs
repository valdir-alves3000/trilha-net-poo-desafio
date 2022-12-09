using DesafioPOO.Models;


Nokia nokiaC01 = new Nokia(numero: "11999999999", imei: "2022101520", modelo: "C01 Plus", memoria: 64);

Nokia nokiaC20 = new Nokia(numero: "11999999999", imei: "2022101520", modelo: "C20", memoria: 64);

Iphone iphone11 = new Iphone(numero: "11999999999", imei: "2022112040", modelo: "iphone 11", memoria: 128);

Iphone iphone13 = new Iphone(numero: "11999999999", imei: "2022112040", modelo: "iphone 13", memoria: 128);

nokiaC01.GetSmartphone();
nokiaC01.Ligar();
nokiaC01.InstalarAplicativo("WhatsApp");

nokiaC20.GetSmartphone();
nokiaC20.ReceberLigacao();
nokiaC20.InstalarAplicativo("Linkedin");

iphone11.GetSmartphone();
iphone11.ReceberLigacao();
iphone11.InstalarAplicativo("dio.me");

iphone13.GetSmartphone();
iphone13.ReceberLigacao();
iphone13.InstalarAplicativo("Facebook");