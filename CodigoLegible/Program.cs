using System;

namespace CodigoLegible
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a code comment!
            string firstName = "Bob";
            int widgetsPurchased = 7;
            //Testing a change to the message.
            // int widgetsSold = 7;
            // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
            Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
            /*
                This is a long commnet
                thst spans multiple lines
                just to prove that it can
                be done
            */
            /*
            string firstName = "Bob";
            int widgetsPurchased = 7;
            Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
            */

            /*
            Random random = new Random();
            string[] orderIDs = new string[5];
            // Loop through each blank orderID
            for (int i = 0; i < orderIDs.Length; i++)
            {
                // Get a random value that equates to ASCII letters A through E
                int prefixValue = random.Next(65, 70);
                // Convert the random value into a char, then a string
                string prefix = Convert.ToChar(prefixValue).ToString();
                // Create a random number, padd eith zeroes
                string suffix = random.Next(1, 100).ToString("000");
                // Combine the prefix and suffix together, then assign to current OrderID
                orderIDs[i] = prefix + suffix;
            }

            // Print out each orderID
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
            */

            /*
              The following code creates five random OrderIDs
              to test the fraud detection process.  OrderIDs 
              consist of a letter from A to E, and a three
              digit number. Ex. A123.
            */
            Random random = new Random();
            string[] orderIDs = new string[5];
            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                Console.WriteLine(prefixValue);
                string prefix = Convert.ToChar(prefixValue).ToString();
                Console.WriteLine(prefix);
                string suffix = random.Next(1, 100).ToString("000");
                Console.WriteLine(suffix);
                orderIDs[i] = prefix + suffix;
            }

            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            //string str = "The quick brown fox jumps over the lazy dogs";
            //// Convert the message into a char array
            //char[] charMessage = str.ToCharArray();
            //// Reverse the chars
            //Array.Reverse(charMessage);
            //int x = 0;
            //// Count the o's
            //foreach (char i in charMessage) { if (i == 0) { x++; } }
            //// Convert it back to string
            //string new_message = new String(charMessage);
            //// Print it out
            //Console.WriteLine(new_message);
            //Console.WriteLine($"'o' appears {x} times.");

            // Mejorando el código anterior
            /*
               This code reverses a message, counts the number of times 
               a particular character appears, then prints the results
               to the console window.
             */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }
    }
}
