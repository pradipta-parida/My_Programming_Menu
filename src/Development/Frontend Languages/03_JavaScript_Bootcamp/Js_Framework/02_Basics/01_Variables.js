/* 

In, VS code we can use ctrl + / to comment any JS code.

; is optional at the end of line of JS code but its a best practice to follow

*/

const accountId = 14354
/* accountId = 5
const keyword can't be changed as its constant */


/*
let and var keyword are used for variables.

var is now been phased out and no longer in use of todays modern js world.
so,prefer not to use var because of issue in block scope and functional scope
*/
let accountEmail = "pradipta28.parida@gmail.com"
accountEmail = "ghp@gmail.com"

// JScript is a very loose language, we can declare a variable without any keyword, but it isn't a best practice to do it

let accountState; // If you don't declare value to variable then the default value is Undefined

var accountPassword = "12345"
accountPassword = "22222"
 

accountCity = "Bhubaneswar"
accountCity = "Kolkata"

// To display only one value into the console
console.log(accountId); 

//To display multiple values into the console
console.table([accountId, accountEmail, accountPassword, accountCity, accountState]);
