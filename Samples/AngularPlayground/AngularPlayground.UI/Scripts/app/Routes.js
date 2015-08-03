var myApp = angular.module('friendsApp', ['ngRoute']);

myApp.factory('friendsFactory', function($http) {
    var WebApiProvider = {};

    var url = '/api/Friends';

    WebApiProvider.getFriends = function() {
        return $http.get(url);
    };

    WebApiProvider.saveFriend = function(friend) {
        return $http.post(url, friend);
    };

    return WebApiProvider;
});

myApp.config(function($routeProvider) {
    $routeProvider
        .when('/Routes', {
            controller: 'FriendsController',
            templateUrl: '/AngularViews/FriendsList.html'
        })
        .when('/AddFriend', {
            controller: 'AddFriendController',
            templateUrl: '/AngularViews/AddFriend.html'
        })
        .otherwise({ redirectsTo: '/Routes' });
});

myApp.controller('FriendsController', function($scope, friendsFactory) {
    friendsFactory.getFriends()
        .success(function(data) {
            $scope.friends = data;
        })
        .error(function(data, status) {
            alert('ERROR - ' + status);
        });
});

myApp.controller('AddFriendController', function($scope, $location, friendsFactory) {
    $scope.friend = {};

    $scope.save = function() {
        friendsFactory.saveFriend($scope.friend)
            .success(function() {
                $location.path('/Routes');
            })
            .error(function(data, status) {
                alert('ERROR - ' + status);
            });
    }
});
