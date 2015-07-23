/* -------- STRINGS #24:
Given a string, if the first or last chars are 'x', return the string without those 'x' chars, and otherwise return the string unchanged. 

StripX("xHix") -> "Hi"
StripX("xHi") -> "Hi"
StripX("Hxix") -> "Hxi" */

function StripX(str) {
	var indexOfX = str.indexOf("x");
	var lastLetter = str.slice(-1)
	if(indexOfX == 0 && lastLetter == "x") {
		return str.slice(1,str.length-1);
	} else if(indexOfX != 0 && lastLetter == "x") {
		return str.slice(0,str.length-1);
	} else {
		return str.slice(1,str.length);
	}
}
console.log(StripX("xHix"));
console.log(StripX("xHi"));
console.log(StripX("Hxix"));


/* -------- STRINGS #23:
Given a string, return a version without the first 2 chars. Except keep the first char if it is 'a' and keep the second char if it is 'b'. 
The string may be any length.

TweakFront("Hello") -> "llo"
TweakFront("away") -> "aay"
TweakFront("abed") -> "abed"

function TweakFront(str) {
	var firstLetter = str.slice(0,1);
	var secondLetter = str.slice(1,2);
	if(firstLetter !="a" && secondLetter !="b") {
		return str.slice(2,str.length);
	} else if(firstLetter =="a" && secondLetter =="b") {
		return str;
	} else if(firstLetter =="a") {
		return str.slice(0,1) + str.slice(2);
	} else {
		return str.slice(1);
	}
}

console.log(TweakFront("Hello"));
console.log(TweakFront("away"));
console.log(TweakFront("abed"));
console.log(TweakFront("mbed")); */

/* -------- STRINGS #22:
Given two strings, append them together (known as "concatenation") and return the result.
 However, if the strings are different lengths, omit chars from the longer string 
 so it is the same length as the shorter string. So "Hello" and "Hi" yield "loHi". The strings may be any length. 

MinCat("Hello", "Hi") -> "loHi"
MinCat("Hello", "java") -> "ellojava"
MinCat("java", "Hello") -> "javaello"

function MinCat(strA, strB) {
	var aLength = strA.length;
	var bLength = strB.length;
	if(aLength == bLength) {
		return strA+strB;
	} else if(aLength > bLength) {
		var diff = aLength - bLength;
		var newA = strA.slice(diff, aLength);
		return newA + strB;
	} else {
		var diff = bLength-aLength;
		var newB = strB.slice(diff, bLength);
		return strA + newB;
	}
}
console.log(MinCat("Hello", "Hi"));
console.log(MinCat("Hello", "java"));
console.log(MinCat("java", "Hello"));
*/

/* -------- STRINGS #21:
Given a string, return true if the first 2 chars in the string also appear at the end of the string, such as with "edited". 

FrontAgain("edited") -> true
FrontAgain("edit") -> false
FrontAgain("ed") -> true 

function FrontAgain(str) {
	var first2 = str.slice(0,2);
	var last2 = str.slice(str.length-2,str.legnth);
	if(first2 == last2) {
		return true;
	} else {
		return false;
	}
}

console.log(FrontAgain("edited"));
console.log(FrontAgain("edit"));
console.log(FrontAgain("ed")); */

/* -------- STRINGS #20:
Given a string of any length, return a new string where the last 2 chars, if present, are swapped, so "coding" yields "codign". 

SwapLast("coding") -> "codign"
SwapLast("cat") -> "cta"
SwapLast("ab") -> "ba"

function swapLast(str) {
	if(str.length > 1)
	{
		var newStr = str.slice(0,str.length-2);
		newStr += str.slice(str.length-1); 
		newStr += str.slice(str.length-2, str.length-1);

		return newStr;
	}
}

console.log(swapLast("coding"));
console.log(swapLast("cat"));
console.log(swapLast("ab")); */

/* -------- STRINGS #19:

Given two strings, append them together (known as "concatenation") and return the result. 
However, if the concatenation creates a double-char, then omit one of the chars, so "abc" and "cat" yields "abcat". 

ConCat("abc", "cat") -> "abcat"
ConCat("dog", "cat") -> "dogcat"
ConCat("abc", "") -> "abc" 

var conCat = function (strA, strB) {
	if(strA.slice(-1) != strB.slice(0,1))
	{
		return strA + strB;
	}
	else 
	{
		return strA.slice(0,strA.length-1) + strB;
	}
}

console.log(conCat("abc", "cat"));
console.log(conCat("dog", "cat"));
console.log(conCat("abc", ""));
*/
/* -------- STRINGS #18:
Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, so "yo" and "java" yields "ya". 
If either string is length 0, use '@' for its missing char. 

LastChars("last", "chars") -> "ls"
LastChars("yo", "mama") -> "ya"
LastChars("hi", "") -> "h@"

var lastChars = function(str1,str2)
{
	if(str1.length > 0 && str2.length > 0)
	{
		return str1.substring(0,1) + str2.slice(-1);
	} else if(str1.length == 0 && str2.length != 0) {
		return "@" + str2.slice(-1);
	} else if (str1.length != 0 && str2.length == 0) {
		return str1.substring(0,1) +"@";
	} else {
		return "@" + "@";
	}
}
console.log(lastChars("last", "chars"));
console.log(lastChars("yo", "mama"));
console.log(lastChars("hi", ""));

*/
/* -------- STRINGS #17:
Given a string, return a string length 2 made of its first 2 chars. If the string length is less than 2, use '@' for the missing chars. 

AtFirst("hello") -> "he"
AtFirst("hi") -> "hi"
AtFirst("h") -> "h@"
var AtFirst = function (str) {
	if(str.length < 2)
	{
		return str + "@";
	} else {
		return str.substring(0,2);
	}
}
console.log(AtFirst("hello"));
console.log(AtFirst("hi"));
console.log(AtFirst("h"));
*/
/* -------- STRINGS #16:
Given a string, return true if "bad" appears starting at index 0 or 1 in the string, 
such as with "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0.

HasBad("badxx") -> true
HasBad("xbadxx") -> true
HasBad("xxbadxx") -> false 
var hasBad = function(str) {
	if(str.substring(0,3) == "bad" || str.substring(1,4) == "bad")
	{
		return true;
	} else {
		return false;
	}
}

console.log(hasBad("badxx"));
console.log(hasBad("xbadxx"));
console.log(hasBad("xxbadxx"));
*/

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
