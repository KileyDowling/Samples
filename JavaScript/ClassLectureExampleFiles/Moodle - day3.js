$(document).ready(function(){
	/*
	// get an element by the id attribute
	var div = document.getElementById("place");
	div.className = "two";
	div.title = "Not Header text";
	*/
	$('#place').addClass('two').removeClass('one');
	$('#place').attr('title', 'JQUERY RULES!');
	
	var json = [{'Topic 1': ['1A', '1B'], 'Topic 2': ['2A', '2B'], 'Topic 3': ['3A', '3B']},
		{'Topic 4': ['4A', '4B'], 'Topic 5': ['5A', '5B'], 'Topic 6': ['6A', '6B']}];
	
	var html = '<ul>';
	for (var object in json) { // element
		for (var topic in json[object]) { // topics
			html += '<li>' + topic + '<ul>';
			for (var i = 0; i < json[object][topic].length; i++) { // 1A...
				html += '<li>' + json[object][topic][i] + '</li>';
			}
			html += '</ul></li>';
		}
	}
	html += '</ul>';
	$('#listhere').append(html);
});