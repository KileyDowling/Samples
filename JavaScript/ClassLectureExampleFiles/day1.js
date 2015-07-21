//day1.js

// LECTURE 1 - Introduction
function sayHi() {
	// alert is our way of displaying messages to the user
	// this will display a message box to the user once executed
	alert("Hello World!");
}

if(MODE == "intro"){
	sayHi();
}

// LECTURE 2 - Data Types
// you can declare the variable in one line
// set in another line
var message;
// variables are loosely typed and can hold any data type
message = "hello world!";
// we can even switch data types on the fly
// below we change string to number
message = 100;
// changing types like this is not best practice

// you can also omit the var declaration
message2 = "Hello";

// to declare multiple variables, separate with a comma
var var1 = "hello",
	var2 = 100,
	var3 = false;
// new lines are not required but make reading easier

// Javascript provides a typeof function to get the current type 
// held in a variable. The function returns one of 6 types
var unused;
var isBool = true;
var string = "string value";
var num = 100;
var obj = new Object();
var func = function(){alert("function");}

var lecture2 = "Data Types = \n" +
	typeof(unused) + "\n" +
	typeof(isBool) + "\n" +
	typeof(string) + "\n" +
	typeof(num) + "\n" +
	typeof(obj) + "\n" +
	typeof(func);

if (MODE == "datatypes"){
	alert(lecture2);
}

// undefined is primarily for comparison
if (MODE == "datatypes"){
	alert(unused == undefined); // true
}
// undefined is not typically assigned.
// variables that are not assigned a value return undefined

// null - special data type representing empty object
// == undefined will return true
var newObj = null;
if (newObj != null){
	// do something with a person
}

// Boolean - only has values of true and false
// true != 1 and false != 0
if (MODE == "datatypes"){
	alert(Boolean(string)); // true
}

// Numbers - stores integers, floats, octal, hex
// holds values 5e-324 to 1.7976931348623157e308
// numbers outside of range to to infinity
// NaN = Not a Number
if (MODE == "datatypes"){
	alert(isNaN(string)); // true
}

// some interesting parsing for numbers
var num1 = parseInt("1234blue"); // 1234
var num2 = parseInt("0xA"); // 10 - hex
var num3 = parseFloat("123.2.2") // 123.2
if (MODE == "datatypes"){
	alert(num1 + "\n" + num2 + "\n" + num3);
}

// showing toString on a bool
if (MODE == "datatypes"){
	alert(isBool.toString()); // true
}

// LECTURE 3 - Operators, Statements and Functions
// ++ -- the increment decrement operators
var num4 = 2;
num4++; // 3
num4--; // 2
// - makes the number negative
-num4; // -2
-num4; // 2

// logical NOT 
if (MODE == "operators"){
	alert(!false);
}

var condition1 = true;
var condition2 = false;

// logical or (||)
if (condition1 || condition2){
	// one of them true
}
// logical and (&&)
if (condition1 && condition2){
	// both of them true
}

// basic math
8/5; // 1.6
8%5; // 3
8*5; // 40

// == and ====
if ('10' == 10){
	// this will be true
}
if ('10' === 10){
	// this code will not get executed
}

// conditional operator
var x = 10, y = 8;
var max = (x > y) ? x : y;
// is the same as
if (x>y){
	max = x;
} else {
	max = y;
}

// while and do while
var i = 0;
do {
	i += 2;
} while (i<10);

i = 0;
while (i<10){
	i += 2;
}

// for loop and a for in loop
var count = 10;
for(var j = 0; j < count; j++){
	
}

for (var propName in window){
	document.write(propName + "<br />");
}

// when looping dont forget break and continue

// switch statements
switch (i){
	case 25:
		// falls through to next
	case 35:
		break;
	default:
		// if no other case matches
}

// passing and using arguments
// also note the return
function sayHi (name, message) {
	alert("hello " + name + ", " + message);
	return true;
}

// overloading doesnt work in javascript
// this function is ignored
function doAdd(x, y){
	if (arguments.length == 1){
		alert(x + 10);
	} else if (arguments.length == 2) {
		alert(x + y);
	} else {
		alert(arguments.length);
	}
}

// this copy of funtion will be used
function doAdd(x, y){
	if (arguments.length == 1){
		alert(x + 20);
	} else if (arguments.length == 2) {
		alert(x + y);
	} else {
		alert(arguments.length);
	}
}

if (MODE == "operators"){
	// note we can pass any number of args. 
	doAdd(10);
	doAdd(30, 20);
	doAdd(10, 20, 30);
	//doAdd("pie");
}

// LECTURE 4 - Reference Types

// defining objects
var person = new Object();
person.name = "Jack";
person.age = 40;

var person2 = {
	name: "John",
	age: 36
};

