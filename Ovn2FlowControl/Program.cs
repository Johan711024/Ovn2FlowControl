




namespace Ovn2FlowControl
{
    internal class Program
    {


        static void Main(string[] args)
        {

            
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("Navigera genom att skriva in siffror för att testa olika funktioner\n\n");


            MainMenu();

            

            do
            {
                string input = Console.ReadLine()!;
                switch (input)
                { 
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        GroupAccompanied();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
                    case "3":
                        TheThirdWord();
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;
                }
            }
            while (true);
            
            void TheThirdWord()
            {
                Console.WriteLine("Mata in en mening med fler än 2 ord");
                string _input = Console.ReadLine()!;



                 
                string[] inputList = _input.Split(" ");

                Console.WriteLine($"Tredje ordet: {inputList[2]}");


                Console.Write($" \n");
            }


            void RepeatTenTimes()
            {
                Console.WriteLine("Mata in ett ord eller text");
                string input = Console.ReadLine()!;

                for(int i=0; i<10; i++)
                {
                    Console.Write($"{input} ");
                }
                Console.Write($" \n");

            }

            void GroupAccompanied()
            {
                Console.WriteLine("Antal personer?");
                bool success = false;
                uint numPeople = 0;

                do
                {
                    string input = Console.ReadLine()!;

                    if (uint.TryParse(input, out uint answer))
                    {
                        numPeople = answer;
                        success = true;
                    }

                } while (!success);

                uint totalPrice=0;
                for(uint i = 0; i < numPeople; i++){

                    uint age, price;

                    age = ValidateAge(i);
                    price = PricePerAge(age);
                    totalPrice = totalPrice + price;
                }
                Console.WriteLine($"Antal personer: {numPeople}");
                Console.WriteLine($"Totalkostnad: {totalPrice}");
            }

            uint ValidateAge(uint person)
            {
                Console.WriteLine($"Person {person+1}. Ange ålder i siffror");
                bool success = false;
                uint age = 0;

                do
                {
                    string input = Console.ReadLine()!;

                    if (uint.TryParse(input, out uint answer))
                    {

                        age= answer;
                        PriceInfo(age, PricePerAge(age));
                        success = true;
                    }

                } while (!success);

                return age;

            }

            void PriceInfo(uint age, uint price)
            {
                

                if (age < 18)
                {
                   
                    Console.WriteLine($"Ungdomspris: {price}kr");
                }
                else if (age >= 65)
                {
                    
                    Console.WriteLine($"Pensionärspris: {price}kr");
                }
                else
                {
                    
                    Console.WriteLine($"Standardpris: {price}kr");
                }
                

            }

            uint PricePerAge(uint age)
            {
                uint price = 0;

                if (age < 18)
                {
                    price = 80;
                   
                }
                else if (age >= 65)
                {
                    price = 90;
                    
                }
                else
                {
                    price = 120;
                    
                }
                return price;

            }

            void MainMenu()
            {
                Console.WriteLine("0 Stäng");
                Console.WriteLine("1 Ungdom eller pensionär");
                Console.WriteLine("2 Upprepa tio gånger");
                Console.WriteLine("3 Det tredje ordet");

            }
        }
        
    }
}