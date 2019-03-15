// Write your Javascript code.


// Custom Validation Stuff


// The validation check for the attribute graduation cohort
jQuery.validator.addMethod("graduationcohort",
    function (value, element, param) {

            return (value == "Autumn" || value == "Spring" );
    });

// Registering the validation check.
jQuery.validator.unobtrusive.adapters.addBool("graduationcohort");


// The validation check for the application date

jQuery.validator.addMethod("applicationDate",
    function (value, element, param) {
        var now = new Date(); // gets date and time.
        now = new Date(now.setHours(0, 0, 0, 0)) // sets time to 00:00
        var enteredDate = Date.parse(value)
        return !(enteredDate > now ); // 
    });
// Registering the validation check.

jQuery.validator.unobtrusive.adapters.addBool("applicationDate");