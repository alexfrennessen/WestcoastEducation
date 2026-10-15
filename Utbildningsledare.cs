namespace WestcoastEducation;

public class Utbildningsledare : Lärare
{
    public DateOnly EmploymentDate { get; set; }
    private static readonly List<Utbildningsledare> utbildningsledareLista = [
        
    //Exempel Utbildningsledare
        new Utbildningsledare
        {
        FirstName = "Kristian",
        LastName = "Svensson",
        Expertise = "Grekiska",
        Email = "kristiansvensson@skolmail.se",
        PhoneNumber = "07065593213",
        Address = "Lärargatan 15",
        PostalCode = "218 91",
        City = "Lärarstaden",
        PersonalNumber = "8761231913",
        EmploymentDate = new DateOnly(2002,04,15)
        }
    ];

    public static void AddUtbildningsledare()
    {
        var nyUtbildningsledare = new Utbildningsledare
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

        utbildningsledareLista.Add(nyUtbildningsledare);
    }
    private static string Input(string fråga)
    {
        Console.Write($"{fråga}: ");
        return Console.ReadLine()
            ?? throw new InvalidOperationException("Ingen inmatning kunde läsas.");
    }
    public static void DisplayUtbildningsledare()
    {
        foreach (Utbildningsledare utbildningsledare in utbildningsledareLista)
        {
            Console.WriteLine(
                $"Namn: {utbildningsledare.FirstName} {utbildningsledare.LastName} | Ämne: " +
                $"{utbildningsledare.Expertise} | Email: {utbildningsledare.Email} | Telefon: " +
                $"{utbildningsledare.PhoneNumber}| Anställningsdatum: {utbildningsledare.EmploymentDate}");
        }
    }
}
