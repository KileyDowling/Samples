/* Arrays #15:
Given 2 int arrays, a and b, return a new array length 2 containing,  as much as will fit,
 the elements from a followed by the elements from b. The arrays may be any length, including 0, 
 but there will be 2 or more elements available between the 2 arrays. 

Make2({4, 5}, {1, 2, 3}) -> {4, 5}
Make2({4}, {1, 2, 3}) -> {4, 1}
Make2({}, {1, 2}) -> {1, 2}

function make2(a,b) {
	var lengthA = a.length;
	var lengthB = b.length;
	if(lengthA > 1) {
		return a.slice(0,2);
	} else if (lengthA == 1) {
		var newArray= [a[0], b[0]];
		return newArray;
	} else{
		return b.slice(0,2);
	}
}
console.log(make2([4, 5], [1, 2, 3]));
console.log(make2([4], [1, 2, 3]));
console.log(make2([], [1, 2])); */

/* Arrays #14:
We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array. 
Unlucky1({1, 3, 4, 5}) -> true
Unlucky1({2, 1, 3, 4, 5}) -> true
Unlucky1({1, 1, 1}) -> false 

function Unlucky1(numbers) {
	for(var i=0; i < numbers.length; i++) {
		if(numbers[i]==1 && numbers[i+1]==3) {
			if(i < 2 || i == numbers.length-2) {
				return true;
			}
		}
	}
	return false;
}
console.log(Unlucky1([1, 3, 4, 5]));
console.log(Unlucky1([2,1, 3, 4, 5]));
console.log(Unlucky1([1,1,1]));
console.log(Unlucky1([1,6,7,8,1,3]));  */

/* Arrays #13:
Given an int array length 3, if there is a 2 in the array immediately followed by a 3, 
set the 3 element to 0. Return the changed array. 

Fix23({1, 2, 3}) ->{1, 2, 0}
Fix23({2, 3, 5}) -> {2, 0, 5}
Fix23({1, 2, 1}) -> {1, 2, 1} 

function Fix23(numbers) {
	for(var i=0;i<numbers.length;i++) {
		if(numbers[i]==2 && numbers[i+1]==3) {
			numbers.splice(i+1,1,0);
		}
	}
	return numbers;
}
console.log(Fix23([1, 2, 3]));
console.log(Fix23([2, 3,5]));
console.log(Fix23([1,2,1])); */

/* Arrays #12:
Given an int array, return true if the array contains 2 twice, or 3 twice. 

Double23({2, 2, 3}) -> true
Double23({3, 4, 5, 3}) -> true
Double23({2, 3, 2, 2}) -> false 

function Double23(numbers) {
	var found2=0;
	var found3=0;
	
	for(var i =0;i < numbers.length; i++) {
		if(numbers[i]==2) {
			found2++;
		}
		if(numbers[i]==3) {
			found3++;
		}
	}
	if(found2 == 2 || found3 ==2) {
		return true;
	}
	return false;
}

console.log(Double23([2, 2, 3]));
console.log(Double23([3,4,5,3]));
console.log(Double23([2,3,2,2])); */

/* Arrays #11:
Given an int array, return a new array with double the length where its last 
element is the same as the original array, and all the other elements are 0. 
The original array will be length 1 or more. Note: by default, a new int array contains all 0's. 

KeepLast({4, 5, 6}) -> {0, 0, 0, 0, 0, 6}
KeepLast({1, 2}) -> {0, 0, 0, 2}
KeepLast({3}) -> {0, 3} 

function KeepLast(numbers) {
	var n = numbers.length * 2;
	var lastNum = numbers.slice(-1);
	var newArray = [];
	for(var i=0;i < n-1; i++) {
		newArray.push(0);
	}
	newArray.push(lastNum[0]);
	return newArray;
}
console.log(KeepLast([4, 5, 6]));
console.log(KeepLast([1,2]));
console.log(KeepLast([3])); */

/* Arrays #10:
Given an int array , return true if it contains an even number (HINT: Use Mod (%)). 
HasEven({2, 5}) -> true
HasEven({4, 3}) -> true
HasEven({7, 5}) -> false 

function HasEven(numbers) {
	var foundEven = 0;
	for(var n in numbers) {
		if(numbers[n] % 2 ==0) {
			foundEven++;
		}
	}
	if(foundEven > 0) {
		return true;
	}
	return false;
}
console.log(HasEven([2, 5]));
console.log(HasEven([4, 3]));
console.log(HasEven([7, 5])); */

/* Arrays #9:
Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements. 

GetMiddle({1, 2, 3}, {4, 5, 6}) -> {2, 5}
GetMiddle({7, 7, 7}, {3, 8, 0}) -> {7, 8}
GetMiddle({5, 2, 9}, {1, 4, 5}) -> {2, 4} 

function GetMiddle(a, b) {
	var midA = a[1];
	var midB = b[1]; 
	var newArray = [midA,midB];
	return newArray;
} 
console.log(GetMiddle([1, 2, 3], [4, 5, 6]));
console.log(GetMiddle([7,7,7], [3,8,0]));
console.log(GetMiddle([5,2,9], [1,4,5])); */

