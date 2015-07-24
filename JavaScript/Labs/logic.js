/* Logic #17:
Return the sum of two 6-sided dice rolls, each in the range 1..6. However, if noDoubles is true, 
if the two dice show the same value, increment one die to the next value, wrapping around to 1 if its value was 6. 

RollDice(2, 3, true) → 5
RollDice(3, 3, true) → 7
RollDice(3, 3, false) → 6

function RollDice(die1, die2, noDoubles) {
	if(!noDoubles) {
		return die1+die2;
	} else if(noDoubles) {
		if(die1==die2) {
			if(die1 > 5) {
				return die1 + 1;
			}
			return die1+die2 + 1;
		}
		return die1+die2;
	}	
}
console.log(RollDice(2, 3, true));
console.log(RollDice(3, 3, true));
console.log(RollDice(3, 3, false)); */

/* Logic #16:
Given three ints, a b c, return true if two or more of them have the same rightmost digit. The ints are non-negative. 

LastDigit(23, 19, 13) → true
LastDigit(23, 19, 12) → false
LastDigit(23, 19, 3) → true 

function LastDigit(a, b, c) { 
var diffAB = a-b;
var diffBC = b-c;
var diffAC=a-c;
if(diffAB % 10 == 0 || diffAC % 10 == 0 || diffBC % 10 == 00) 
{
	return true;
} 
return false;

} 

console.log(LastDigit(23,19,13));
console.log(LastDigit(23,19,12));
console.log(LastDigit(23,19,3)); */

/* Logic #15:
Given three ints, a b c, return true if they are in strict increasing order, such as 2 5 11, or 5 6 7, but not 6 5 7 or 5 5 7. 
However, with the exception that if "equalOk" is true, equality is allowed, such as 5 5 7 or 5 5 5. 

InOrderEqual(2, 5, 11, false) → true
InOrderEqual(5, 7, 6, false) → false
InOrderEqual(5, 5, 7, true) → true 

function InOrderEqual(a, b, c, equalOk) {
  if(a < b && b < c && !equalOk) {
	  return true;
  } else if(equalOk) {
	  if(a == b || b == c) {
		  return true;
	  }
  }
  return false;
}
console.log(InOrderEqual(2, 5, 11, false));
console.log(InOrderEqual(5, 7, 6, false));
console.log(InOrderEqual(5, 5, 7, true)); */

/* Logic #14:
Given three ints, a b c, return true if b is greater than a, and c is greater than b. 
However, with the exception that if "bOk" is true, b does not need to be greater than a. 

AreInOrder(1, 2, 4, false) → true
AreInOrder(1, 2, 1, false) → false
AreInOrder(1, 1, 2, true) → true 

function AreInOrder(a, b, c, bOk) {
	if(bOk) {
		if(c > b) {
			return true;
		}
	} else if(b > a && c > b) {
		return true;
	}
  return false;
 }
console.log(AreInOrder(1, 2, 4, false));
console.log(AreInOrder(1, 2, 1, false));
console.log(AreInOrder(1, 1, 2, true)); */
  

/* Logic #13:
Given three ints, a b c, return true if it is possible to add two of the ints to get the third. 

TwoIsOne(1, 2, 3) → true
TwoIsOne(3, 1, 2) → true
TwoIsOne(3, 2, 2) → false

function TwoIsOne(a,b,c) {
  if(a+b==c || b+c ==a || a+c==b) {
	  return true;
  }
  return false;
}
console.log(TwoIsOne(1, 2, 3));
console.log(TwoIsOne(3,1,2));
console.log(TwoIsOne(3, 2, 2)); */

/* Logic #12:
Your cell phone rings. Return true if you should answer it. Normally you answer, 
except in the morning you only answer if it is your mom calling. In all cases, if you are asleep, you do not answer. 

AnswerCell(false, false, false) → true
AnswerCell(false, false, true) → false
AnswerCell(true, false, false) → false

function AnswerCell(isMorning, isMom, isAsleep) {
  if(isAsleep) {
	  return false;
  } 
  if(isMom) {
	  return true;
  } 
  if(!isMorning) {
	  return true;
  } else { 
	return false;
  }
}

console.log(AnswerCell(false, false, false));
console.log(AnswerCell(false, false, true));
console.log(AnswerCell(true, false, false)); */



