$(document).ready(function () {
    jQuery.validator.addMethod("Name", function(value, element) {
        if ((element.value % 4) === 0) {
            return true;
        } else {
            return false;
        }
    }, "Not an incremenet of 4");

    $('#rsvpForm').validate({
        rules: {
            Name: {
                required: true
            },
            Email: {
                required: true,
                email: true
            },
            Phone: {
                required: true
            },
            FavoriteGame: {
                required: true
            },
            WillAttend: {
                required: true
            }
        },
            messages: {
                Name: "Enter your name",
                Email: {
                    required: "Enter your email address",
                    email: "That's not a format for email I'm aware of..."
                }
            }
        
    });
})