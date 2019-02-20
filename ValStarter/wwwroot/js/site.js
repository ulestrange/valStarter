// Write your Javascript code.


// Custom Validation Stuff

jQuery.validator.addMethod("graduationcohort",
    function (value, element, param) {

            return (value == "Autumn" || value == "Spring" );
    });

jQuery.validator.unobtrusive.adapters.addBool("graduationcohort");