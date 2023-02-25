using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112_Assignment2_PaulDziegielewski.Controllers
{

    public class J3Controller : ApiController
    {
        /// <summary>
        /// This controller will determine which day did all(or most) guests select to attend an event.
        /// 1. Select how many guests will be attending
        /// 2. Each guest indicates with a "Y" that they are able to attend and "." to indicate that they are not able to attend. The guest makes 5 selections (Day 1: "Y", Day 2: "Y", Day 3: ".", Day 4: "Y", Day 5: ".";
        /// </summary>
        /// <example>GUEST 1 = ((Day 1: "Y", Day 2: "Y", Day 3: "Y, Day 4: "Y", Day 5: ".")</example>
        /// <example>GUEST 2 = ((Day 1: ".", Day 2: "Y", Day 3: ".", Day 4: ".", Day 5: ".")</example>
        /// <example>GUEST 3 = ((Day 1: "Y", Day 2: "Y", Day 3: ".", Day 4: "Y", Day 5: ".")</example>
        /// <returns>Day 3 is selected as the day that all guests are able to attend (Guests 1-3 indicated "Y")</returns>

        //public string GetGuests(int guests)

        /* 
var numberPeople = 3;


var guest1 = [];
var guest2 = [];
var guest3 = [];

var count = 0;

// var j = guestPrompt;
for(let i = 1; i <= 5; i++) {
  var guest1Prompt = prompt(`can you attend on day ${i}?`);
  guest1.push(guest1Prompt)
//    console.log(guest1);
} 

for(let i = 1; i <= 5; i++) {
  var guest2Prompt = prompt(`can you attend on day ${i}?`);
  guest2.push(guest2Prompt);
//    console.log(guest2);
} 

for(let i = 1; i <= 5; i++) {
  var guest3Prompt = prompt(`can you attend on day ${i}?`); 

  guest3.push(guest3Prompt);
//    console.log(guest3);
}

// how many guests can come on this day
var day1 = [];
var day2 = [];
var day3 = [];
var day4 = [];
var day5 = [];

var day1RSVP = [guest1[0], guest2[0], guest3[0]];
var day2RSVP = [guest1[1], guest2[1], guest3[1]];
var day3RSVP = [guest1[2], guest2[2], guest3[2]];
var day4RSVP = [guest1[3], guest2[3], guest3[3]];
var day5RSVP = [guest1[4], guest2[4], guest3[4]];

for(let i = 0; i < day1RSVP.length; i++) {
   day1.push(day1RSVP[i]);
   console.log(day1);
}
for(let i = 0; i < day2RSVP.length; i++) {
   day2.push(day2RSVP[i]);
   console.log(day2);
}
for(let i = 0; i < day3RSVP.length; i++) {
   day3.push(day3RSVP[i]);
   console.log(day3);
}
for(let i = 0; i < day4RSVP.length; i++) {
   day4.push(day4RSVP[i]);
   console.log(day4);
}
for(let i = 0; i < day5RSVP.length; i++) {
   day5.push(day5RSVP[i]);
   console.log(day5);
}

         */


    }
}