/* Logic #11:
Return true if the given non-negative number is a multiple of 3 or 5, but not both. Use the % "mod" operator

Mod35(3) → true
Mod35(10) → true
Mod35(15) → false 

function Mod35(n) {
	if(n % 3 == 0) {
		if(n % 5 == 0)
		{
			return false;
		}
		return true;
	} else if (n % 5 == 0) {
		return true;
	}
}
console.log(Mod35(3));
console.log(Mod35(10));
console.log(Mod35(15)); */

/* Logic #10:
Return true if the given non-negative number is 1 or 2 more than a multiple of 20. See also: Introduction to Mod 

Mod20(20) → false
Mod20(21) → true
Mod20(22) → true 

function Mod20(n) {
  if((n > 19) && (n % 20 == 1 || n % 20 == 2)) {
	  return true;
  }
  return false;
}
console.log(Mod20(20));
console.log(Mod20(21));
console.log(Mod20(22));
console.log(Mod20(2)); */

/* Logic #9:
We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11. 
Return true if the given non-negative number is special. Use the % "mod" operator

SpecialEleven(22) → true
SpecialEleven(23) → true
SpecialEleven(24) → false 

function SpecialEleven(n) {
	if(n % 11 == 0 || n % 11 == 1) {
		return true;
	}
	return false;
}
console.log(SpecialEleven(22));
console.log(SpecialEleven(23));
console.log(SpecialEleven(24)); */

/* Logic #8:
Given a number n, return true if n is in the range 1..10, inclusive. 
Unless "outsideMode" is true, in which case return true if the number is less or equal to 1, or greater or equal to 10. 

InRange(5, false) → true
InRange(11, false) → false
InRange(11, true) → true 

function InRange(n, outsideMode) {
	if(!outsideMode) {
		if(n > 0 && n < 11) {
			return true;
		}
		return false;
	} else if(n < 2 || n > 9) {
		return true;
	}
	return false;
}
console.log(InRange(5, false));
console.log(InRange(11, false));
console.log(InRange(11, true));
console.log(InRange(5, true)); */


/* Logic #7:
The number 6 is a truly great number. Given two int values, a and b, return true if either one is 6. Or if their sum or difference is 6.

LoveSix(6, 4) → true
LoveSix(4, 5) → false
LoveSix(1, 5) → true 

function LoveSix(a, b) {
  var sum = a+b;
  var diff = Math.abs(a-b);
  if(a == 6 || b== 6) {
	  return true;
  } else if(diff == 6 || sum == 6) {
	  return true;
  }
 return false;
}

console.log(LoveSix(6, 4));
console.log(LoveSix(4, 5));
console.log(LoveSix(1, 5));
console.log(LoveSix(3, 9)); 
console.log(LoveSix(15, 9)); */

/* Logic #6:
Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a boolean indicating if we are on vacation, 
return a string of the form "7:00" indicating when the alarm clock should ring. 
Weekdays, the alarm should be "7:00" and on the weekend it should be "10:00". 
Unless we are on vacation -- then on weekdays it should be "10:00" and weekends it should be "off". 

AlarmClock(1, false) → "7:00"
AlarmClock(5, false) → "7:00"
AlarmClock(0, false) → "10:00"

function AlarmClock(day, vacation) {
	if(day > 0 && day < 6) {
		if(!vacation) {
			return "7:00";
		}
		return "10:00";
	} else if(day == 0 || day == 6) {
		if(!vacation) {
			return "10:00";
		}
		return "off";
	}
} 
console.log(AlarmClock(1, false));
console.log(AlarmClock(5, false));
console.log(AlarmClock(0, false));
console.log(AlarmClock(6, true)); */


