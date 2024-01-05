#region variables and constants -> Gruppierung

string age = string.Empty; // ist für mich besser lesbar (aber nicht zwingend!) als "" - denn es kann schnell ein Leerzeichen reinrutschen => sting xy = " ";
string name = string.Empty;
string areTheDataOk = string.Empty;

const string namesAbfrage = "Wie ist Ihr Name? : "; // ich möchte nicht, dass das irgendwo im code abgeandert wird => CONST
const string altersAbfrage = "Wie ist Ihr alter? : ";
const string welcomeMessage = "Wilkommen zu unserem kleinen Tool!\n";
const string endMessage = "\n\nIhre Eingaben wurden gespeichert und Sie können das Fenster nun schließen...";
const string yes = "ja";

#endregion

Console.WriteLine(welcomeMessage);

GetNameAndAgeFromUser(out age, out name, out areTheDataOk, namesAbfrage, altersAbfrage);

while (areTheDataOk.ToLower() != yes) // dann ist die Antwort immer "ja"  egal ob JA, Ja oder jA // das Tool soll so lange laufen bis die Antwort ja ist
{
    Console.WriteLine("Bitte geben Sie ihre Daten nochmals ein.\n\n");
    GetNameAndAgeFromUser(out age, out name, out areTheDataOk, namesAbfrage, altersAbfrage);
}

Console.WriteLine(endMessage);
Console.ReadLine(); // sonst schließt sich das Fenster automatisch - wir wollen, dass die letzte Zeile sichtbar bleibt und das Fenster nicht automatisch geschlossen wird.

static void GetNameAndAgeFromUser(out string age, out string name, out string areTheDataOk, string namesAbfrage, string altersAbfrage)
{
    Console.WriteLine(namesAbfrage);
    name = Console.ReadLine();

    Console.WriteLine(altersAbfrage);
    age = Console.ReadLine();

    Console.WriteLine($"\n\nIst ihr Name => {name}  und Ihr Alter => {age} korrekt erfasst? \n\n => Bitte mit 'Ja' bzw. 'Nein' beantworten!\n\n");
    areTheDataOk = Console.ReadLine();
} // den doppelten Code nur einmal geschrieben und 2x verwendet. Vorteil - wenn etwas geaendert werden muss, dann muss das nur hier geaendert werden. Also in der METHODE
