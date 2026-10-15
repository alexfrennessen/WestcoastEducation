namespace WestcoastEducation;

public class Studerande : Person
{
    private static List<Studerande> studerandeLista = [
                   //Exempel student
                   new Studerande
        {
        FirstName = "Alex",
        LastName = "Student",
        Email = "alexstudent@skolmail.se",
        PhoneNumber = "0709987654",
        Address = "Studentgatan 1",
        PostalCode = "456 12",
        City = "Studentstaden 1",
        PersonalNumber = "987654312"
        }
    ];


    public void AddTeacher(Studerande studerande)
    {
        studerandeLista.Add(studerande);
    }
    public void DisplayStudent()
    {
        foreach (Studerande studerande in studerandeLista)
        {
            Console.WriteLine(
                $"Namn: {studerande.FirstName} {studerande.LastName} | Ämne: " +
                $"| Email: {studerande.Email} | Telefon: " +
                $"{studerande.PhoneNumber}");
        }
    }
}
