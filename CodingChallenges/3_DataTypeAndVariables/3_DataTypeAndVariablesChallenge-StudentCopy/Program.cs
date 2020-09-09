using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 5;
          Console.WriteLine(myByte);

          sbyte mySbyte = -66;
          Console.WriteLine(mySbyte);

          int myInt = -654646;
          Console.WriteLine(myInt);

          uint myUint = 30897892;
          Console.WriteLine(myUint);

          short myShort = -23876;
          Console.WriteLine(myShort);

          ushort myUShort = 50000;
          Console.WriteLine(myUShort);

          float myFloat = -0.777f;
          Console.WriteLine(myFloat);

          double myDouble = 43.643245;
          Console.WriteLine(myDouble);

          char myCharacter = 'x';
          Console.WriteLine(myCharacter);

          bool myBool = true;
          Console.WriteLine(myBool);

          string myText = "I control text";
          Console.WriteLine(myText);

          string numText = "1234";
          Console.WriteLine(Text2Num(numText));
      }

      public static int Text2Num(string numText)
      {
        // throw new NotImplementedException();
        int output;
        bool isInt = int.TryParse(numText, out output);
        return output;

      }
    }
}
