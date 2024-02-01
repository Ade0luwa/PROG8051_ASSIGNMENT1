using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string animal1 = "Lion";
        string animal2 = "Tiger";
        string animal3 = "Cheetah";
        string petName = "Ade";
        string applicationName = "Adeoluwatomiwa Pet Simulator";
        int hunger = 5;
        int happiness = 5;
        int health = 5;
        int maxHealth = 10;
        int minHealth = 1;
        int maxHunger = 10;
        int minHunger = 1;
        int maxHappiness = 10;
        int minHappiness = 1;
        bool actionsChoice = true;


        Console.WriteLine($"Welcome to {applicationName}");
        Console.WriteLine("It is good to have you here");
        Console.WriteLine("Please select the kind of pet you want from the options provided below");
        Console.WriteLine($"1. {animal1}");
        Console.WriteLine($"2. {animal2}");
        Console.WriteLine($"3. {animal3}");
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
                Console.WriteLine("Please exit the application and retry with a correct option");
                break;
        }

        while (actionsChoice)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose an action from the below dropdown");
            Console.WriteLine("Main Menu Options:");
            Console.WriteLine($"1. Feed {petName}");
            Console.WriteLine($"2. Play with {petName}");
            Console.WriteLine($"3. Let {petName} rest");
            Console.WriteLine($"4. Check {petName}'s status");
            Console.WriteLine("5. Exit the application");
            int actionSelected = Convert.ToInt32(Console.ReadLine());

            // if hunger decreases the minimum hunger, set the value of hunger to minHunger
            if (hunger < minHunger)
            {
                hunger = minHunger;
            }
            //if happiness is greater than max happiness level, set the value of happiness to the max happiness possible
            else if (happiness > maxHappiness)
            {
                happiness = maxHappiness;
            }
            else if (happiness < minHappiness)
            {
                happiness = minHappiness;
            }
            else if (health < minHealth)
            {
                health = minHealth;
            }

            // Checks for critical status
            else if (hunger >= 9)
            {
                Console.WriteLine($"{petName} is extremely hungry right now. Be careful and feed {petName} immediately before you turn to a meal");
            }
            else if (happiness <= 2)
            {
                Console.WriteLine($"{petName} is very unhappy! Consider playing with {petName}.");
            }
            else if (health <= 2)
            {
                Console.WriteLine($"{petName}'s health is critical! Try resting {petName}");
            }


            // Perform action based on user choice
            switch (actionSelected)
            {
                case 1: //Feeding decreases hunger levels and slightly increases health of the pet
                    
                    // if condition to check if the pet is not hungry and does not need feeding
                    if (hunger == minHunger) 
                    {
                        Console.WriteLine($"{petName} is currently full and can no longer eat. Perform some activities with {petName} and try again");
                    }

                    // condition to check if the health is full and does not need further addition
                    else if (health == maxHealth) 
                    {
                        hunger = hunger - 2; //hunger decreases by 2 
                        Console.WriteLine($"Good work feeding {petName}. The health status is full and won't be affected.");
                    }

                    //if health is not maxed out and pet is not full, the below will be performed.
                    else
                    {
                        hunger = hunger - 2; //hunger decrease by 2
                        health = health + 1; //health is slightly increased by 1
                        Console.WriteLine($"Good work feeding {petName}. The hunger has decreased and health has slightly improved.");                        
                    }
                    break;

                case 2: // Playing increases the happiness of the pet but also increases the hunger level
                    happiness = happiness + 2; //happiness increased
                    hunger = hunger + 1; //hunger increased.

                    if (happiness >= maxHappiness)
                    {
                        Console.WriteLine($"{petName} is extremely happy right now. Playing won't make him happier. Perform another activity!!");
                    } 
                    
                    // condition to check and send out a message when the hunger level of the pet has reached it's peak.
                    else if (hunger >= maxHunger)
                    {
                        hunger = maxHunger;
                        //Console.WriteLine($"{petName} is extremely hungry right now. Be careful and feed him immediately before you turn to a meal");
                    }

                    else
                    {
                        Console.WriteLine($"Good work playing with your pet. {petName} is now happy but has gotten hungry a little bit.");
                    }
                    break;

                case 3:
                    health = health + 2; //improves health
                    happiness = happiness - 1; //slightly decrease happiness

                    if (health >= maxHealth)
                    {
                        health = maxHealth;
                        Console.WriteLine($"{petName} has really rested a lot and has a full bar of health. Try performing some activities");
                    }
                    else
                    {
                        Console.WriteLine($"{petName} has gotten some rest. health has improved but happiness has decreased");
                    }
                    break;

                case 4:
                    Console.WriteLine($"{petName}'s Status:");
                    Console.WriteLine($"Hunger: {hunger}");
                    Console.WriteLine($"Happiness: {happiness}");
                    Console.WriteLine($"Health: {health}");
                    break;

                case 5:
                    Console.WriteLine($"Thank you for using {applicationName}. Hope to see you soon");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }

        }
           
        }

    }