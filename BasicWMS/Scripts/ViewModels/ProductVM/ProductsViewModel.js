var ProductsViewModel = function (products) {

    var self = this;

    self.pageName = "Productos Almacenados";
    self.Products = products;
    self.cantProductos = self.Products.length;
    
    
    //$.ajax({
    //    url: '/api/ProductApi',
    //    cache: false,
    //    type: 'GET',
    //    contentType: 'application/json',
    //    success: function (data) {
    //        self.Products(data);
    //    }
    //});


}

