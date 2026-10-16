using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace WestcoastEducation;

public class Menu : Lärare
{
        public void RunMenu()
        {
                try
                {
                        while (true)
                        {
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Välkommen till Westcoast Education");
                                Console.WriteLine("1. Administratör.");
                                Console.WriteLine("2. Studerande.");
                                Console.WriteLine("X. Stäng av programmet.");
                                var key = Console.ReadLine();

                                switch (key)
                                {
                                        case var exit when key == "x":
                                                Console.WriteLine("Programmet stängs av...");
                                                Thread.Sleep(2000);
                                                Environment.Exit(0);
                                                break;

                                        case "1":
                                                var administratör = new Administratörer();
                                                Console.Clear();
                                                Console.WriteLine("Ange administratörlösenord:");
                                                var adminInput = Console.ReadLine();

                                                if (adminInput != administratör.Password)
                                                {
                                                        Console.WriteLine("Fel lösenord.");
                                                        MenuPause();
                                                        continue;
                                                }

                                                else

                                                        Console.Clear();
                                                Console.WriteLine("----------------------------------------------");
                                                Console.WriteLine("Välkommen till Westcoast Education");
                                                Console.WriteLine("Du är inloggad som administratör.");
                                                Console.WriteLine("1. Lägg till lärare.");
                                                Console.WriteLine("2. Visa lärare.");
                                                Console.WriteLine("3. Lägg till student.");
                                                Console.WriteLine("4. Visa studenter.");
                                                Console.WriteLine("5. Lägg till kurs.");
                                                Console.WriteLine("6. Visa kurser.");
                                                Console.WriteLine("7. Lägg till Utbildningsledare");
                                                Console.WriteLine("8. Visa Utbildningsledare");
                                                Console.WriteLine("x. Avsluta programmet.");
                                                Console.WriteLine("----------------------------------------------");

                                                var adminVal = Console.ReadLine();
                                                switch (adminVal)
                                                {
                                                        case "1":
                                                                AddTeacher();
                                                                Console.WriteLine("Läraren har lagts till.");
                                                                break;

                                                        case "2":
                                                                DisplayTeacher();
                                                                break;
                                                        case "3":

                                                                break;
                                                        case "4":
                                                                DisplayStudent();
                                                                break;
                                                        case "5":
                                                                Kurser.AddCourse();
                                                                break;
                                                        case "6":
                                                                Kurser.DisplayCourses();
                                                                break;
                                                        case "7":
                                                                Utbildningsledare.AddUtbildningsledare();
                                                                break;
                                                        case "8":
                                                                Utbildningsledare.DisplayUtbildningsledare();
                                                                break;

                                                }
                                                MenuPause();
                                                continue;


                                        case "2":
                                                Console.Clear();
                                                Console.WriteLine("----------------------------------------------");
                                                Console.WriteLine("Välkommen till Westcoast Education");
                                                Console.WriteLine("Du är inloggad som student.");
                                                Console.WriteLine("1. Visa Lärare.");
                                                Console.WriteLine("2. Visa studenter.");
                                                Console.WriteLine("3. Visa kurser.");
                                                Console.WriteLine("x. Avsluta programmet.");
                                                Console.WriteLine("----------------------------------------------");

                                                var studentVal = Console.ReadLine();
                                                switch (studentVal)

                                                {
                                                        case "1":
                                                                DisplayTeacher();
                                                                break;
                                                        case "2":
                                                                DisplayStudent();
                                                                break;
                                                        case "3":
                                                                Kurser.DisplayCourses();
                                                                break;
                                                }
                                                MenuPause();
                                                continue;
                                }



                                key = Console.ReadLine();

                                switch (key)
                                {
                                        //Stänga av programmet "x"
                                        case "x":
                                                Console.WriteLine("Programmet stängs av...");
                                                Thread.Sleep(2000);
                                                Environment.Exit(0);
                                                break;
                                }
                        }

                }
                catch (Exception ex)
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine(ex.Message);
                        System.Console.WriteLine("Försök igen");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        MenuPause();
                }
        }

        private static string Input(string input)
        {
                Console.Write($"{input}: ");
                return Console.ReadLine()
                        ?? throw new Exception("Ingen inmatning kunde läsas.");
        }
        public static void MenuPause()
        {
                Console.WriteLine("Tryck på en knapp för att fortsätta....");
                Console.ReadLine();
        }
}
