var RushIsAwesome;
(function (RushIsAwesome) {
    (function (Controllers) {
        var TriviaController = (function () {
            function TriviaController($scope, $http) {
                var _this = this;
                this.$scope = $scope;
                this.$http = $http;
                $scope.model = new RushIsAwesome.Models.TriviaModel();
                $scope.getTrivia = function () {
                    _this.getTrivia();
                };
            }
            TriviaController.prototype.getTrivia = function () {
                var self = this;
                this.$http.get('api/trivia').success(function (data, status) {
                    self.$scope.model.item = data.Item;
                });
            };
            return TriviaController;
        })();
        Controllers.TriviaController = TriviaController;
    })(RushIsAwesome.Controllers || (RushIsAwesome.Controllers = {}));
    var Controllers = RushIsAwesome.Controllers;
})(RushIsAwesome || (RushIsAwesome = {}));
