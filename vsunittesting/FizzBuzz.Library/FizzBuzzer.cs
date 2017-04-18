using System;
namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            #region "after refactoring"
            string output = string.Empty;
            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();
            return output;
            #endregion

            #region "before refactoring"
            //if (input % 3 == 0 && input % 5 == 0)
            //    return "FizzBuzz";
            //if (input % 3 == 0)
            //    return "Fizz";
            //if (input % 5 == 0)
            //    return "Buzz";
            //return input.ToString();
            #endregion
        }
    }
}
