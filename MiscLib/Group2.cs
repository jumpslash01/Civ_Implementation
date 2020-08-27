using System;

namespace MiscLib {
    public class GroupTwoFunctions {
        //---- Group 2 Functions ----------
        public int CalcRectPerimeter (int length, int width) {
            return length * 2 + width * 2;
        }

        public bool IsTriangularNum (int num) {
            int sum = 0;
            int addi = 1;

            while (sum <= num) {
                if (sum == num) return true;
                sum = sum + addi;
                addi++;
            }
            return false;
        }

        public int FarenheitToCelcius (int farenheit) {
            decimal x = (farenheit - 32m) * (5m / 9m);
            System.Console.WriteLine (x);
            int y = Convert.ToInt32 (decimal.Truncate (x));
            return y;
        }

        public bool CheckWhiteSpace (string word) {


            int length = word.Length;
            string test = Char.ToString (word[0]);
            if (test == " ") return true; 
            test = Char.ToString (word[length - 1]);
            if (test == " ") return true; 
            else return false;

            ;
        }

        public string CamelString (string word) {
            char[] chararray = new char[word.Length];
            for(int x = 0; x < word.Length; x++){
                if (x % 2 == 0){
                    chararray[x] = Char.ToLower(word[x]);
                }
                else chararray[x] = Char.ToUpper(word[x]);
            }
            string result = new string(chararray);
            return result;
        }

        public int CountDigits (string word) {
            int count = 0;
            for (int i = 0; i < word.Length; i++){
                if(word[i] > 46 && word[i] < 59){
                    count++;
                }
            }
            return count;
        }

    }
}