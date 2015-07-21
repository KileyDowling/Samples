/* -------- STRINGS #15:
Given a string and an index, return a string length 2 starting at the given index. 
If the index is too big or too small to define a string length 2, use the first 2 chars. The string length will be at least 2. 

TakeTwoFromPosition("java", 0) -> "ja"
TakeTwoFromPosition("java", 2) -> "va"
TakeTwoFromPosition("java", 3) -> "ja"

var TakeTwoFromPosition = function(str,n) {
	if(n > (str.length-2))
	{	
		return str.substring(0,2);			
	} else {
		return str.substring(n,n+2);
	}
} 
console.log(TakeTwoFromPosition("java", 0));
console.log(TakeTwoFromPosition("java", 2));
console.log(TakeTwoFromPosition("java", 3));
*/

/* -------- STRINGS #14:
Given a string and an int n, return a string made of the first and last n chars from the string. The string length will be at least n. 

FrontAndBack("Hello", 2) -> "Helo"
FrontAndBack("Chocolate", 3) -> "Choate"
FrontAndBack("Chocolate", 1) -> "Ce"

var frontAndBack = function(str,n) {
	var firstN = str.slice(0,n);
	var lastN = str.slice(-n, str.length);
	return firstN + lastN;
}

console.log(frontAndBack("Hello", 2));
console.log(frontAndBack("Chocolate", 3));
console.log(frontAndBack("Chocolate", 1));
*/
/* -------- STRINGS #13:

Given a string, return true if it ends in "ly". 

EndsWithLy("oddly") -> true
EndsWithLy("y") -> false
EndsWithLy("oddy") -> false

var EndsWithLy = function(str)
{
	if(str.substring(str.length-2, str.length)=== "ly")
	{
		return true;
	} else {
		return false;
	}
}
console.log(EndsWithLy("oddly"));
console.log(EndsWithLy("y"));
console.log(EndsWithLy("oddy"));
*/

/* -------- STRINGS #12:
Given a string of even length, return a string made of the middle two chars, so the string "string" yields "ri". 
The string length will be at least 2. 

MiddleTwo("string") -> "ri"
MiddleTwo("code") -> "od"
MiddleTwo("Practice") -> "ct"

var MiddleTwo = function(str) {
	if(str.length % 2 === 0)
	{
		var mid = str.length / 2;
		return str.substring((mid-1), (mid+1));
	}
}
console.log(MiddleTwo("string"));
console.log(MiddleTwo("code"));
console.log(MiddleTwo("Practice"));
*/

/* -------- STRINGS #11:
Given a string, return a string length 1 from its front, unless front is false,
 in which case return a string length 1 from its back. The string will be non-empty. 

TakeOne("Hello", true) -> "H"
TakeOne("Hello", false) -> "o"
TakeOne("oh", true) -> "o"

var TakeOne = function(str,fromFront){
	if(fromFront===true){
		return str.substring(0,1);
	} else {
		return str.slice(-1);
	}
}
console.log(TakeOne("Hello", true));
console.log(TakeOne("Hello", false));
console.log(TakeOne("oh", true));
*/

/* -------- STRINGS #10:
Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
The string length will be at least 2. 

RotateRight2("Hello") -> "loHel"
RotateRight2("java") -> "vaja"
RotateRight2("Hi") -> "Hi"

var rotateRight2 = function(str) {
	var right2 = str.slice(-2,str.length);
	return right2 + str.substring(0,(str.length-2));
}
console.log(rotateRight2("Hello"));
console.log(rotateRight2("java"));
console.log(rotateRight2("Hi"));
*/

/* -------- STRINGS #9:
Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. The string length will be at least 2. 

Rotateleft2("Hello") -> "lloHe"
Rotateleft2("java") -> "vaja"
Rotateleft2("Hi") -> "Hi"

var rotateLeft2 = function(str) {
	var first2 = str.substring(0,2);
	return str.slice(2,str.length) + first2;
}
console.log(rotateLeft2("Hello"));
console.log(rotateLeft2("java"));
console.log(rotateLeft2("Hi"));
*/

