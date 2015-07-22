$(document).ready(function() {	
		/*
		// get an element by the id attribute
			var div = document.getElementById("place");
			div.className = "two"; */
		$('#place').addClass('two').removeClass('one');
		$('#place').attr('title','JQUERY RULES!');
		
		var json = {'Topic 1': ['1A', '1B'],'Topic 2': ['2A', '2B'], 'Topic 3': ['3A', '3B']}
		
		var html = '<url>';
		
		for (var topic in json) {//topics
			html += '<li>' + topic + '<ul>';
			for (var i = 0; i < json[topic].length; i++) { 
				html += '<li>' + json[topic][i]  + '</li>'; // i is the element within that topic 
			}
			html += '</ul></li>' //closing out ordered list & list item
		}
		
		html += '</ul>'; //close out of other ordered list
		$('#listhere').append(html);	//insert html into new div
});