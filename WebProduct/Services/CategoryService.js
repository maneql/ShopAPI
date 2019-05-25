﻿myApp.service('CategoryService', function ($http) {

    var ServiceAPI = 'api/Category/';

    var getAllCategory = function () {
        var request = $http({
            method: 'GET',
            cache: false,
            url: HostAPI + ServiceAPI
        });
        return request;
    };

    var addCategory = function (category) {
        var request = $http({
            method: 'POST',
            cache: false,
            url: HostAPI + ServiceAPI,
            data: category
        });
        return request;
    };

    var updateCategory = function (category) {
        var request = $http({
            method: 'PUT',
            cache: false,
            url: HostAPI + ServiceAPI,
            data: category
        });
        return request;
    };

    var deleteCategory = function (id) {
        var request = $http({
            method: 'DELETE',
            url: HostAPI + ServiceAPI + id,
            Origin: 'http://localhost:51928'
        });
        return request;
    };

    return {
        getAllC: getAllCategory,
        addC: addCategory,
        updateC: updateCategory,
        deleteC: deleteCategory
    };
});
