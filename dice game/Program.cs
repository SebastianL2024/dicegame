namespace dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            Console.WriteLine("välkomen till dice game");
          Random rand = new Random();
            Console.WriteLine("Vill du slå eller stanna?");
            string answer = Console.ReadLine();

            while (true)
            {
                if (sum2 < 17)
                { 
                    int randomnumber = rand.Next(1, 7);
                    sum2 += randomnumber;
                    Console.WriteLine("dealerns poäng är "+ sum2);
                }

                if (answer == "slå")
                {
                    int randomnumber = rand.Next(1, 7);
                    sum += randomnumber;
                    Console.WriteLine("Din poäng är " + sum);
                    answer = Console.ReadLine();
                } 
                if (answer == "stanna")
                {
                    break;
                }
                 
               
                    
                
            }    
            

               if (sum>21)
            {
                Console.WriteLine("du har förlorat");
                
            }
               if (sum<21&&sum>sum2)
            {
                Console.WriteLine("du har vunnit");
            }
               if (sum2>21)
            {
                Console.WriteLine("dealern har förlorat");
            {
                   if (sum2<21&&sum2>sum)
                Console.WriteLine("dealern har vunnit");
            }

        }
    }
}}