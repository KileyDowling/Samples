//functions

window.color = 'red';
var o = {color: 'blue'}

function sayColor() {
	console.log(this.color);
}

sayColor();
sayColor.call(this);
sayColor.call(window);
sayColor.call(o);
//-------------------------------------------
/* function sum(x) {
	return x+10;
}
//console.log(sum(5,5));

var anotherSum = sum;
//console.log(anotherSum(25,10)); 

function callSomeFunction(someFunction, someArguement) {
	return someFunction(someArguement);
}

//console.log(callSomeFunction(sum, 10)); 

function createComparison(propertyName){
	return function (object1, object2) {
		var value1 = object1[propertyName];
		var value2 = object2[propertyName];
		if(value1 < value2) {
			return -1;
		} else if (value1 > value2)	{
			return 1;
		} else {
			return 0;
		}
	}
}

var data = [{name: 'Victor', age: 33}, {name: 'Liliana', age: 13},{name: 'Christian', age: 11}];
data.sort(createComparison('age'));
console.log(data[0].name); 

/*var now = new Date();

alert(now.toDateString()); 

var text = 'cat, bat, sat, fat';

var pattern = /.at/;

var matches = pattern.exec(text);

console.log(matches.index);
console.log(matches[0]);
console.log(pattern.lastIndex); 


var text2 = "000-00-0000";
var pattern3 = /\d{3}-\d{2}-\d{4}/;
if(pattern3.test(text2)) {
	console.log("the pattern was a match");
}
var text4 = "000-000-0000";
var pattern4 = /\d{3}-\d{2}-\d{4}/;
if(pattern4.test(text4)) {
	console.log("the pattern was a match");
}
else{
	console.log("fail");
} */