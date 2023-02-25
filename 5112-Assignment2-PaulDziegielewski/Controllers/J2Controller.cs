using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112_Assignment2_PaulDziegielewski.Controllers
{
    public class J2Controller : ApiController
    {


        /// <summary>
        /// This method returns the number of times the sum of 10 can be rolled when 2 dice are rolled. The user selects how many sides dice1 should be and how many sides dice2 should be 
        /// (dice1 = 7, dice2 = 3) ==> this combination allows for only 1 roll which amounts to 10
        /// </summary>
        /// <param name="dice1"></param>
        /// <param name="dice2"></param>
        /// <example>dice1 = 4, dice2 = 8</example>
        /// <example>possible combinations (2/8, 3/7, 4/6)</example>
        /// <returns>3 sums of 10</returns>
        [HttpGet]
        [Route("api/J2/dice/{dice1}/{dice2}")]
        public string dice(int dice1, int dice2)
        {
            int rolled10 = 0;

            for (int i = dice1; i >= 1; i--)
            {
                for (int j = dice2; j >= 1; j--)
                {
                    if ((i + j) == 10)
                    {
                        rolled10++;
                    }
                }
            }
            return "There are " + rolled10 + " total ways to get the sum 10.";
        }


    }
}
