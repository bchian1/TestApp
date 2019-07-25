// LastNameNotDavis //
$.validator.addMethod("lastnamenotdavis",
    function (value, element, parameters) {
        return value.toUpperCase() !== "DAVIS";
    });
// and an unobtrusive adapter
$.validator.unobtrusive.adapters.add('lastnamenotdavis', ["lastnamenotdavis"], function (options) {
    options.rules['lastnamenotdavis'] = "#" + options.element.name.replace('.', '_');
    options.messages['lastnamenotdavis'] = options.message;
});

// DateBeforeMay2017Only //
$.validator.addMethod("datebeforemay2017only",
    function (value, element, parameters) {
        return Date.parse(value) < new Date(2017, 5, 1);
    });
// and an unobtrusive adapter
$.validator.unobtrusive.adapters.add('datebeforemay2017only', ["datebeforemay2017only"], function (options) {
    options.rules['datebeforemay2017only'] = "#" + options.element.name.replace('.', '_');
    options.messages['datebeforemay2017only'] = options.message;
});
