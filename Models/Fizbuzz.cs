using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class Fizbuzz
    {
       //[Required, Range(0,1000)]
        public int Number { get; set; }

        public string FizzBuzz;
        public void output()
        {
            if(Number %3 == 0 && Number %5 == 0)
            {
                FizzBuzz = "FizzBuzz";
            }
            else if (Number %3 == 0)
            {
                FizzBuzz = "Fizz";
            }
            else if (Number %5 == 0)
            {  
                    FizzBuzz = "Buzz"; 
            }
            else
            {
                FizzBuzz = "Liczba nie spełnia kryteriów zadania";
            }
        }

    }
}