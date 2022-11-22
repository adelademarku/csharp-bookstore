// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

//Bonus  chiedere le informazioni del libro direttamente all’utente tramite l’input della console.

using Microsoft.VisualBasic;

Console.Write("Inserisci il titolo: ");
string titoloDelLibro = (Console.ReadLine());
Console.Write("Inserisci il nome del autore : ");
string autoreDelLibro = (Console.ReadLine());
Console.Write("Inserisci  isbn 10: ");
long isbn = long.Parse(Console.ReadLine());
Console.Write("Inserisci isbn 13: ");
long isbn2 = long.Parse(Console.ReadLine());
Console.Write("Inserisci il numero delle pagine: ");
int numeroPagine = int.Parse(Console.ReadLine());
Console.Write("Inserisci il peso del libro: ");
int pesoLibro = int.Parse(Console.ReadLine());
Console.Write("Inserisci la larghezza : "); 
float dimensioniLarghezza = float.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza: ");
float dimensioniAltezza = float.Parse(Console.ReadLine());
Console.Write("Inserisci la profondità: ");
float dimensioniProfondita = float.Parse(Console.ReadLine());

var dimensioniLibro = dimensioniLarghezza + "cm x " + dimensioniAltezza + "cm x " + dimensioniProfondita + "cm";

Console.Write("Inserisci la valutazione media: ");
float valutazioneMedia = float.Parse(Console.ReadLine());

Console.Write("Inserisci il numero delle recenzioni: ");
int numeroRecensioni = int.Parse(Console.ReadLine());

Console.Write("Inserisci Si" +
    " se c'è la versione kindle" +
    " o " +
    "No" +
    " se manca:  ");
var versioneKindle = (Console.ReadLine());

Console.Write("Inserisci Si " +
    "se c'è la copertina flessibile" +
    " o" +
    " No" +
    " se manca:  ");

var copertinaFlessibile = (Console.ReadLine());









Console.WriteLine("Il libro di oggi : " + titoloDelLibro + " di " + autoreDelLibro + "\n"
    + "Informazioni generiche : " + "\n"
    + "ISBN 10 : " + isbn + "\n"
    + "ISBN 13 : " + isbn2 + "\n"
    + "Numero delle pagine: " + numeroPagine + " pagine" + "\n"
    + "Peso del libro: " + pesoLibro + " kg" + "\n"
    + "Dimensioni del libro " + dimensioniLibro + "\n"
    + "\n" + "\n"
    + "Informazioni Amazon:" + "\n"
    + "Numero di recensioni: " + numeroRecensioni + " recensioni" + "\n"
    + "Valutazione media: " + valutazioneMedia + " stelline" + "\n"
    + "Kindle disponibilita: " + versioneKindle + "\n"
    + "Copertina flessibile disponibile: " + copertinaFlessibile);


