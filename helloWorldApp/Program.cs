string age = "";
string name = "";
string areTheDataOk = "";


string namesAbfrage = "Wie ist Ihr Name? : ";
string altersAbfrage = "Wie ist Ihr alter? : ";

Console.WriteLine("Wilkommen zu unserem kleinen Tool!\n");

Console.WriteLine(namesAbfrage);
name = Console.ReadLine(); 

Console.WriteLine(altersAbfrage);
age = Console.ReadLine();

Console.WriteLine(age);

Console.WriteLine($"Ist ihr Name? {name}  Ist Ihr Alter? {age} , sind diese Daten richtig? \n\n Bitte mit Ja und Nein beantworten!");
areTheDataOk =  Console.ReadLine();


if(areTheDataOk == "Ja") 
{
    Console.WriteLine("Ihre Eingaben wurden gespeichert und Sie können das Fenster nun schließen...");
}
else
{
    Console.WriteLine("Bitte geben Sie ihre Daten nochmals ein.\n\n");

    Console.WriteLine(namesAbfrage);
    name = Console.ReadLine(); 

    Console.WriteLine(altersAbfrage);
    age = Console.ReadLine();

    Console.WriteLine(age);

    Console.WriteLine($"Ist ihr Name? {name}  Ist Ihr Alter? {age} , sind diese Daten richtig? \n\n Bitte mit Ja und Nein beantworten!");
    areTheDataOk =  Console.ReadLine();

}






// TODO - logical Operaters anschauen
// TODO - refactor - doppelter code
// TODO - wieder zur Abfrage zurück // nach dem else-zweig