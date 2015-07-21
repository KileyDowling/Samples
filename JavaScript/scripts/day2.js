//FUNCTION EXPRESSIONS
//sayHi();
//sayHello();  does not work, must declare function expressions prior to use

function sayHi() {
	alert("Hi");
} 

var sayHello;
var isWelcome = true;
if(!isWelcome) {
	sayHello = function () {
		alert("Hello");
	} 
}else {
	sayHello = function() {
		alert("Welcome");
	}
}
//sayHello();

//-----------------------------------------------------------------
// RECURSION
function factorial(num) {
	if(num <=1){
		return 1;
	} else {
		return num * factorial(num-1);
	}
}

//alert(factorial(5));

//-----------------------------------------------------------------
// CLOSER -- function that has access to another functions variables from another function scope

function createComparisonFunction(propertyName) {
	return function(object1,object2){
		var value1 = object1[propertyName];
		var value2 = object1[propertyName];
		if(value1<value2) {
			return -1;
		} else if(value1 > value2) {
			return 1;
		} else {
			return 0;
		}
	};
}


//-----------------------------------------------------------------
// THIS
var name = "The Window";
var object = {
		name: "My Object", 
		getNameFunc : function() {
			var that = this;
			return function() {
				return that.name;
			};
		}
};

//alert(object.getNameFunc()());

//-----------------------------------------------------------------
//mimicking block scope
function outputNumbers(count) {
	(function () {
		for (var i=0;i<count;i++) {
			alert(i);
		}
	})();
	alert(i);  
}
//outputNumbers(10);
//'i' will be undefined, undefined in an alert blows  up.

//-----------------------------------------------------------------
// Using this to mimic private and public members; creating private fields in JS
function Person(name) {
	this.getName = function() {
		return name;
	};
	this.setName = function(value) {
		name = value;
	};
}
var person = new Person('Victor');
alert(person.getName());
person.setName('Kiwi');
alert(person.getName());
alert(person.name);