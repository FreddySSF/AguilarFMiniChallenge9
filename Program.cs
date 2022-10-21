// Fernando Aguilar
// 10-20-22
// Mini Challenge 9 Restaurant Picker Endpoint
// Create a program that provides the user with different options of restaurants
//  depending on what type of food they are in the mood for.
// Provide data validation and the option to replay program.
// Peer Reviewed By: Richard Johnson - The program works well for the most part, as it randomly picks a restaurant using a switch statement depending on what input the user types. However, there is a slight problem if the player enters an invalid input. While it does print "Invalid Input" the first time, it will continue to the ending input if you enter an invalid input more than once, or will just go there the first time if you press enter without inputting anything, so that part could definitely use a little work. Though, aside from that, it still does what it is supposed to do.

Console.Clear();

string playAgain = "yes";
while(playAgain == "yes")
{

bool restPick = false;
bool numInvalid;
int wrongAns = 0;
string myChoice = "";

while(restPick == false)
{
    Console.WriteLine(" Hello! Welcome to Freddy's Restaurant Picker!\nWhat are you in the mood for?\nMexican, Chinese, or American? ");
    myChoice = Console.ReadLine().ToLower();
    numInvalid = Int32.TryParse(myChoice, out wrongAns);

    if(numInvalid == false)
    {
        restPick = true;

        Random rndNum = new Random();
        long num = rndNum.Next(1,10);

        switch(myChoice)
        {
            case "mexican":

            switch(num)
            {
                case 1:
                    Console.WriteLine(" Freddy's Restaurant and Bar ");
                break;

                case 2:
                    Console.WriteLine(" Pancho Villa's Taqueria ");
                break;

                case 3:
                    Console.WriteLine(" Celia's ");
                break;

                case 4:
                    Console.WriteLine(" Luna Eterna Bar and Grill ");
                break;

                case 5:
                    Console.WriteLine(" La Perla");
                break;

                case 6:
                    Console.WriteLine(" Taqueria Chapala ");
                break;

                case 7:
                    Console.WriteLine(" Antojitos ");
                break;

                case 8:
                    Console.WriteLine(" Quesabirrias Xibalba");
                break;

                case 9:
                    Console.WriteLine(" El Toro ");
                break;

                case 10:
                    Console.WriteLine(" The taco truck by the Teacher's College ");
                break;

                default:

                break;
            }

            break;

            case "chinese":

            switch(num)
            {
                case 1:
                    Console.WriteLine(" The Chopstick ");
                break;

                case 2:
                    Console.WriteLine(" China Palace Restaurant ");
                break;

                case 3:
                    Console.WriteLine(" Yen Du Restaurant ");
                break;

                case 4:
                    Console.WriteLine(" Dave Wong's Restaurant ");
                break;

                case 5:
                    Console.WriteLine(" Golden Palace Buffet ");
                break;

                case 6:
                    Console.WriteLine(" Panda Express ");
                break;

                case 7:
                    Console.WriteLine(" Tasty Pot ");
                break;

                case 8:
                    Console.WriteLine(" Sushi House Buffet ");
                break;

                case 9:
                    Console.WriteLine(" Saigon Bowl Noodle House ");
                break;

                case 10:
                    Console.WriteLine(" Oceanic Restaurant ");
                break;

                default:

                break;
            }

            break;

            case "american":

            switch(num)
            {
                case 1:
                    Console.WriteLine(" Darby Dan's ");
                break;

                case 2:
                    Console.WriteLine(" Burger King ");
                break;

                case 3:
                    Console.WriteLine(" Ed's Diner ");
                break;

                case 4:
                    Console.WriteLine(" Denny's ");
                break;

                case 5:
                    Console.WriteLine(" Papa Tom's Restaurant ");
                break;

                case 6:
                    Console.WriteLine(" McDonalds ");
                break;

                case 7:
                    Console.WriteLine(" Subway ");
                break;

                case 8:
                    Console.WriteLine(" Keystone Family Diner ");
                break;

                case 9:
                    Console.WriteLine(" Annie's Diner and Pies ");
                break;

                case 10:
                    Console.WriteLine(" Popeye's ");
                break;

                default:

                break;
            }

            break;

            default:
            Console.WriteLine(" Select from one of the categories given: ");
            break;
        }
    }
    else
    {
        Console.WriteLine(" Invalid input. Please try again.. ");
        myChoice = Console.ReadLine().ToLower();
        numInvalid = Int32.TryParse(myChoice, out wrongAns);
    }
}

Console.WriteLine(" Thanks for using my Restaurant Picker!\nIf you have changed your mind type yes to try another restaurant from the picker,\nor any other input to close the program. ");
playAgain = Console.ReadLine().ToLower();
}
