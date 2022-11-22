// See https://aka.ms/new-console-template for more information

string titoloDelLibro = "Clean Code";

string autoreDelLibro = "Robert C. Martin";
long isbn = 9780132350884;
long isbn2 = 978 - 0132350884;

int numeroPagine = 431;
int pesoLibro = 800;
float dimensioniLarghezza = 17.78F ;
float dimensioniAltezza = 2.79F;
float dimensioniProfondita = 23.37F;

var dimensioniLibro = dimensioniLarghezza + "cm x " + dimensioniAltezza + "cm x " + dimensioniProfondita + "cm";

float valutazioneMedia = 4.7F;

int numeroRecensioni = 4571;

bool versioneKindle = true;

bool copertinaFlessibile = true;









Console.WriteLine("Il libro di oggi : " + titoloDelLibro + "di" + autoreDelLibro + "\n"
    + "Informazioni generiche : " + "\n"
    + "ISBN 10 : " + isbn + "\n"
    + "ISBN 13 : " + isbn2 + "\n" 
    + "Numero delle pagine: " + numeroPagine + " pagine" + "\n"
    + "Peso del libro: " + pesoLibro + " kg" + "\n"
    + "Dimensioni del libro "+ dimensioniLibro + "\n"
    + "\n" + "\n" 
    + "Informazioni Amazon:" + "\n"
    + "Numero di recensioni: " + numeroRecensioni + " recensioni" + "\n"
    + "Valutazione media: " + valutazioneMedia + " stelline" + "\n"
    + "Kindle disponibilita: " + versioneKindle + "\n" 
    + "Copertina flessibile disponibile: "+ copertinaFlessibile);


