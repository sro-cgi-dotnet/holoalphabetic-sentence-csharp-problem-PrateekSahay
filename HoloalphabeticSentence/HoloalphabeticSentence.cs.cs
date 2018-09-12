using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            input=input.ToLower();
            foreach(char i in alphabets){
               if (!(input.Contains(i))){
                   return false;
               }
            }
            return true;
        }
    }
}
