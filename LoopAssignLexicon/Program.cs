namespace LoopAssignLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool runProgram = true;
            int choice;

            while (runProgram)
            {
                Console.WriteLine("Välkommen till menyn, här navigerar du via ett antal nummer. \n För att se priser baserat på ålder, tryck 1 \n För att räkna ut pris för en större grupp, tryck 2 \n För att skirva ut nån text 10 gånger av nån anledning, tryck 3 \n För att plocka ut tredje ordet i en mening, tryck 4 \n För att avsluta programmet, tryck 0");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        runProgram = false;
                        break;
                    case 1:
                        Console.WriteLine("Var god ange ålder:");
                        string ageInput = Console.ReadLine();
                        int age = int.Parse(ageInput);

                        Prices(age);

                        break;
                    case 2:
                        Console.WriteLine("Hur många personer?");
                        int people = int.Parse(Console.ReadLine());
                        int[] listOfPeople = new int[people];

                        CalculateTotalCost(people, listOfPeople);

                        break;
                    case 3:
                        Console.WriteLine("Skriv nån random text:");
                        string text = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(i + 1 + " " + text + " ");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Skriv nån random mening med minst 3 ord:");
                        var sentence = Console.ReadLine();
                        string[] words = sentence.Split(" ");
                        if (words.Length > 2)
                        {
                            Console.WriteLine("Det tredje ordet är " + words[2]);
                        }
                        else
                        {
                            Console.WriteLine("Minst 3 ord tack");
                        }
                        break;
                    default:
                        Console.WriteLine("Detta val finns ej, var vänlig försök igen");
                        break;
                }
            }
        }
        static void Prices(int age)
        {
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80:-");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90:-");
            }
            else
            {
                Console.WriteLine("Standardpris: 120:-");
            }
        }
        static void CalculateTotalCost(int people, int[] ageOfPeople)
        {
            int totalPrice = 0;
            for (int i = 0; i < people; i++)
            {
                Console.WriteLine("Ange ålder för person " + (i + 1));
                ageOfPeople[i] = int.Parse(Console.ReadLine());

                if (ageOfPeople[i] < 20)
                {
                    totalPrice += 80;
                }
                else if (ageOfPeople[i] > 64)
                {
                    totalPrice += 90;
                }
                else
                {
                    totalPrice += 120;
                }
            }
            Console.WriteLine("För " + people + " personer kommer totalkostnaden för sällskapet bli " + totalPrice + ":-");
        }
    }
}
