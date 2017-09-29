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
        getAllP: getAllProduct,
        addP: addProduct,
        updateP: updateProduct,
        deleteP: deleteProduct
    };
});
