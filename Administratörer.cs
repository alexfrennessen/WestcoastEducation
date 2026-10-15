using Microsoft.VisualBasic;

namespace WestcoastEducation;

public class Administratörer : Utbildningsledare
{

    public string Password {get; } = "admin123";
    List<Administratörer> administratörLista = [];    

}
