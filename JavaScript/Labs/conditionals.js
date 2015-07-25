/* Conditionals #27:
Given a non-empty string and an int N, return the string made starting with char 0, 
and then every Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more. 

EveryNth("Miracle", 2) -> "Mrce"
EveryNth("abcdefg", 2) -> "aceg"
EveryNth("abcdefg", 3) -> "adg" 

function EveryNth(str, n) {
	var newStr = str.slice(0,1);
	for(var i=n; i < str.length; i+=n) {
		newStr += str[i];
	}
	return newStr;
}
console.log(EveryNth("Miracle", 2));
console.log(EveryNth("abcdefg", 2));
console.log(EveryNth("abcdefg", 3)); */

/* Conditionals #26:
Given a string, return a new string where the last 3 chars are now in upper case. 
If the string has less than 3 chars, uppercase whatever is there. 

EndUp("Hello") -> "HeLLO"
EndUp("hi there") -> "hi thERE"
EndUp("hi") -> "HI" 

function EndUp(str) {
	if(str.length < 4) {
		return str.toUpperCase();
	} else {
		return str.slice(0, str.length-3)+str.slice(-3).toUpperCase();
	}
}
console.log(EndUp("Hello"));
console.log(EndUp("hi there"));
console.log(EndUp("hi")); */

/* Conditionals #25:
Return true if the given string contains between 1 and 3 'e' chars. 

GotE("Hello") -> true
GotE("Heelle") -> true
GotE("Heelele") -> false 

function GotE(str) {
	var foundE = str.match(/e/g);
	if(foundE != null) {
	var n = foundE.length;
		if(n < 4 && n > 0) {
			return true;
		}
	} return false;
} 
console.log(GotE("Hello"));
console.log(GotE("Heelle"));
console.log(GotE("Heelele"));
console.log(GotE("no")); */


/* Conditionals #24: 
Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie. 

Closer(8, 13) -> 8
Closer(13, 8) -> 8
Closer(13, 7) -> 0 

function Closer(a, b) {
	var from10A = Math.abs((a+(-10)));
	var from10B = Math.abs((b+(-10)));
	if(from10A < from10B) {
		return a;
	} else if(from10A > from10B) {
		return b;
	} return 0;
}
console.log(Closer(8, 13));
console.log(Closer(13,8));
console.log(Closer(13,7)); */

/* Conditionals #23: 
Given three int values, a b c, return the largest. 
Max(1, 2, 3) -> 3
Max(1, 3, 2) -> 3
Max(3, 2, 1) -> 3 

function Max(a, b, c) {
	if(a < b) {
		if(b < c) {
			return c;
		}
		return b;
	} else if(a > b && c < a)
	{
		return a;
	} return c;
}
console.log(Max(1, 2, 3));
console.log(Max(1, 3, 2)); 
console.log(Max(3, 2, 1)); 
console.log(Max(3, 2, 6));
console.log(Max(3, 7, 6)); */


/* Conditionals #22:
Given a string, return a string made of the first 2 chars (if present), 
however include first char only if it is 'o' and include the second only if it is 'z', so "ozymandias" yields "oz". 

StartOz("ozymandias") -> "oz"
StartOz("bzoo") -> "z"
StartOz("oxx") -> "o" 

function StartOz(str) {
	var secChar = str.slice(1,2);
	var isOz = str.slice(0,2);
	if(str.charAt(0)=="o" || secChar=="z")
	{
		if(isOz=="oz")
		{
			return isOz;
		} else if(secChar=="z")
		{
			return secChar;
		}
		return str.slice(0,1);
	}
}
console.log(StartOz("ozymandias"));
console.log(StartOz("bzoo"));
console.log(StartOz("oxx")); */

/* Conditionals #21:
Return true if the given string begins with "*ix", the '*' can be anything, so "pix", "9ix" .. all count. 

IxStart("mix snacks") -> true
IxStart("pix snacks") -> true
IxStart("piz snacks") -> false 

function IxStart(str) {
	var ix = str.slice(1,3);
	if(ix=="ix") {
		return true;
	}
	return false;
}
console.log(IxStart("mix snacks"));
console.log(IxStart("pix snacks"));
console.log(IxStart("piz snacks")); */

/* Conditionals #20:
Given a string, if the string "del" appears starting at index 1, 
return a string where that "del" has been deleted. Otherwise, return the string unchanged. 

RemoveDel("adelbc") -> "abc"
RemoveDel("adelHello") -> "aHello"
RemoveDel("adedbc") -> "adedbc" 

function RemoveDel(str) {
	var delAt1 = str.slice(1,4);
	if(delAt1 == "del") {
		var newStr =  str.replace(delAt1,"");
		return newStr;
	}
	return str;
}

console.log(RemoveDel("adelbc"));
console.log(RemoveDel("adelHello"));
console.log(RemoveDel("adedbc")); */



