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
*/
var abba = function(a,b) {
    return a+b+b+a;
}

alert(abba("Hi","Bye"));
alert(abba("Yo","Alice"));
alert(abba("What","Up"));



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

