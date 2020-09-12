using System;
using System.Text;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // UseFor();
            // UseDoWhile();
            // UseWhile();
        }
        
        public static void UseFor()
        {
            StringBuilder oddNumMsg = new StringBuilder();
            for(int i = 1; i < 50; i+=2){
                oddNumMsg.Append(i).Append(" ");
            }
            System.Console.WriteLine(oddNumMsg);
        }

        public static void UseDoWhile()
        {
            StringBuilder oddNumMsg = new StringBuilder();
            int i = -2;
            do{
                i+=2;
                oddNumMsg.Append(i).Append(" ");
            } while(i < 50);
            System.Console.WriteLine(oddNumMsg);
        }

        public static void UseWhile()
        {
            int i = 0;
            while(true){
                if(i > 100) break;
                if(i % 3 == 0){
                    if (i % 5 == 0){
                        System.Console.WriteLine("Skipping this number");
                    }
                    else{
                        System.Console.WriteLine(i);
                    }
                }
                i++;
            }
        }
    }
}
// 2. create a do/while loop that displays the even integers from 0 to 50.
// 3. create a while loop that displays the multiples of 3 integers from 0 to 100. 
//     1. Design the loop so that when every multiple of 3 and 5 coincide(like 15, 30, etc), you print "skipping this number" instead of the number.
//     2. Design the loop so that when you get above 100 you automatically stop the loop with a break statement.