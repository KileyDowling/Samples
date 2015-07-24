/* Loops #17:
Given an array of ints, return true if it contains a 2, 7, 1 pattern
 -- a value, followed by the value plus 5, followed by the value minus 1.

Pattern51({1, 2, 7, 1}) -> true
Pattern51({1, 2, 8, 1}) -> false
Pattern51({2, 7, 1}) -> true

function Pattern51(numbers) {
	var counter = 0;
	while(counter < numbers.length) {
		var plus5 = numbers[counter]+5;
		var plus1 = numbers[counter]-1;
		if(((numbers[counter+1]) == plus5) && (numbers[counter+2]==plus1)) 
		{
			return true;
		}
		counter++;
	}
return false;
}
console.log(Pattern51([1, 2, 7, 1]));
console.log(Pattern51([1, 2, 8, 1]));
console.log(Pattern51([2, 7, 1]));
console.log(Pattern51([5, 10, 4])); */

/* Loops #16:
Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. Return true if the array does not contain any triples. 

NoTriples({1, 1, 2, 2, 1}) -> true
NoTriples({1, 1, 2, 2, 2, 1}) -> false
NoTriples({1, 1, 1, 2, 2, 2, 1}) -> false

function  NoTriples(numbers) {
	var counter = 0;
	while(counter < numbers.length) {
		if((numbers[counter]==numbers[counter+1]) && (numbers[counter+1]==numbers[counter+2]))
		{
			return false;
		} 
		counter++;
	}
	return true;
} 
console.log(NoTriples([1, 1, 2, 2, 1]));
console.log(NoTriples([1, 1, 2, 2, 2, 1]));
console.log(NoTriples([1, 1, 1, 2, 2, 2, 1])); */

/* Loops #15: 
Given an array of ints, return the number of times that two 6's are next to each other in the array. 
Also count instances where the second "6" is actually a 7. 
Array667({6, 6, 2}) -> 1
Array667({6, 6, 2, 6}) -> 1
Array667({6, 7, 2, 6}) -> 1 

function Array667(numbers) {
	var counter = 0;
	var found6 = 0;
	while(counter < numbers.length) {
		if((numbers[counter] == 6) && (numbers[counter+1]==6) || (numbers[counter+1]==7))
		{
			found6++;
		}
		counter ++;
	}
	return found6;
}
console.log(Array667([6, 6, 2]));
console.log(Array667([6, 6, 2, 6]));
console.log(Array667([6, 7, 2, 6]));
console.log(Array667([6, 7, 2, 6,6])); */

/* Loops #14:
Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, 
but the "a" can be any char. The "yak" strings will not overlap. 

DoNotYak("yakpak") -> "pak"
DoNotYak("pakyak") -> "pak"
DoNotYak("yak123ya") -> "123ya" 

function DoNotYak(str) {
	var result = "";
	var n = str.indexOf("yak");
	if(n > -1) {
		for(var i=0; i < str.length-3; i++) {		
		if((str[i] == "y") && (str[i+1] ="a") && (str[i+2] =="k")) {
			result += str.substring(i+3);
			break;
		} else {
			result += str[i];
		}
	}
}	
	return result;
} 
console.log(DoNotYak("yakpak"));
console.log(DoNotYak("pakyak"));
console.log(DoNotYak("yak123ya")); */

/* Loops #13:
Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien". 

AltPairs("kitten") -> "kien"
AltPairs("Chocolate") -> "Chole"
AltPairs("CodingHorror") -> "Congrr"

function AltPairs(str) {
	var newStr ="";
	for (var i = 0; i < str.length; i += 4) {
		newStr += str.substring(i, Math.min(str.length, i + 2));          
	}
	return newStr;
} 

console.log(AltPairs("kitten"));
console.log(AltPairs("Chocolate"));
console.log(AltPairs("CodingHorror")); */

