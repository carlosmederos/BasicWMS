var person = {
    firstName: "Carlos René",
    lastName: "Mederos Arias",
    profession: "Automation Engineer"
};

var PersonViewModel = function () {
    var self = this;

    self.prueba = ko.observable();

    self.firstName = ko.observable(person.firstName);
    self.lastName = ko.observable(person.lastName);
    self.profession = ko.observable(person.profession);
    self.fullName = ko.computed(function () {
        return self.firstName() + ' ' + self.lastName();
    });

    self.probarClick = function() {
        alert(self.prueba());
    }

};

ko.applyBindings(new PersonViewModel());

