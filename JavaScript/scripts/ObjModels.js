var name = "Bob";
function sayName() {
	alert(this.name);
}
/*
alert(window.name); //Bob
sayName(); //Bob
window.sayName(); //Bob
*/
var swc = window.open("http://www.swcguild.com");
if(swc == null) {
	alert("The popup was blocked");
}

swc.close();

var timeoutId = setTimeout(function(){
	//alert("Time's up!");
}, 1000);

//clearTimeout(timeoutId);

var num = 0;
var max = 5;
var interval = null;

function incrementNumber() {
	num++;
	if(num == max) {
		clearInterval(interval);
		//alert("done");
	}
}
interval = setInterval(incrementNumber,  500);

confirm("Are you sure?");
find(); //display searchbox
print(); //should print the page