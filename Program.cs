using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("980843591", "Nokia Tijolão", "86153603019", 128 );
Iphone i1 = new Iphone("980843592", "Iphone 15", "861536030196", 900 );
i1.Ligar();
n1.Ligar();
n1.ReceberLigacao();
i1.ReceberLigacao();
n1.InstalarAplicativo("Subway Surfers");
i1.InstalarAplicativo("Facebook");