using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace _5112_Assignment2_PaulDziegielewski.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This method returns a caloric total. The user selects 1 item from EACH of the following categories({burger},{drink},{side},{dessert}. Each category has 4 caloric options (the last option, #4 = 0 calories aka (user opts out of that item))
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <example>1,2,3,4</example>
        /// <returns>461 calories, 160 calories, 70 calories, 0 calories</returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int Menu(int burger, int drink, int side, int dessert)
        {
           
            int burgerTotal = 0;
            int drinkTotal = 0;
            int sideTotal = 0;
            int dessertTotal = 0;

            int[] burgerCalories = {461,431,420,0 };
            if(burger < burgerCalories.Length)
            {
                burgerTotal = burgerTotal + burgerCalories[burger - 1];
            }
           

            int[] drinkCalories = {130,160,118,0 };
            if(drink < drinkCalories.Length)
            {
                drinkTotal = drinkTotal + drinkCalories[drink - 1];
            }
          

            int[] sideCalories = {100,57,70,0};

            if(side < sideCalories.Length)
            {
                sideTotal = sideTotal + sideCalories[side - 1];
            }
           
            int[] dessertCalories = {167,266,75,0};

            if (dessert < dessertCalories.Length)
            {
                dessertTotal = dessertTotal + dessertCalories[dessert - 1];
            }
            int total = burgerTotal + drinkTotal + sideTotal + dessertTotal;
            return total;

        }






    }
}