/* Logic #5: 
Given 2 ints, a and b, return their sum. However, sums in the range 10..19 inclusive are forbidden, so in that case just return 20. 

SkipSum(3, 4) → 7
SkipSum(9, 4) → 20
SkipSum(10, 11) → 21

function SkipSum(a, b) {
	if(a+b > 10 && a+b < 20)
	{
		return 20;
	}
  return a+b;
} 
console.log(SkipSum(3, 4));
console.log(SkipSum(9, 4));
console.log(SkipSum(10, 11)); */

/* Logic #4: 
You are driving a little too fast, and a police officer stops you. Write code to compute the result, 
encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket. 
If speed is 60 or less, the result is 0. If speed is between 61 and 80 inclusive, the result is 1. 
If speed is 81 or more, the result is 2. Unless it is your birthday -- on that day, your speed can be 5 higher in all cases. 

CaughtSpeeding(60, false) → 0
CaughtSpeeding(65, false) → 1
CaughtSpeeding(65, true) → 0

function CaughtSpeeding(speed, isBirthday) {
	if(speed < 66) {
		if(isBirthday || speed < 61) {
			return 0;
		}
		return 1;
	} 
	if(speed > 84) {
		if(isBirthday || speed < 81) {
			return 1;
		} 
		return 2;
	} 
} 
console.log(CaughtSpeeding(60, false));
console.log(CaughtSpeeding(65, false));
console.log(CaughtSpeeding(60, true));
console.log(CaughtSpeeding(95, true));
console.log(CaughtSpeeding(85, false)); */


/* Logic #3: 
The children in Cleveland spend most of the day playing outside. In particular, they play if the temperature is between 60 and 90 (inclusive). 
Unless it is summer, then the upper limit is 100 instead of 90. 
Given an int temperature and a bool isSummer, return true if the children play and false otherwise. 

PlayOutside(70, false) → true
PlayOutside(95, false) → false
PlayOutside(95, true) → true

function PlayOutside(temp, isSummer) {
	if(temp > 59 && temp < 100) {
		if(!isSummer  && temp < 91) {
			return true;
		} else if(isSummer){
			return true;
		}
	}
	return false;
}
console.log(PlayOutside(70, false));
console.log(PlayOutside(95, false));
console.log(PlayOutside(95, true)); */

/* Logic #2: 
You and your date are trying to get a table at a restaurant. The parameter "you" is the stylishness of your clothes, 
in the range 0..10, and "date" is the stylishness of your date's clothes. 
The result getting the table is encoded as an int value with 0=no, 1=maybe, 2=yes. 
If either of you is very stylish, 8 or more, then the result is 2 (yes). 
With the exception that if either of you has style of 2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe). 

CanHazTable(5, 10) → 2
CanHazTable(5, 2) → 0
CanHazTable(5, 5) → 1

function CanHazTable(yourStyle, dateStyle) {
  if(yourStyle > 7 || dateStyle > 7) {
	  return 2;
  } else if(yourStyle < 3 || dateStyle < 3) {
	  return 0;
  } else {
	  return 1;
  }
}
console.log(CanHazTable(5, 10));
console.log(CanHazTable(5, 2));
console.log(CanHazTable(5, 5)); */

/* Logic #1: 
When squirrels get together for a party, they like to have cigars. 
A squirrel party is successful when the number of cigars is between 40 and 60, inclusive. 
Unless it is the weekend, in which case there is no upper bound on the number of cigars. 
Return true if the party with the given values is successful, or false otherwise. 

GreatParty(30, false) → false
GreatParty(50, false) → true
GreatParty(70, true) → true

function GreatParty(cigars, isWeekend) {
  if(cigars > 39) {
	  if(isWeekend) {
		  return true;
	  } else if(cigars < 61) {
		  return true;
	  }
  }  else {
	  return false;
  }
}
console.log(GreatParty(30, false));
console.log(GreatParty(50, false));
console.log(GreatParty(70, true)); */