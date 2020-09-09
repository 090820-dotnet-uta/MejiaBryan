using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            //
            //
            //implement the required code here and within the methods below.
            //
            //


            Console.WriteLine("Please enter your message and press enter");
            userInputString =  Console.ReadLine();

            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            elementNum =  int.Parse(Console.ReadLine());

            StringToUpper(userInputString);
            StringToLower(userInputString);
            StringTrim(userInputString);
            StringSubstring(userInputString, elementNum);

            Console.WriteLine("For which character should I search in your original message?");
            char1 =  Console.ReadLine().ToCharArray()[0];

            SearchChar(userInputString, char1);

            Console.WriteLine("Please enter your first name");
            fName =  Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lName =  Console.ReadLine();

            userFullName = ConcatNames(fName, lName);

        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            // throw new NotImplementedException("StringToUpper method not implemented.");
            string output = x.ToUpper();
            Console.WriteLine("After string is made all uppercase: {0}", output);
            return output;
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            // throw new NotImplementedException("StringToUpper method not implemented.");
            string output = x.ToLower();
            Console.WriteLine("After string is made all lowercaes: {0}", output);
            return output;
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            // throw new NotImplementedException("StringTrim method not implemented.");
            string output = x.Trim();
            Console.WriteLine("After string is trimmed of whitespaces before and after it: {0}", output);
            return output;
        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            // throw new NotImplementedException("StringSubstring method not implemented.");
            string output = x.Substring(elementNum);
            Console.WriteLine("After string is substringed at input index: {0}", output);
            return output;
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            // throw new NotImplementedException("SearchChar method not implemented.");
            int output = userInputString.IndexOf(x);
            Console.WriteLine("Index of char '{1}' is: {0}", output, x);
            return output;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            // throw new NotImplementedException("ConcatNames method not implemented.");
            string output = fName + " " + lName;
            Console.WriteLine("After strings are concatenated: {0}", output);
            return output;
        }



    }//end of program
}
