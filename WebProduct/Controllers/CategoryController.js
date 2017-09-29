myApp.controller("CategoryController", function ($scope, CategoryService) {

    $scope.GetAll = function () {
        CategoryService.getAllC().then(function succes(respone) {
            $scope.data = respone.data;
        }, function error(respone) {
            $scope.dataError = respone.data;
        }
        );
    };

    $scope.Add = function () {
        CategoryService.addC($scope.addcategory).then(function succes(respone) {
            $scope.data.push(respone.data);
            $scope.addcategory = null;
        }, function error() { });
    };

    $scope.Edit = function (cate, index) {
        $scope.category = cate;
        $scope.Index = index
    };

    $scope.Update = function () {
        CategoryService.updateC($scope.category).then(function (respone) {
            $scope.data[$scope.Index] = respone.data;
        });
    };

    $scope.Remove = function (index) {
        var category = $scope.data[index];
        if (window.confirm("Xóa: " + category.Category_Name)) {
            CategoryService.deleteC(category.Category_Id).then(function succes(respone) {
                if (respone) {
                    $scope.data.splice(index, 1);
                }
            });
        }
    };
});