/* Loops #12:
Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end should not be removed. 

StringX("xxHxix") -> "xHix"
StringX("abxxxcd") -> "abcd"
StringX("xabxxxcdx") -> "xabcdx"

function StringX(str) {
	var firstX = str.indexOf("x");
	var lastLetter = str.slice(-1);
	var newStr = "";
	for(var i in str)
	{
		if(firstX == 0 && i == 0)
		{
			newStr += "x";
		}
		if((str[i] !="x"))
			{
				newStr += str[i];
			}
		if(lastLetter == "x" && i == str.length-1)
			{
				newStr += "x";
			}
	}

	return newStr;	
}

console.log(StringX("xxHxix"));
console.log(StringX("abxxxcd"));
console.log(StringX("xabxxxcdx")); */

/* Loops #11:
Given 2 strings, a and b, return the number of the positions where they contain the same length 2 substring. 
So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" substrings appear in the same place in both strings. 

SubStringMatch("xxcaazz", "xxbaaz") -> 3
SubStringMatch("abc", "abc") -> 2
SubStringMatch("abc", "axc") -> 0 

function SubStringMatch(strA, strB) {
	var aLength = strA.length;
	var count = 0;
	for(var i = 0; i < aLength-1; i++)
	{
		if((strA[i] === strB[i]) && (strA[i+1] === strB[i+1]))
			{
				count++;
			}
		}
	return count;
}
console.log(SubStringMatch("xxcaazz", "xxbaaz"));
console.log(SubStringMatch("abc", "abc"));
console.log(SubStringMatch("abc", "axc")); */

/* Loops #10:
Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere. 

Array123({1, 1, 2, 3, 1}) -> true
Array123({1, 1, 2, 4, 1}) -> false
Array123({1, 1, 2, 1, 2, 3}) -> true

function Array123(numbers) {
	var found1 = numbers.indexOf(1);
	var count = found1;
	while (count < numbers.length)
	{
		var indexOf2 = count +  1;
		var indexOf3 = count + 2;
		if(numbers[indexOf2] == 2 && numbers[indexOf3] == 3)
		{
			return true;
		}
		count++;
	}
	return false;
}

console.log(Array123([1, 1, 2, 3, 1]));
console.log(Array123([1, 1, 2, 4, 1]));
console.log(Array123([1, 1, 2, 1, 2, 3])); */

/* Loops #9:
Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4. 

ArrayFront9({1, 2, 9, 3, 4}) -> true
ArrayFront9({1, 2, 3, 4, 9}) -> false
ArrayFront9({1, 2, 3, 4, 5}) -> false 

function ArrayFront9(numbers) {
	var first4 = numbers.slice(0,4);
	for(var i in first4)
	{
		if(first4[i] == 9)
		{
			return true;
		}
	}
	return false;
}
console.log(ArrayFront9([1, 2, 9, 3, 4]));
console.log(ArrayFront9([1, 2, 3, 4, 9]));
console.log(ArrayFront9([1, 2, 3, 4, 5]));
console.log(ArrayFront9([1, 2]));
console.log(ArrayFront9([1, 9, 3])); */


/* Loops #8:
Given an array of ints, return the number of 9's in the array. 

Count9({1, 2, 9}) -> 1
Count9({1, 9, 9}) -> 2
Count9({1, 9, 9, 3, 9}) -> 3 

function Count9 (numbers) {
	var count = 0;
	var found9=0;
	
	while(count < numbers.length) {
		if(numbers[count] == 9)
		{
			found9++;
		}
		count++;
	}
	return found9;
}
console.log(Count9([1,2,9]));
console.log(Count9([1, 9, 9]));
console.log(Count9([1, 9, 9, 3, 9])); */

/* Loops #7:
Given a string, return the count of the number of times that a substring length 2 appears in the string 
and also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring). 

CountLast2("hixxhi") -> 1
CountLast2("xaxxaxaxx") -> 1
CountLast2("axxxaaxx") -> 2 

function CountLast2(str) {
	var last2 = str.slice(-2);
	var count = 0;
	var found2 = 0;
	while(count < str.length-2){
		if(str.slice(count, count+2) == last2)
		{
			found2++;
		}
		count++;
	}
	return found2;
}
console.log(CountLast2("hixxhi"));
console.log(CountLast2("xaxxaxaxx"));
console.log(CountLast2("axxxaaxx")); */

