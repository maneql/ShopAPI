
var myApp = angular.module("MyApp", ["ngRoute"]);
var HostAPI = 'http://localhost:51928/';

myApp.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "/Views/Main.html"
        })
        .when("/Product", {
            templateUrl: "/Views/Product.html",
            controller: "ProductController"
        })
        .when("/Category", {
            templateUrl: "/Views/Category.html",
            controller: "CategoryController"
        }).
        otherwise({
            redirectTo: '/'
        });
});
