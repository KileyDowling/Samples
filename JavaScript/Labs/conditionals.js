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