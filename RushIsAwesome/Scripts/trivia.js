/// <reference path="typings/jquery/jquery.d.ts" />
var Trivia = (function () {
    function Trivia() {
        this.triviaElement = $('#trivia');
    }
    Trivia.prototype.retrieve = function () {
        var self = this;
        $.getJSON('api/trivia', function (data, textStatus, jqXHR) {
            self.triviaElement.text(data.Item);
        });
    };
    return Trivia;
})();

window.onload = function () {
    var trivia = new Trivia();
    var didYouKnowButton = document.getElementById('didYouKnow');
    didYouKnowButton.onclick = function () {
        trivia.retrieve();
    };
};
