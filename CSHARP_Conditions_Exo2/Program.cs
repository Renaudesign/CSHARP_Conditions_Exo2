using System;

namespace CSHARP_Conditions_Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour sujet n°2 035 654. Veuillez nous indiquer vôtre âge en nombre de cycles solaires terrestres standard.");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"Sujet n°2 035 654, vous avez {age} ans. Vous êtes donc majeur, veuillez vous orienter vers le service des assignations professionelles.");
            }
            else
            {
                Console.WriteLine($"Sujet n°2 035 654, vous avez {age} ans. Vous n'êtes donc pas majeur, veuillez retourner dans votre cycle de formation.");
            };

        }
    }
}
