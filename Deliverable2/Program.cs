using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("\nSaluti! Welcome to Big Sal's all-you-can-eat Italian Buffet and Coffee Bar!\n");
        Console.WriteLine("How many will be dining with us today?\n");
        Console.WriteLine("And please, no parties larger than six!\n");
        int party = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (party > 6)
        {
            Console.WriteLine("Oh, mi dispiace friends. We can only seat parties of six or fewer today, as we are very busy. Arrivederci!\n");
            return;
        }
        else
        {
            Console.WriteLine("Magnifico! A party of " + party + ". Please, follow me right to your seats!\n");
        }

        decimal priceBuffet = ((decimal)party * (decimal)9.99); //the total price of the party's meal before drinks!//
        int numDrink1 = 0;
        int numDrink2 = 0;
        decimal drink1 = (decimal)2.95; //drink 1 means espresso!//
        decimal drink2 = (decimal)1.00; //drink 2 means 'American' coffee!//

        Console.WriteLine("Well, before you dig in to our world famous, mouth-watering, scrumptious Italian buffet...\n");
        Console.WriteLine("How about I take your coffee orders?\n");
        Console.WriteLine("We have good, Italian espresso and regular, American coffee.\n");
        Console.WriteLine();

        for (int i = 1; i <= party; i++)
        {
            Console.WriteLine("Well, guest " + i + ", what'll it be? Will you have our delicious espresso? Or do you want sad, awful, watery American coffee?\n");
            string order = Console.ReadLine();

            if (order == "espresso")
            {
                numDrink1 += 1;
                Console.WriteLine("\nAh! I knew you had good taste! One espresso it is!\n");
                Console.WriteLine();
            }
            else if (order == "coffee" || order == "American coffee" || order == "american coffee")
            {
                numDrink2 += 1;
                Console.WriteLine("\nOh...Very well then...One American coffee, coming up. *sigh*\n");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nSono effeso! This is an ITALIAN coffee bar. We don't serve that here! No drink for you!\n");
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Bellisimo! That is " + numDrink1 + " elegant espresso and " + numDrink2 + " overly-diluted American coffees. I'll bring those right out. Now, dig in!!!\n");
        decimal bill = priceBuffet + (numDrink1 * drink1) + (numDrink2 * drink2);
        Console.WriteLine("Thank you very much for dining at Big Sal's! Here's your bill! The total came out to: $" + bill);
        Console.WriteLine();
    }
}

