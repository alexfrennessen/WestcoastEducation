using System;
namespace WestcoastEducation;

public class Lärare : Studerande
{
    private static List<Lärare> lärareLista = [

        //Exempel lärare
        new Lärare
        {
        FirstName = "Anette",
        LastName = "Hallengren",
        Expertise = "Florist",
        Email = "anettes@skolmail.se",
        PhoneNumber = "0709123456",
        Address = "Lärargatan 1",
        PostalCode = "123 45",
        City = "Lärarstaden",
        PersonalNumber = "123456789"
        }
    ];
    public List<Kurser> AnsvarigaKurser { get; } = [];

    public void TilldelaKurs(Kurser kurs)
    {
        if (!AnsvarigaKurser.Contains(kurs))
        {
            AnsvarigaKurser.Add(kurs);
        }
    }
    public string? Expertise { get; set; }


    public void AddTeacher()
    {
        var nyLärare = new Lärare
        {
            FirstName = Input("Förnamn"),
            LastName = Input("Efternamn"),
            PersonalNumber = Input("Personnummer"),
            Expertise = Input("Ämne"),
            Email = Input("E-post"),
            PhoneNumber = Input("Telefonnummer"),
            Address = Input("Adress"),
            PostalCode = Input("Postnummer"),
            City = Input("Ort")
        };

        lärareLista.Add(nyLärare);
    }

    private static string Input(string fråga)
    {
        Console.Write($"{fråga}: ");
        return Console.ReadLine()
            ?? throw new InvalidOperationException("Ingen inmatning kunde läsas.");
    }

    public void DisplayTeacher()
    {
        foreach (Lärare lärare in lärareLista)
        {
            Console.WriteLine(
                $"Namn: {lärare.FirstName} {lärare.LastName} | Ämne: " +
                $"{lärare.Expertise} | Email: {lärare.Email} | Telefon: " +
                $"{lärare.PhoneNumber}");
        }
    }
}