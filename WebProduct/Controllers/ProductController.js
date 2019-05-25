myApp.controller("ProductController", function ($scope, ProductService) {

    $scope.GetAll = function () {
        ProductService.getAll().then(function succes(respone) {
            $scope.data = respone.data;
        }, function error(respone) {
            $scope.dataError = respone.data;
        }
        );
    };

    $scope.GetAllCategory = function () {
        ProductService.getAllC().then(function (respone) { $scope.cates = respone.data }, function () { });
    };

    $scope.Add = function () {
        ProductService.add($scope.addP).then(function succes(respone) {
            $scope.data.push(respone.data);
            $scope.addP = null;
        }, function error() { });
    };

    $scope.Edit = function (prod, index) {
        $scope.product = prod;
        $scope.Index = index
    };

    $scope.Update = function () {
        ProductService.update($scope.product).then(function (respone) {
            $scope.data[$scope.Index] = respone.data;
        });
    };

    $scope.Remove = function (index) {
        var product = $scope.data[index];
        if (window.confirm("Xóa sản phẩm: " + product.Product_Name)) {
            ProductService.delete(product.Product_Id).then(function succes(respone) {
                if (respone) {
                    $scope.data.splice(index, 1);
                }
            });
        }
    };
});
