using System.Formats.Asn1;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("12315-53453", "XLS-3200" , "453453N45K3JN45K3N345", 4) ; 
Iphone i1 = new Iphone ("423423-423423" , "Iphone 13" , "2342n3kj4n2knn5", 6) ;

n1.InstalarAplicativo("Whatsapp");
i1.InstalarAplicativo("Telegram") ; 

