string age = "";
string name = "";
string areTheDataOk = "";

string namesAbfrage = "Wie ist Ihr Name? : ";
string altersAbfrage = "Wie ist Ihr alter? : ";

const string answerYes = "ja";


// Anfang
Console.WriteLine("Wilkommen zu unserem kleinen Tool!\n");

GetNameAndAgeFromTheUser(out age, out name, out areTheDataOk, namesAbfrage, altersAbfrage);

while (areTheDataOk?.ToLower() != answerYes)  
{
    Console.WriteLine("Bitte geben Sie ihre Daten nochmals ein.\n\n");

    GetNameAndAgeFromTheUser(out age, out name, out areTheDataOk, namesAbfrage, altersAbfrage);
}

Console.WriteLine("Ihre Eingaben wurden gespeichert und Sie können das Fenster nun schließen...");
Console.ReadLine();
// ENDE

static void GetNameAndAgeFromTheUser(out string age, out string name, out string areTheDataOk, string namesAbfrage, string altersAbfrage)
{
    Console.WriteLine(namesAbfrage);
    name = Console.ReadLine(); 

    Console.WriteLine(altersAbfrage);
    age = Console.ReadLine();

    Console.WriteLine($"Ist ihr Name? {name}  Ist Ihr Alter? {age} , sind diese Daten richtig? \n\n Bitte mit Ja und Nein beantworten!");
    areTheDataOk =  Console.ReadLine();
}
