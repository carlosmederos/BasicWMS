var NewProductViewModel = function () {

    var self = this;

    self.product = {
        name: ko.observable(product.name),
        partNumber: ko.observable(product.partNumber),
        label: ko.observable(product.label),
        startingInventory: ko.observable(product.startingInventory),
        inventoryReceived: ko.observable(product.inventoryReceived),
        inventoryShipped: ko.observable(product.inventoryShipped),
        inventoryOnHand: ko.observable(product.inventoryOnHand),
        minimumRequired: ko.observable(product.minimumRequired),
    }
    
    self.validateAndSave = function (form) {
        alert("asa");
        if (!$(form).valid())
            alert("tod OK");

    }
};

ko.applyBindings(new NewProductViewModel());