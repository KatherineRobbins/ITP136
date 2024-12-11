using static System.Console;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // This Program is created to help Real Estate Agents collect and store clients and prospective clients information
            Console.WriteLine("Welcome to your database.");

            Menu();

        }

        static void Menu()
        {

            bool exitProgram = false;
            while (!exitProgram) 
            {
                WriteLine("Select an option:");
                WriteLine("1.Enter a Lead into your database");
                WriteLine("2. View your leads");
                WriteLine("3.Enter a Client into your database");
                WriteLine("4. View your clients");
                WriteLine("5.View Clients and Leads");
                WriteLine("Enter the number corresponding to your choice.");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    EnterLead();
                }
                else if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\nViewing leads...");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\nLeads:");
                    Console.ResetColor();
                    ViewData("person.csv");
                }

                else if (choice == 3)
                {
                    EnterClient();
                }

                else if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\nViewing clients...");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nClients:");
                    Console.ResetColor();
                    ViewData("client.csv");
                   
                }
                else if (choice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\nViewing clients and leads...");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nClients:");
                    Console.ResetColor();
                    ViewData("client.csv");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\nLeads:");
                    Console.ResetColor();
                    ViewData("person.csv");
                }
                else
                {
                    WriteLine("\nYou have chosen an invalid choice");
                }

                if (!exitProgram)
                {
                    
                    Console.ForegroundColor= ConsoleColor.Red;
                    WriteLine("\nDo you want to continue? (y/n)");
                    Console.ResetColor();
                    string response = Console.ReadLine().ToLower();
                    if (response != "y")
                    {
                        WriteLine("Exiting the program...");
                        exitProgram = true;
                    }
                }
            }
           
        }
        

        // view data in database
        static void ViewData(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach ( var line in lines)
            {
                WriteLine(line);
            }
           
        }

       

        //enter a lead into database

        static void EnterLead()
        {

            List<Person> personList = new List<Person>();

           


            WriteLine("How many leads do you have to enter into your database?");
            int personInput = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < personInput; x++)
            {
                WriteLine("Enter Lead's Full Name:");
                string pfn = Console.ReadLine();

                WriteLine("Enter Lead's Address:");
                string pad = Console.ReadLine();

                WriteLine("Enter Lead's Email:");
                string pem = Console.ReadLine();

                personList.Add(new Person(pfn, pad, pem));

            }

            

            AppendToCsv("person.csv", personList);
            WriteLine("New lead has been saved to CSV file.");
           

        }
       
        
        //enter a client into database


        static void EnterClient()
        {
            List<Client> clientList = new List<Client>();
            WriteLine("How many clients do you have to enter into your database?");
            int clientInput = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < clientInput; x++)
            {
                WriteLine("Enter Clients's Full Name:");
                string cfn = Console.ReadLine();

                WriteLine("Enter Clients's Address:");
                string cad = Console.ReadLine();

                WriteLine("Enter Clients's Email:");
                string cem = Console.ReadLine();

                try
                {
                    WriteLine("Enter Client's Anniversary of Home Purchase mmddyy:");
                    int cap = Convert.ToInt32(Console.ReadLine());
                    clientList.Add(new Client(cfn, cad, cem, cap));
                }
                catch (FormatException)
                {
                    WriteLine("Invalid format. Pleaser enter a numeric value for the clients Anniversary of Home Purchase mmddyy.");
                }





            }

           AppendToCsv("client.csv", clientList);

            WriteLine("New client has been saved to CSV file.");
            
        }


      

        // used chatgpt for help here
        static void AppendToCsv<T>(string fileName, List<T> data)
          {
              bool fileExists = File.Exists(fileName);

              using (StreamWriter writer = new StreamWriter(fileName, append: true))
              {
                  var properties = typeof(T).GetProperties();

                  if (!fileExists)
                  {
                      writer.WriteLine(string.Join(",", Array.ConvertAll(properties, prop => prop.Name)));
                  }

                  foreach (var item in data)
                  {
                      var values = Array.ConvertAll(properties, prop => prop.GetValue(item)?.ToString());
                      
                      writer.WriteLine(string.Join(",", values));
                  }
              }
          }
    }



       

        
    
}