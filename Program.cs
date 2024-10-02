namespace T5__Assignment_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Topic 5 assingment question 1



            double earthWeight;
            double spaceWeight;
            string planet;
            Console.WriteLine("Please enter your current earth weight.");
            earthWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I have information for the following planets");
            Console.WriteLine("1. Venus  2. Mars  3. Jupiter  4. Saturn  5. Uranus  6. Neptune");
            Console.WriteLine(" Which planet are you visiting");
            planet = Console.ReadLine().ToLower();


            if (planet == "1" || planet == "venus")
            {
                spaceWeight = earthWeight * 0.7;
                Console.WriteLine("Your weight on venus is " + spaceWeight + " lbs");
            }
            else if (planet == "2" || planet == "mars")
            {
                spaceWeight = earthWeight * 0.39;
                Console.WriteLine(" Your weight on mars is " + spaceWeight + " lbs");
            }
            else if (planet == "3" || planet == "jupiter")
            {
                spaceWeight = earthWeight * 2.65;
                Console.WriteLine("Your weight on jupiter is " + spaceWeight + " lbs");
            }
            else if (planet == "4" || planet == "saturn")
            {
                spaceWeight = earthWeight * 1.17;
                Console.WriteLine("Your weight on saturn is " + spaceWeight + " lbs");
            }
            else if (planet == "5" || planet == "uranus")
            {
                spaceWeight = earthWeight * 1.05;
                Console.WriteLine("Your weight on saturn is " + spaceWeight + " lbs");
            }
            else if (planet == "6" || planet == "neptune")
            {
                spaceWeight = earthWeight * 1.23;
                Console.WriteLine("Your weight on neptune is " + spaceWeight + " lbs");
            }
            else
            {
                Console.WriteLine("You dont fight on that planet");
            }







        }
    }
}