/* Loops #6:
Given a non-empty string like "Code" return a string like "CCoCodCode".  (first char, first two, first 3, etc)

StringSplosion("Code") -> "CCoCodCode"
StringSplosion("abc") -> "aababc"
StringSplosion("ab") -> "aab"

function StringSplosion(str) {
	var count=0;
	var num = 0;
	var newStr ="";
	while(count < str.length+1){
		newStr +=str.slice(num,count);
		count++;
	}
	return newStr;
}
console.log(StringSplosion("Code"));
console.log(StringSplosion("abc"));
console.log(StringSplosion("ab")); */

/* Loops #5:
Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo". 

EveryOther("Hello") -> "Hlo"
EveryOther("Hi") -> "H"
EveryOther("Heeololeo") -> "Hello" 

function EveryOther (str){
	var count  = 0;
	var newStr="";
	while(count < str.length){
		newStr += str.slice(count, count+1);
		count +=2;
	}
	return newStr;
}
console.log(EveryOther("Hello"));
console.log(EveryOther("Hi"));
console.log(EveryOther("Heeololeo")); */


/* Loops #4:
Given a string, return true if the first instance of "x" in the string is immediately followed by another "x". 

DoubleX("axxbb") -> true
DoubleX("axaxxax") -> false
DoubleX("xxxxx") -> true

function DoubleX(str) {
	var length = str.length;
	var firstX = str.indexOf("x");
		if(str.slice(firstX, firstX+1)=="x" && (str.slice(firstX+1,firstX+2) == "x"))
		{
			return true;
		}  else {
			return false;
		}
} 
console.log(DoubleX("axxbb"));
console.log(DoubleX("axaxxax"));
console.log(DoubleX("xxxxx"));  */

/* Loops #3: 
Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx". 

CountXX("abcxx") -> 1
CountXX("xxx") -> 2
CountXX("xxxx") -> 3 

function CountXX(str) {
	var length = str.length;
	var firstX = str.indexOf("x");
	var count = 0;
	var countX = 0;
	
	while(count < length){
		if(str.slice(firstX+count, firstX+count+1)=="x" && (str.slice(firstX+count+1,firstX+count+2) == "x"))
		{
			countX++;
		}
		count++;
	}
	return countX;
}

console.log(CountXX("abcxx"));
console.log(CountXX("xxx"));
console.log(CountXX("xxxx")); 
console.log(CountXX("aaxxxxaa")); */

/* Loops #2: 
Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or whatever is there 
if the string is less than length 3. Return n copies of the front; 

FrontTimes("Chocolate", 2) -> "ChoCho"
FrontTimes("Chocolate", 3) -> "ChoChoCho"
FrontTimes("Abc", 3) -> "AbcAbcAbc"

function FrontTimes(str, n) {
	if(str.length > 2 && n > 0) {
		var first3 = str.slice(0,3);
		var count = 0
		var newStr ="";
		while(count < n)
		{
			newStr += first3;
			count ++;
		}
		return newStr;
	}
}

console.log(FrontTimes("Chocolate", 2));
console.log(FrontTimes("Chocolate", 3));
console.log(FrontTimes("Abc", 3));
*/


/* Loops #1: 
Given a string and a non-negative int n, return a larger string that is n copies of the original string. 

StringTimes("Hi", 2) -> "HiHi"
StringTimes("Hi", 3) -> "HiHiHi"
StringTimes("Hi", 1) -> "Hi" 

function StringTimes(str, n) {
 if(n > 0) {
	 var newStr ="";
	 var count = 0;
	 while(count < n) {
		 newStr += str;
		 count ++;
	 }
	 return newStr;
 }
}
console.log(StringTimes("Hi", 2));
console.log(StringTimes("Hi", 3));
console.log(StringTimes("Hi", 1));  */