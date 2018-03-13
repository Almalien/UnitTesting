using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace UTesting
{
    public class Homework : IHomework
    {
        public string ValidateEmail(string email)
        {
            if (email.Count(c => c == '.') > 1)
                return "no valid";


            Regex rgx = new Regex("^\\w{1,12}[@]\\w{1,8}[.]{1}(com|net|gov|mx|microsoft)");
            if (rgx.IsMatch(email.ToLower()))
            {
                return "valid";
            }
            else {

                return "no valid";
            }

        }

        public string ValidateFibonnacci(string list)
        {
            Regex rgx = new Regex("^$|^(^1|(?>\\2?)(\\1))*1$");


            string a =

            //if (rgx.IsMatch(list))
            //    return "valid";
            //else
            //    return "no valid";
        }

        public string ValidatePassword(string password)
        {
            throw new NotImplementedException();
        }

        public string ValidatePhone(string phone)
        {
            Regex rgx = new Regex("^\\d{2,4}[- ]?\\s?\\d{1,3}[- ]?\\s?\\d{1,3}[- ]?\\s?\\d{1,3}[- ]?\\s?");

            if (rgx.IsMatch(phone))
                return "valid";
            else
                return "no valid";
        }

        public string ValidateTime(string time)
        {
            TimeSpan temp;

            if (TimeSpan.TryParse(time, out temp))
                return "valid";
            else
                return "no valid";
        }


        //public static int Fibonacci(int n)
        //{
            
        //   int a = 0;
        //   int  b = 1; 
        //    for (i = 0; i < n; i++)  //se repite para el número de veces deseado
        //    {
        //        aux = a;
        //        a = b; //intercambio valores
        //        b = aux + a; //cailculo el nuevo valor
        //        Console.WriteLine(aux); //imprimo el valor
        //    }
        //}

      

    }
}