function displayInfo(args) {
	var output = "";
	output += "Name: " + args.name + "\n";
	output += "Age: " + args.age + "\n";
	alert(output);
}

// diaplay object passed in
if (MODE == "reference"){
	displayInfo(person);
	displayInfo(person2);
	displayInfo({
		name: "Jeff"
	});

	// set the object to string and see what comes out
	alert(person.toString());
}

// declaring arrays
var arr = new Array();
var arr2 = new Array(20);
var arr3 = new Array("red", "blue", "green");
var arr4 = ["red", "blue", "green"];
var arr5 = [];

// manipulating arrays
var colors = ["red", "blue", "green"];
colors[2] = "black"; // green becomes black
colors[3] = "brown"; // brown is added to end
colors.length = 3; // brown is dropped off array

if (MODE == "reference"){
	// display second last element
	alert(colors[colors.length-1]);
	// display the array
	alert(colors.toString());
	alert(colors.valueOf());
	// join via | instead of ,
	alert(colors.join("|"));
}

// arrays can be stacks 
// you push to the top of the stack
colors.push("maroon");
// or pop off the top
var item = colors.pop();

// arrays can also be queues
// remove first element
var item2 = colors.shift();
//add to the beginning of array
colors.unshift("pink");

// create a new array adding to the end
var colors2 = colors.concat("yellow", ["white", "gray"]);

// return subset of elements
// first arg = start index
// second arg = ending (non-inclusive)
var colors3 = colors2.slice(2,4);

// remove and replace arrays
// first arg = starting index
// second arg = number of elements to remove
// additional args = add at index
var removed = colors2.splice(0,1);
removed = colors2.splice(1,10, "orange", "teal");

function compare(value1, value2){
	
}

// reordering the arrays
colors.sort();
// sort using a custom function
colors.sort(compare)

// test if something is an array
if (Array.isArray(colors)){
	
}

// Date types
// default Date() is current date time
var now = new Date();
var halloween = Date.parse("10/31/2015");

if (MODE == "reference"){
	alert(now);
	alert(now.toDateString());
	alert(halloween);
	alert(new Date(halloween).toDateString());
}

// regex - regular expressions
var text = 'cat, bat, sat, fat';

// pattern stating 3 character word ending in at
// find the first instance
var pattern = /.at/;

var matches = pattern.exec(text);
if (MODE == "reference"){
	//alert(matches.index);
	//alert(matches[0]);
	//alert(pattern.lastIndex);
}

// same as first pattern but now looking for all instances
var pattern2 = /.at/g;
var matches2 = pattern2.exec(text);
if (MODE == "reference"){
	//alert(matches2.index);
	//alert(matches2[0]);
	//alert(pattern2.lastIndex);
}
matches2 = pattern2.exec(text);
if (MODE == "reference"){
	//alert(matches2.index);
	//alert(matches2[0]);
	//alert(pattern2.lastIndex);
}

// validate the format of text
var text2 = "000-000-0000";
// pattern expects 000-00-0000
var pattern3 = /\d{3}-\d{2}-\d{4}/;
if (MODE == "reference"){
	if (pattern3.test(text2)) {
		alert("the pattern was a match");
	} else {
		alert("Expecting 000-00-0000");
	}
}

// functions
// declaring a simple function
function sum(x, y){
	if (arguments.length == 1) {
		return x + 10;
	} else {
		return x+y;
	}
}

// setting a variable to a function
var anotherSum = sum;
if (MODE == "reference"){
	alert(anotherSum(20, 40));

	// note that sum is just a pointer to the function
	sum = null;
	// because anothersum copied the pointer it still works
	alert(anotherSum(30,60));
}

// calling a function passed as an argument
function callSomeFunction(someFunction, someArgument){
	return someFunction(someArgument);
}

if (MODE == "reference"){
	alert(callSomeFunction(anotherSum, 10));
}

// calling the method from sort, the parameter is passed in
// sort calls a method and passes in 2 parameters
// hence our method createComparisonFunction returns the function sort
// calls passing in those two arguments
// sort calls function recursively for all pairings
function createComparisonFunction(propertyName){
	return function (object1, object2) {
		var value1 = object1[propertyName];
		var value2 = object2[propertyName];
		if (value1 < value2){
			return -1;
		} else if (value1 > value2){
			return 1;
		} else{
			return 0;
		}
	}
}
var data = [{name: 'Ben', age: 60}, {name: 'Bob', age: 20}, {name: "Bill", age: 32}];
data.sort(createComparisonFunction('age'));
if (MODE == "reference"){
	alert(data[0].name);
}

// context of variables
// name is global and can be used in functions and outside
var name = "guild";
window.color = 'red';
var o = {color: 'blue'}

function sayColor(){
	if (MODE == "reference"){
		alert(name + " " + this.color);
	}
}

sayColor();
sayColor.call(this);
sayColor.call(window);
sayColor.call(o);
