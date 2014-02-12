var uri = 'api/products';

function loadTrivia() {
	$.getJSON('api/trivia')
		 .done(function (data) {
		 	$('#trivia').text(data.Item);
		 })
		 .fail(function (jqXHR, textStatus, err) {
		 	$('#trivia').text('Could not load trivia.');
		 });
}