/* Arrays #8: 
Given an array of ints, figure out which is larger between the first 
and last elements in the array, and set all the other elements to be that value. Return the changed array. 

HigherWins({1, 2, 3}) -> {3, 3, 3}
HigherWins({11, 5, 9}) -> {11, 11, 11}
HigherWins({2, 11, 3}) -> {3, 3, 3} 

function HigherWins(numbers) {
	var first = numbers.slice(0,1);
	var last = numbers.slice(-1); 
	var result = last;
	var newArray = [];
	if(first[0] > last[0]) {
		result = first; 
	} 
	for(var i = 0; i < numbers.length; i++) {
		newArray.push(result[0]);
	}
	return newArray;
}
console.log(HigherWins([1, 2, 3]));
console.log(HigherWins([11, 5, 9]));
console.log(HigherWins([2,11,3])); */

/* Arrays #7: 
Given an array of ints length 3, return a new array with the elements in reverse order, 
so for example {1, 2, 3} becomes {3, 2, 1}. 

function Reverse(numbers) {
	//return numbers.reverse();
	var newArray = [];
	for(var i = numbers.length-1; i > -1;i--) {
		newArray.push(numbers[i]);
	}
	return newArray;
}

console.log(Reverse([1,2,3]));  */


/* Arrays #6: 
Given an array of ints, return an array with the elements "rotated left" so {1, 2, 3} yields {2, 3, 1}. 

RotateLeft({1, 2, 3}) -> {2, 3, 1}
RotateLeft({5, 11, 9}) -> {11, 9, 5}
RotateLeft({7, 0, 0}) -> {0, 0, 7} 

function RotateLeft(numbers) {
	//return numbers.reverse();
	var newArray = []
	for(var i=numbers.length-1; i>-1; i--) {
		newArray.push(numbers[i])
	}
	return newArray;
}
console.log(RotateLeft([1, 2, 3]));
console.log(RotateLeft([5,11, 9]));
console.log(RotateLeft([7,0,0])); */

/* Arrays #5
Given an array of ints, return the sum of all the elements.
Sum({1, 2, 3}) -> 6
Sum({5, 11, 2}) -> 18
Sum({7, 0, 0}) -> 7 

function Sum(numbers) {
	count = 0;
	sum = 0;
	while(count < numbers.length) {
		sum += numbers[count];
		count++;
	}
	return sum;
}
console.log(Sum([1, 2, 3]));
console.log(Sum([5,11,2]));
console.log(Sum([7,0,0])); */

/* Arrays #4:
Given 2 arrays of ints, a and b, return true if 
they have the same first element or they have the same last element. Both arrays will be length 1 or more. 
CommonEnd({1, 2, 3}, {7, 3}) -> true
CommonEnd({1, 2, 3}, {7, 3, 2}) -> false
CommonEnd({1, 2, 3}, {1, 3}) -> true 

function commonEnd(a, b) {
	var lastB = b.slice(-1);
	var lastA = a.slice(-1);
  if(a[0]==b[0] || lastA[0]==lastB[0]) {
	  return true;
  }
  return false;
}

console.log(commonEnd([1, 2, 3], [7, 3]));
console.log(commonEnd([1, 2, 3], [7, 3,2]));
console.log(commonEnd([1, 2, 3], [1, 3])); */

/* Arrays #3:
Return an int array length n containing the first n digits of pi.

MakePi(3) -> {3, 1, 4} 

function MakePi(n) {
	var pi = [3,1,4,1,5,9,2,6,5,3,5,8,9,7,9,3];
	 return pi.slice(0,n);
}
console.log(MakePi(3)); */

/* Arrays #2:
Given an array of ints, return true if the array is length 1 or more, and the first element and the last element are equal. 
SameFirstLast({1, 2, 3}) -> false
SameFirstLast({1, 2, 3, 1}) -> true
SameFirstLast({1, 2, 1}) -> true 

function SameFirstLast(numbers) {
	var n = numbers.length-1;
	if(numbers[0] == numbers[n] && n > 0) {
		return true;
	}
	return false;
}
console.log(SameFirstLast([1, 2, 3]));
console.log(SameFirstLast([1, 2, 3, 1]));
console.log(SameFirstLast([1, 2, 1])); 
console.log(SameFirstLast([1]));  */


/* Arrays #1:
Given an array of ints, return true if 6 appears as 
either the first or last element in the array. The array will be length 1 or more. 

FirstLast6({1, 2, 6}) -> true
FirstLast6({6, 1, 2, 3}) -> true
FirstLast6({13, 6, 1, 2, 3}) -> false 

function FirstLast6(numbers) {
	var found6 =numbers.indexOf(6);
	if(found6 == 0 || found6 == numbers.length -1) {
		return true;
	}
	return false;
}
console.log(FirstLast6([1, 2, 6]));
console.log(FirstLast6([6, 1, 2, 3]));
console.log(FirstLast6([13, 6, 1, 2, 3])); */