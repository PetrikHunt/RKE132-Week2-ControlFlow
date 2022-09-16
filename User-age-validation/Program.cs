// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutaja sugu (m/f)
//rakendus küsib kasutaja perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please select yout gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please enter your last name");

string userName = Console.ReadLine();
if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userName}!");
}
else
{
    Console.WriteLine($"Welcome, {userName}!");
}