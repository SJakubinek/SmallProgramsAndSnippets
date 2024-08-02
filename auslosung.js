// Group Draw
// Just a small program for drawing groups
// eg creating Soccer Worldcups for gaming

// Usage: Just type in all the names you want to pick from
// Set numberNeeded to match your need of how many names you need
// So you are able to have a large group, but only pick some of them
// Start at command line with node auslosung.js
// (You need to have node installed!)

let names = ["Anton","Benjamin","Benni","Björn","Charlie","Emil","Eva","Felix",
   "James","Lucas","Maurice","Oliver","Olivia","Olli","Otto","Sina","Sören",
   "Tony","Willi","William"];
let namesString = "";
const numbersNeeded = 10;
let i = 0;

while (i < numbersNeeded)
{
   const rnd = Math.floor(Math.random() * names.length);
   namesString += names[rnd] + "\n\r";

   names.splice(rnd, 1);
   i++;
}

console.log(namesString);