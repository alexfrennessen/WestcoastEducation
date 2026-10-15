using Microsoft.VisualBasic;

namespace WestcoastEducation;

public class Kurser
{
    private static readonly List<Kurser> kursLista = [

        //Exempel kurs
      new Kurser
    {
        Kursnummer = 1001,
        Title = "Programmering 1 C#",
        Utbildningstyp = UtbildningstypEnum.Distans,
        Startdatum = new DateOnly(2026,01,01),
        Slutdatum = new DateOnly(2026,10,10)
    }

    ];
    public required int Kursnummer { get; set; }
    public required string Title { get; set; }
    public required UtbildningstypEnum Utbildningstyp { get; set; }

    public int Längd => (Slutdatum.DayNumber - Startdatum.DayNumber) / 7;
    public DateOnly Startdatum { get; set; }
    public DateOnly Slutdatum { get; set; }

    public static void AddCourse()
    {
        Console.Write("Kurstitel: ");
        var title = Console.ReadLine()
            ?? throw new InvalidOperationException("Ingen inmatning kunde läsas.");

        Console.WriteLine("Välj utbildningstyp:");
        Console.WriteLine("1. Distans");
        Console.WriteLine("2. Klassrum");

        UtbildningstypEnum utbildningstyp;

        while (true)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    utbildningstyp = UtbildningstypEnum.Distans;
                    break;
                case "2":
                    utbildningstyp = UtbildningstypEnum.Klassrum;
                    break;
                default:
                    Console.Write("Ogiltigt val. Skriv 1 eller 2: ");
                    continue;
            }

            break;
        }

        var nyKurs = new Kurser
        {
            Kursnummer = kursLista.Count + 1001,
            Title = title,
            Utbildningstyp = utbildningstyp,
            Startdatum = new DateOnly(2026, 1, 1),
            Slutdatum = new DateOnly(2026, 10, 10)
        };

        kursLista.Add(nyKurs);
    }
    private static string Input(string fråga)
    {
        Console.Write($"{fråga}: ");
        return Console.ReadLine()
            ?? throw new InvalidOperationException("Ingen inmatning kunde läsas.");
    }
    public static void DisplayCourses()
    {
        foreach (Kurser kurs in kursLista)
        {
            Console.WriteLine($"Kursnummer: {kurs.Kursnummer} | Kurs: " +
            $"{kurs.Title} | Kurslängd i veckor: {kurs.Längd} | Startdatum: " +
            $"{kurs.Startdatum} | Slutdatum:{kurs.Slutdatum} | Utbildningstyp: {kurs.Utbildningstyp}");
        }
    }
}

