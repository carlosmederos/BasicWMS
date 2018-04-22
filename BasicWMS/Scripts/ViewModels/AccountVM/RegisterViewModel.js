function RegisterViewModel(user) {

    var self = this;

    //alert("1212312");

    self.user = {
        firstName: ko.observable(user.firstName),
        lastName: ko.observable(user.lastName),
        userName: ko.observable(user.userName),
        email: ko.observable(user.email),
        password: ko.observable(user.password),
        confirmPassword: ko.observable(user.confirmPassword),
    }

    

    self.validateAndSave = function () {
        if (self.user.firstName.length == 0) {
            alert("entro ifS");
        }
    }
}
