class Program
{
    public static void Main(string[] args)
    {
        string animal1 = "Dog";
        string animal2 = "Cat";
        string animal3 = "Rabbit";
        string petName;

        Console.WriteLine("Welcome to Adeoluwatomiwa Pet Simulator");
        Console.WriteLine("It is good to have you here");
        Console.WriteLine("Please select the kind of pet you want from the options provided below");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Rabbit");
        int petSelected = Convert.ToInt32(Console.ReadLine()); // this collects the input string from the user and converts to an integer


        switch (petSelected) // switch case statement to handle the pet type and name selected by the user
        {
            case 1:
                Console.WriteLine($"What a great choice!! You have selected {animal1} as the pet type");
                Console.WriteLine($"What would you like to name your {animal1}?");
                petName = Console.ReadLine();
                Console.WriteLine($"Congratulations!! You have chosen {petName} as the name of your {animal1}");
                break;

            case 2:
                Console.WriteLine($"What a great choice!! You have selected {animal2} as the pet type");
                Console.WriteLine($"What would you like to name your {animal2}?");
                petName = Console.ReadLine();
                Console.WriteLine($"Congratulations!! You have chosen {petName} as the name of your {animal2}");
                break;

            case 3:
                Console.WriteLine($"What a great choice!! You have selected {animal3} as the pet type");
                Console.WriteLine($"What would you like to name your {animal3}?");
                petName = Console.ReadLine();
                Console.WriteLine($"Congratulations!! You have chosen {petName} as the name of your {animal3}");
                break;

            default:
                Console.WriteLine("Please select a correct option");
                break;
        }
        

           
        }

    }