var app = angular.module('myshop', [])
app.controller('Shopcontroller', function ($scope, $http) {
    $http.get('https://localhost:44389/Api/Banner').then(function (res) {
        console.log(res.data);
    })


});