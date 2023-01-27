using System;
namespace Inlämning5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] responses = {
            "Ja", "Nej", "Kanske", "Försök igen senare", "Svårt att säga",
            "Definitivt", "Absolut inte", "Sannolikt", "Mycket osannolikt", "Fråga mig inte igen" };

            Random rand = new Random();

            while (true)
            {
                Console.WriteLine("Ställ din fråga eller skriv 'a' för att avsluta:");
                string question = Console.ReadLine();

                if (question == "a")
                {
                    break;
                }

                int index = rand.Next(responses.Length);
                Console.WriteLine(responses[index]);
            }
        }
    }
}