/* -------- STRINGS #8:
Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside. The strings will not be the same length, but they may be empty (length 0). 

LongInMiddle("Hello", "hi") -> "hiHellohi"
LongInMiddle("hi", "Hello") -> "hiHellohi"
LongInMiddle("aaa", "b") -> "baaab"

var longInMiddle = function (a,b) {
	if(a.length > b.length)
	{
		return b+a+b;
	} else {
		return a+b+a;
	}
}
console.log(longInMiddle("Hello", "hi"));
console.log(longInMiddle("hi", "Hello"));
console.log(longInMiddle("aaa", "b"));
*/
/* -------- STRINGS #7:
Given a string, return a version without the first and last char, so "Hello" yields "ell". The string length will be at least 2. 

TrimOne("Hello") -> "ell"
TrimOne("java") -> "av"
TrimOne("coding") -> "odin"

var trimOne = function(str) {
    return str.substring(1,(str.length -1));
} 

console.log(trimOne("Hello"));
console.log(trimOne("java"));
console.log(trimOne("coding")); */

/* -------- STRINGS #6:
Given a string of even length, return the first half. So the string "WooHoo" yields "Woo". 

FirstHalf("WooHoo") -> "Woo"
FirstHalf("HelloThere") -> "Hello"
FirstHalf("abcdef") -> "abc"

var firstHalf = function(str) {
    if(str.length % 2 == 0)
    {
        var halfLength = str.length / 2;
        return str.substring(0,halfLength);
    }
}

alert(firstHalf("WooHoo"));
alert(firstHalf("HelloThere"));
alert(firstHalf("abcdef"));
*/

/* -------- STRINGS #5:
Given a string, return a new string made of 3 copies of the last 2 chars of the original string. The string length will be at least 2. 

MultipleEndings("Hello") -> "lololo"
MultipleEndings("ab") -> "ababab"
MultipleEndings("Hi") -> "HiHiHi"

public string MultipleEndings(string str) {


var multipleEndings = function(str) {
    var newStr = str.substring(str.length-2,str.length);
    return newStr+newStr+newStr;
}


alert(multipleEndings("Hello"));
alert(multipleEndings("ab"));
alert(multipleEndings("Hi"));
*/

/* -------- STRINGS #4:
Given an "out" string length 4, such as "<<>>", and a word, return a new string where the word is in the middle of the out string, e.g. "<<word>>".

Hint: Substrings are your friend here 

InsertWord("<<>>", "Yay") -> "<<Yay>>"
InsertWord("<<>>", "WooHoo") -> "<<WooHoo>>"
InsertWord("[[]]", "word") -> "[[word]]"

var insertWord = function(container,word) {
    return container.slice(0,2)+word+container.slice(2,4);
}
alert(insertWord("<<>>", "Yay"));
alert(insertWord("<<>>", "WooHoo"));
alert(insertWord("[[]]", "word"));
*/

/* -------- STRINGS #3:
The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. In this example, the "i" tag makes <i> and </i> which surround the word "Yay". Given tag and word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>". 

MakeTags("i", "Yay") -> "<i>Yay</i>"
MakeTags("i", "Hello") -> "<i>Hello</i>"
MakeTags("cite", "Yay") -> "<cite>Yay</cite>"


var makeTags = function (tag,content) {
    return "<"+tag+">"+content+"</"+tag+">";
}

alert(makeTags("i","Yay"));
alert(makeTags("i","Hello"));
alert(makeTags("cite","Yay"));
*/

/* -------- STRINGS #2: 
Given two strings, a and b, return the result of putting them together in the order abba, e.g. "Hi" and "Bye" returns "HiByeByeHi". 

Abba("Hi", "Bye") -> "HiByeByeHi"
Abba("Yo", "Alice") -> "YoAliceAliceYo"
Abba("What", "Up") -> "WhatUpUpWhat"

var abba = function(a,b) {
    return a+b+b+a;
}

alert(abba("Hi","Bye"));
alert(abba("Yo","Alice"));
alert(abba("What","Up"));
*/


/* -------- STRINGS #1:
Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 

SayHi("Bob") -> "Hello Bob!"
SayHi("Alice") -> "Hello Alice!"
SayHi("X") -> "Hello X!"

var sayHi = function (name) {
    alert("Hello " + name);
}

sayHi("Bob");
sayHi("Alice");
sayHi("X"); */
