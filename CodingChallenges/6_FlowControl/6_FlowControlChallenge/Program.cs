using System;

namespace _6_FlowControl
{
    public class Program
    {
        //create global variables to hold users login data.
        public static string username;
        public static string password;

        static void Main(string[] args){
            
        }

        // This method gets a valid temperaturebetween -40 asnd 135 inclusive 
        // and returns the valid int.
        public static int GetValidTemperature()
        {
            int temp_int;

            // Checks to make sure user inputs an integer between -40 and 130
            while(true){
                System.Console.WriteLine("Please enter an integer for temperature between -40 and 130");
                String input_temp = System.Console.ReadLine();
                bool isInt = int.TryParse(input_temp, out temp_int);
                if(isInt && (temp_int > -40 && temp_int < 130)) break;
                System.Console.WriteLine("\nEntry is not Valid");
            }
            return temp_int;
        }

        // This method has one int parameter
        // It gives outdoor activity advice and temperature opinion based on 20 degree
        // increments starting at -20 and ending at 135 
        // n < -20 = hella cold
        // -20 <= n < 0 = pretty cold
        //  0 <= n < 20 = cold
        // 20 <= n < 40 = thawed out
        // 40 <= n < 60 = feels like Autumn
        // 60 <= n < 80 = perfect outdoor workout temperature
        // 80 <= n < 90 = niiice
        // 90 <= n < 100 = hella hot
        // 100 <= n < 135 = hottest
        public static void GiveActivityAdvice(int temp)
        {
            // Reply with what to wear at each temperature
            switch(temp){
                case int n when (n < -20):
                    System.Console.WriteLine("hella cold, Wear mittens");
                    break;
                case int n when (n < 0):
                    System.Console.WriteLine("pretty cold, Wear a heavy coat and scarf.");
                    break;
                case int n when (n < 20):
                    System.Console.WriteLine("cold, Wear a heavy sweater and long pants.");
                    break;
                case int n when (n < 40):
                    System.Console.WriteLine("thawed out, Good weather for shorts and t-shirt.");
                    break;
                case int n when (n < 60):
                    System.Console.WriteLine("feels like Autumn, Wear some long sleaved shirts.");
                    break;
                case int n when (n < 80):
                    System.Console.WriteLine("perfect outdoor workout temperature, Good weather for shorts and t-shirt.");
                    break;
                case int n when (n < 90):
                    System.Console.WriteLine("niiice, Good weather for shorts and t-shirt.");
                    break;
                case int n when (n < 100):
                    System.Console.WriteLine("hella hot, It's hot hot hot.  Wear light clothing.");
                    break;
                default:
                    System.Console.WriteLine("hottest, Drink some water.");
                    break;
            }
        }

        // This method gets a username and password from the user
        // and stores that data in the global variables of the 
        // names in the method.
        public static void Register()
        {
            System.Console.WriteLine("\nRegistering your account");
            System.Console.WriteLine("Please enter your username");
            Program.username = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your password");
            password = System.Console.ReadLine();
            System.Console.WriteLine("saved");
        }

        // This method gets username and password from the user and
        // compares them with the username and password global variables
        // or the names provided. If the password and username match,
        // the method returns true. If they do not match, the user is 
        // prompted again for the username and password.
        public static bool Login()
        {   
            while(true){
                System.Console.WriteLine("\nLogging into your account");
                System.Console.WriteLine("Please enter your username");
                String user = System.Console.ReadLine();
                System.Console.WriteLine("Please enter your password");
                String pass = System.Console.ReadLine();
                if(username == user && Program.password == pass) break;
            }
            return true;
        }

        // This method as one int parameter.
        // It chack is the int is <=42, between 
        // 43 and 78 inclusive, or > 78.
        // For each temperature range, a different 
        // advice is given. 
        public static void GetTemperatureTernary(int temp)
        {
            if(temp < -40 || temp > 130) {
                System.Console.WriteLine("Not a valid temperature");
                temp = GetValidTemperature();
            }

            string msg1 = "{0} is too cold!";
            string msg2 = "{0} is an ok temperature";
            string msg3 = "{0} is too hot!";

            string msg = temp <= 42 ? msg1 : (temp <= 78 ? msg2 : msg3);
            System.Console.WriteLine(msg, temp);



            // switch (temp){
            //     case int n when (n <= 42):
            //         System.Console.WriteLine("{0} is too cold", temp);
            //         break;
            //     case int n when (n <= 78):
            //         System.Console.WriteLine("{0} is too cold", temp);
            //         break;
            //     case int n when (n <= 42):
            //         System.Console.WriteLine("{0} is too cold", temp);
            //         break;
            // }
            
        }
    }//end of Program()
}
