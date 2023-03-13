// See https://aka.ms/new-console-template for more information
Console.WriteLine("Problema con los códigos postales");
string cpMadrid = "28002";
short.TryParse(cpMadrid, out var postalCodeMadrid);
Console.WriteLine("El valor del código postal de Madrid es: "+postalCodeMadrid);


string cpSevilla = "41011";
short.TryParse(cpSevilla, out var postalCodeServilla);
Console.WriteLine("El valor del código postal de Sevilla es: "+postalCodeServilla);