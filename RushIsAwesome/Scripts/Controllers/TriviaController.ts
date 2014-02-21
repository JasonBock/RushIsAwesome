module RushIsAwesome.Controllers {
    export interface ITriviaScope extends ng.IScope {
        model: RushIsAwesome.Models.TriviaModel;
        getTrivia: Function;
    }

    export class TriviaController {
        constructor(private $scope: ITriviaScope, private $http: ng.IHttpService) {
            $scope.model = new RushIsAwesome.Models.TriviaModel();
            $scope.getTrivia = () => {
                this.getTrivia();
            };
        }

        getTrivia(): void {
            var self = this;
            this.$http.get('api/trivia').success((data, status) => {
                self.$scope.model.item = data.Item;
            });
        }
    }
}