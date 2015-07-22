// day2.js

// function declarations are read in before code executes
sayHi();
function sayHi(){
	alert("Hi!");
}

// function expressions are not read in before code executes
// like a variable, it must be declared before use
/* this fails
sayHello();
var sayHello = function() {
	alert("Hello!")
}
*/

// function expressions allow you to dynamically set the function
var sayHello;
var isWelcome = true;
if (!isWelcome){
	sayHello = function() {
		alert("Hello");
	}
} else {
	sayHello = function() {
		alert("Welcome");
	}
}
sayHello();

// recursive function
function factorial(num){
	//notice the if statement ensures we dont have an infinite loop since the function is calling itself
	if (num <= 1){
		return 1;
	} else {
		return num * factorial(num-1);
	}
}
var sum = factorial(5);
alert(sum);

// closures - functions that have access to another function's scope
// note the scope of this... 
// in this case it's window
var name = 'The Window';
var object = {
	name: 'My Object',
	
	getNameFunc : function() {
		return function(){
			return this.name;
		}
	}
};
alert(object.getNameFunc()());

// now check this out...
var object2 = {
	name: 'My Object2',
	
	getNameFunc : function() {
		// accessing this within the function and then passing it down provides the proper context
		var that = this;
		
		return function(){
			return that.name;
		}
	}
};
alert(object2.getNameFunc()());

// in the example from yesterday we see the same trick with scope
function createComparisonFunction(propertyName){
	// because we pass in propertyName, we can use it in the returned function
	return function(object1, object2){
		var value1 = object1[propertyName];
		var value2 = object2[propertyName];
		if (value1<value2){
			return -1;
		} else if (value1 > value2){
			return 1;
		} else {
			return 0;
		}
	};
}
var data = [{name: 'Ben', age: 60}, {name: 'Bob', age: 20}, {name: "Bill", age: 32}];
data.sort(createComparisonFunction('age'));

// you can use this to mimic private
function Person(name){
	this.getName = function(){
		return name;
	};
	this.setName = function(value){
		name = value;
	}
}
var person = new Person("Steve");
alert(person.getName());
person.setName("Woz");
alert(person.getName());
alert(person.name); // cannot access name, it's never declared and therefore only accessible in the function person

// higher order functions or functions that accept another function
var pets = [
	{name: "Garfield", type: "cat", age: 20},
	{name: "Odie", type: "dog", age: 15},
	{name: "Toto", type: "dog", age: 51},
	{name: "Zazzles", type: "cat", age: 10}
];
var dogs = pets
	// executes on each member of the array
	// only items that return true will be returned.
	.filter(function(pet) {
		return pet.type === 'dog';
	
	})
	// executes for each member of the array
	// returns what can be seen in alert
	.map(function(pet) {
		return pet.name;
	})
	// executes for each member of the array
	// returns the value from the prior run. 
	.reduce(function(runningTotal, age) {
		return (runningTotal || 0) + age;
});
alert(dogs);

/* COMING SOON!!!
var totalDogYears = pets
	.filter((pet) => pet.type === 'dog')
	.map((pet) => pet.age)
	.reduce((runningTotal, age) => (runningTotal || 0) + age);
alert(totalDogYears);
*/

// Browser Object Model
//alert(window.name); // Bob
//sayName(); // Bob
//window.sayName(); // Bob

//opening a new window
var swc = window.open("http://www.swcguild.com", "_black");
if (swc == null){
	alert("The popup was blocked");
}

//swc.close(); // window closes and you never see it

// timeout that will run on expiration
var timeoutId = setTimeout(function(){
	alert("Time's up!");
}, 1000); // 1000 = 1 second

//clearTimeout(timeoutId); // cancel the timeout

// interval running
// run a piece of code every 'x'
var num = 0;
var max = 5;
var interval = null;
function incrementNumber(){
	num++;
	if (num == max){
		clearInterval(interval);
		alert("Done");
	}
}
interval = setInterval(incrementNumber, 500);

// different type of message box \ alert
confirm("Are you sure?");

//find(); // display searchbox
//print(); // should print the page

// change the current location
//window.location = "http://www.swcguild.com";

// FAILS the page hasn't been drawn yet. See the inline code... 
var div = document.getElementById("place");
//alert(div);