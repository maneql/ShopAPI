﻿myApp.service('ProductService', function ($http) {

    var ServiceAPI = 'api/Product/';

    var getAllProduct = function () {
        var request = $http({
            method: 'GET',
            cache: false,
            url: HostAPI + ServiceAPI
        });
        return request;
    };

    var getAllCategory = function () {
        var request = $http({
            method: 'GET',
            cache: false,
            url: HostAPI + 'api/Category'
        });
        return request;
    };

    var addProduct = function (product) {
        var request = $http({
            method: 'post',
            cache: false,
            url: HostAPI + ServiceAPI,
            data: product
        });
        return request;
    };

    var updateProduct = function (product) {
        var request = $http({
            method: 'put',
            cache: false,
            url: HostAPI + ServiceAPI,
            data: product
        });
        return request;
    };

    var deleteProduct = function (id) {
        var request = $http({
            method: 'delete',
            cache: false,
            url: HostAPI + ServiceAPI + id,
        });
        return request;
    };

    return {
        getAll: getAllProduct,
        add: addProduct,
        update: updateProduct,
        delete: deleteProduct,
        getAllC: getAllCategory
    };
});
