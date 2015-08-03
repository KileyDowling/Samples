var myApp = angular.module('demoApp', []);

myApp.controller('SimpleController', function($scope) {
    $scope.friends = [
        { name: 'John', phone: '555-5555', age: 10 },
        { name: 'Mary', phone: '555-5555', age: 10 },
        { name: 'John', phone: '444-44444', age: 19 },
        { name: 'Mike', phone: '222-2222', age: 21 },
        { name: 'Adam', phone: '333-3333', age: 35 },
        { name: 'Julie', phone: '111-1111', age: 29 }
    ];
});