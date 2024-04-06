// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

System.Console.WriteLine("digite la longitud deseada para su contraseña"); //WORD1
string longitud = Console.ReadLine()!;
int laar =  Convert.ToInt32(longitud);
Guid miGuid = Guid.NewGuid(); //esta linea se encarga de generar un identificador unico en el mundo (token) 
string token = miGuid.ToString().Replace("-", "#"+"*"+"$"+"@").Substring(0, laar);
System.Console.WriteLine("Su contraseña es: " + token);