/* Conditionals #19:
We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
Given 2 int values, return true if one or the other is teen, but not both. 

SoAlone(13, 99) -> true
SoAlone(21, 19) -> true
SoAlone(13, 13) -> false 

function SoAlone(a, b) {
	if((a < 20 && a > 12) && (b < 20 && b > 12)) {
		return false;
	} else if((a < 20 && a > 12) || (b < 20 && b > 12)) {
		return true;
	}
}
console.log(SoAlone(13, 99));
console.log(SoAlone(21, 19));
console.log(SoAlone(13, 13)); */

/* Conditionals #18:
We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, return true if 1 or more of them are teen. 

HasTeen(13, 20, 10) -> true
HasTeen(20, 19, 10) -> true
HasTeen(20, 10, 12) -> false 

function HasTeen(a, b, c) {
	if((a < 20 && a > 12) || (b < 20 && b > 12) || (c < 20 && c > 12)) {
		return true;
	}
return false;
}
console.log(HasTeen(13, 20, 10));
console.log(HasTeen(20, 19, 10));
console.log(HasTeen(20, 10, 12)); */

/* Conditionals #17:
Given 2 int values, return true if either of them is in the range 10..20 inclusive. 

Between10and20(12, 99) -> true
Between10and20(21, 12) -> true
Between10and20(8, 99) -> false 

function Between10and20(a, b) {
	if((a < 21 && a > 9) || (b < 21 && b > 9)) {
		return true;
	}
	return false;
}
console.log(Between10and20(12, 99));
console.log(Between10and20(21, 12));
console.log(Between10and20(8, 99)); */

/* Conditionals #16:
Given two temperatures, return true if one is less than 0 and the other is greater than 100. 

IcyHot(120, -1) -> true
IcyHot(-1, 120) -> true
IcyHot(2, 120) -> false 

function IcyHot(temp1, temp2) {
	if(temp1 < 0 && temp2 > 100) {
		return true;
	} else if(temp2 < 0 && temp1 > 100) {
		return true;
	}
	return false;
}
console.log(IcyHot(120, -1));
console.log(IcyHot(-1, 120));
console.log(IcyHot(2, 120)); */

/* Conditionals #15:
Given a string, return true if the string starts with "hi" and false otherwise. 

StartHi("hi there") -> true
StartHi("hi") -> true
StartHi("high up") -> false 

function StartHi(str) {
	if(str.slice(0,2)=="hi")
	{
		if(str.length < 3 || str.slice(2,3)==" ")
		{
			return true;
		}
	}
		return false;
}
console.log(StartHi("hi there"));
console.log(StartHi("hi"));
console.log(StartHi("high up")); */

/* Conditionals #14:
Return true if the given non-negative number is a multiple of 3 or a multiple of 5. Use the % "mod" operator

Multiple3or5(3) -> true
Multiple3or5(10) -> true
Multiple3or5(8) -> false 

function Multiple3or5(number) {
	if(number % 3 == 0 || number % 5 == 0)
	{
		return true;
	}
	return false;
}
console.log(Multiple3or5(3));
console.log(Multiple3or5(10));
console.log(Multiple3or5(8)); */


/* Conditionals #13:
Given a string, take the last char and return a new string with the last char added at the front and back, 
so "cat" yields "tcatt". The original string will be length 1 or more. 

BackAround("cat") -> "tcatt"
BackAround("Hello") -> "oHelloo"
BackAround("a") -> "aaa" 

function BackAround(str) {
	var lastChar = str.slice(-1);
	var newStr = lastChar + str + lastChar;
	return newStr;
}
console.log(BackAround("cat"));
console.log(BackAround("Hello"));
console.log(BackAround("a")); */

/* Conditionals #12:
Given a string, we'll say that the front is the first 3 chars of the string. 
If the string length is less than 3, the front is whatever is there. Return a new string which is 3 copies of the front. 

Front3("Microsoft") -> "MicMicMic"
Front3("Chocolate") -> "ChoChoCho"
Front3("at") -> "atatat"

function Front3(str) {
	if(str.length < 3)
	{
		return str+str+str;
	}
	var newStr = str.slice(0,3);
	newStr +=newStr + newStr;
	return newStr;
}
console.log(Front3("Microsoft"));
console.log(Front3("Chocolate"));
console.log(Front3("at")); */

/* Conditionals #11:
Given a string, return a new string where the first and last chars have been exchanged. 

FrontBack("code") -> "eodc"
FrontBack("a") -> "a"
FrontBack("ab") -> "ba" 

function FrontBack(str) {
	if(str.length > 1) {
		var newStr = str.slice(-1);
		newStr += str.slice(1,str.length-1);
		newStr += str.slice(0,1);
		return newStr;
		}
	return str;
}

console.log(FrontBack("code"));
console.log(FrontBack("a"));
console.log(FrontBack("ab")); */


/* Conditionals #10:
Given a non-empty string and an int n, return a new string where the char at index n has been removed. 
The value of n will be a valid index of a char in the original string (Don't check for bad index). 

MissingChar("kitten", 1) -> "ktten"
MissingChar("kitten", 0) -> "itten"
MissingChar("kitten", 4) -> "kittn" 

function MissingChar(str, n) {
	var newStr = str.slice(0,n);
	newStr += str.slice(n+1,str.length);
	return newStr;
}

console.log(MissingChar("kitten", 1));
console.log(MissingChar("kitten", 0));
console.log(MissingChar("kitten", 4)); */

