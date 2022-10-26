//Reviewed by:Amir Smith

//Peer comment:works really well!


bool letsPlay = true;

while(letsPlay == true)
{

string [] asian = {"Sticky Rice Restaurant", "Kabul Express", "Mother India Cuisine", "Konfucius Eats", "Pho Viet", "Hoki Korean BBQ", "Kimoto Sake & Sushi", "Jollibee", "Gerry's Grill", "Thai House"};

string [] italian = {"Chefs of New York", "Ciao Bella", "Gusto Italiano Ristorante", "Galletto Ristorante", "Braulio's Bistro", "Palermo Restaurant", "Bella Italia", "Papapolloni Mediterranean Bistro", "Mama Mia", "Strings Italian Cafe"};

string [] pizza = {"Dominos", "Chicago Pizza", "Round Table", "Nizario's Pizza", "Pizza Guys", "Mountain Mike's Pizza", "Eddie's Pizza", "Little Caesar's", "Papa John's Pizza", "Mellow Mushroom"};

string [] american = {"Sizzler", "Claim Jumper", "Chili's", "Red Robin", "Buffalo Wild Wings", "Outback", "The Cheesecake Factory", "Denny's", "Panera", "Bob's Giant Burgers"};

string [] mexican = {"Roberto's", "Royberto's", "Chipotle", "Roberta's", "El Torrito", "El Cotixan", "Nena's", "Taqueria El Maguey", "Las Delicias", "La Parrilla"};

string [] driveThru = {"McDonald's", "Burger King", "Taco Bell", "Carls Jr", "Sonic", "Jack in the Box", "Wienerschnitzel", "El Pollo Loco", "Canes", "Starbucks"};

string [] emergency = {"Sticky Rice Restaurant", "Kabul Express", "Mother India Cuisine", "Konfucius Eats", "Pho Viet", "Hoki Korean BBQ", "Kimoto Sake & Sushi", "Jollibee", "Gerry's Grill", "Thai House", "Chefs of New York", "Ciao Bella", "Gusto Italiano Ristorante", "Galletto Ristorante", "Braulio's Bistro", "Palermo Restaurant", "Bella Italia", "Papapolloni Mediterranean Bistro", "Mama Mia", "Strings Italian Cafe", "Dominos", "Chicago Pizza", "Round Table", "Nizario's Pizza", "Pizza Guys", "Mountain Mike's Pizza", "Eddie's Pizza", "Little Caesar's", "Papa John's Pizza", "Mellow Mushroom", "Sizzler", "Claim Jumper", "Chili's", "Red Robin", "Buffalo Wild Wings", "Outback", "The Cheesecake Factory", "Denny's", "Panera", "Bob's Giant Burgers", "Roberto's", "Royberto's", "Chipotle", "Roberta's", "El Torrito", "El Cotixan", "Nena's", "Taqueria El Maguey", "Las Delicias", "La Parrilla", "McDonald's", "Burger King", "Taco Bell", "Carls Jr", "Sonic", "Jack in the Box", "Wienerschnitzel", "El Pollo Loco", "Canes", "Starbucks"};

  
Console.WriteLine("Welcome to the Restaurant Picker where a restaurant to eat at will be randomly chosen for you. Please pick from the following food genres: Asian, Italian, Pizza, American, Mexican, Drive Thru, or Emergency. In case of Emergency, a restaurant of any genre will be chosen. If you do not pick a valid response, it will be assumed to be a case of dire Emergency.");
string answer = Console.ReadLine().ToLower();  
    
    if(answer == "asian")
    {
        Random randNum = new Random();
        int useAsian = randNum.Next(0, asian.Length);
        Console.WriteLine("You will eat at " + asian[useAsian]);
        //return;
    }


    else if(answer == "italian")
    {
        Random randNum = new Random();
        int useItalian = randNum.Next(0, italian.Length);
        Console.WriteLine("You will eat at " + italian[useItalian]);
    }

    else if(answer == "pizza")
    {
        Random randNum = new Random();
        int usePizza = randNum.Next(0, pizza.Length);
        Console.WriteLine("You will eat at " + pizza[usePizza]);
    }


    else if(answer == "american")
    {
        Random randNum = new Random();
        int useAmerican = randNum.Next(0, american.Length);
        Console.WriteLine("You will eat at " + american[useAmerican]);
    }


    else if(answer == "mexican")
    {
        Random randNum = new Random();
        int useMexican = randNum.Next(0, mexican.Length);
        Console.WriteLine("You will eat at " + mexican[useMexican]);
    }


    else if(answer == "drivethru" || answer == "drive thru")
    {
        Random randNum = new Random();
        int useDriveThru = randNum.Next(0, driveThru.Length);
        Console.WriteLine("You will eat at " + driveThru[useDriveThru]);
    }

    else
    {
        Random randNum = new Random();
        int useEmergency = randNum.Next(0, emergency.Length);
        Console.WriteLine("You will eat at " + emergency[useEmergency]); 
    }
   

   

bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}