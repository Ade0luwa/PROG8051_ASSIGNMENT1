class Program
{
    public static void Main(string[] args)
    {
        string animal1 = "Dog";
        string animal2 = "Cat";
        string animal3 = "Rabbit";
        Console.WriteLine("Welcome to Adeoluwatomiwa Pet Simulator");
        Console.WriteLine("It is good to have you here");
        Console.WriteLine("Please select the kind of pet you want from the options provided below");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Rabbit");
        int petSelected = Convert.ToInt32(Console.ReadLine()); // this collects the input string from the user and converts to an integer

        switch (petSelected) // switch case statement to handle the pet type selected by the user
        {
            case 1:
                Console.WriteLine($"What a great choice!! You have selected {animal1} as the pet type");
                break;

            case 2:
                Console.WriteLine($"What a great choice!! You have selected {animal2} as the pet type");
                break;

            case 3:
                Console.WriteLine($"What a great choice!! You have selected {animal3} as the pet type");
                break;

            default:
                Console.WriteLine("Please select a correct option");
                break;
        }
        

           
        }

    }