/* Conditionals #9:
Given a string, return a new string where "not " has been added to the front. 
However, if the string already begins with "not", return the string unchanged. Hint: Look up how to use "SubString" in c#

NotString("candy") -> "not candy"
NotString("x") -> "not x"
NotString("not bad") -> "not bad" 

function NotString(str) {
	var first3 = str.substring(0,3);
	if(first3 != "not") {
		return "not " + str;
	}
	return str;
}
console.log(NotString("candy"));
console.log(NotString("x"));
console.log(NotString("not bad")); */
 
/* Conditionals #8: 
Given two int values, return true if one is negative and one is positive. Except if the parameter "negative" is true, 
then return true only if both are negative. 

PosNeg(1, -1, false) -> true
PosNeg(-1, 1, false) -> true 
PosNeg(-4, -5, true) -> true 

function PosNeg(a, b, negative) {
	if(!negative) {
		if(a < 0 || b < 0) {
			return true;
		}
		return false;
	} else {
		if(a < 0 && b < 0) {
			return true;
		}
		return false;
	}
}
console.log(PosNeg(1, -1, false));
console.log(PosNeg(-1, 1, false));
console.log(PosNeg(-4, -5, true)); */

/* Conditionals #7: 
Given an int n, return true if it is within 10 of 100 or 200.
Hint: Check out the C# Math class for absolute value

NearHundred(103) -> true
NearHundred(90) -> true
NearHundred(89) -> false 

function NearHundred(n) {
	var within100 = Math.abs(n-100);
	var within200 = Math.abs(n-200);
	if(within100 < 11 || within200 < 11) {
		return true;
	}
	return false;
}
console.log(NearHundred(103));
console.log(NearHundred(90));
console.log(NearHundred(89)); */

/* Conditionals #6: 
Given two ints, a and b, return true if one if them is 10 or if their sum is 10. 

Makes10(9, 10) -> true
Makes10(9, 9) -> false
Makes10(1, 9) -> true 

function Makes10(a, b) {
	if(a==10 || b==10 || a+b==10)
	{
	return true;
	}
	return false;
}
console.log(Makes10(9, 10));
console.log(Makes10(9, 9));
console.log(Makes10(1, 9)); */

/* Conditionals #5: 
We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23. 
We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if we are in trouble. 

ParrotTrouble(true, 6) -> true
ParrotTrouble(true, 7) -> false
ParrotTrouble(false, 6) -> false 

function ParrotTrouble(isTalking, hour) {
  if(hour < 7 || hour > 20) {
	  if(isTalking)
	  {
		  return true;
	  }
  }
  return false;
}
console.log(ParrotTrouble(true, 6));
console.log(ParrotTrouble(true, 7));
console.log(ParrotTrouble(false, 6)); */


/* Conditionals #4: 
Given an int n, return the absolute value of the difference between n and 21, 
except return double the absolute value of the difference if n is over 21. 

Diff21(23) -> 4
Diff21(10) -> 11
Diff21(21) -> 0 

function Diff21(n) {
	if(n > 21) {
		var absVal = Math.abs(n-21) * 2;
		return absVal;
	} else {
		var absVal = Math.abs(n-21);
		return absVal;
	}
}
console.log(Diff21(23));
console.log(Diff21(10));
console.log(Diff21(21)); */


/* Conditionals #3: 
Given two int values, return their sum. However, if the two values are the same, then return double their sum. 

SumDouble(1, 2) -> 3
SumDouble(3, 2) -> 5
SumDouble(2, 2) -> 8 

function SumDouble(a, b) {
  if(a != b) {
	  return a+b;
  }  
  return (a+b) *2;
  
} 
console.log(SumDouble(1, 2));
console.log(SumDouble(3, 2));
console.log(SumDouble(2, 2)); */

/* Conditionals #2: 
The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation. 
We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in. 

sleepIn(false, false) -> true
sleepIn(true, false) -> false
sleepIn(false, true) -> true

function sleepIn(isWeekday, isVacation) {
	if(!isWeekday || isVacation) {
		return true;
	}
	return false;
}
console.log(sleepIn(false, false));
console.log(sleepIn(true, false));
console.log(sleepIn(false, true)); */


/* Conditionals #1: 
We have two children, a and b, and the parameters aSmile and bSmile indicate if each is smiling. 
We are in trouble if they are both smiling or if neither of them is smiling. Return true if we are in trouble. 

AreWeInTrouble(true, true) -> true
AreWeInTrouble(false, false) -> true
AreWeInTrouble(true, false) -> false 

function AreWeInTrouble(aSmile, bSmile) {
	if((aSmile && bSmile) || !aSmile && !bSmile)
	{return true;}
return false;
}

console.log(AreWeInTrouble(true, true));
console.log(AreWeInTrouble(false, false));
console.log(AreWeInTrouble(true, false)); */