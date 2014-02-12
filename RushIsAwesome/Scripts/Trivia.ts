/// <reference path="typings/jquery/jquery.d.ts" />

class Trivia {
    triviaElement: JQuery;

    constructor() {
        this.triviaElement = $('#trivia');
    }
    retrieve() : void {
        var self = this;
        $.getJSON('api/trivia', function (data, textStatus, jqXHR) {
            self.triviaElement.text(data.Item);
        });
    }
}

window.onload = () => {
    var trivia = new Trivia();
    var didYouKnowButton = <HTMLButtonElement>document.getElementById('didYouKnow');
    didYouKnowButton.onclick = function () {
        trivia.retrieve();
    };
}