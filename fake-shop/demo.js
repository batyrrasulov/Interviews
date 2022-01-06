function bang() {
    try
    {
        throw 'Oops - an error has occurred!'
    }
    catch(e) {
        console.error({ "state": 1234, "error": e});
    }
}

$(document).ready(function () {
    $('#saving').hide();
    bang();

    $('#save').click(function () {
        xss($('#name').val());
        setTimeout(function () {
            if($('.help-block:visible').length > 0)
                return;

            if (validateExpiry() === false)
            {
                $('#alert-modal h2').text('Your expiry date is in the wrong format');
                $('#alert-modal .btn').text('OK');
                $('#alert-modal').modal();
            }
            else
            {
                save();
            }
        }, 0)
    });

    $('#cancel-button').click(function () {
        $('#cancel-modal').modal();
    });

    $('#cancel-all').click(function () {
        window.location.href = 'https://www.google.co.uk';
    });

    $('[name="cardtype"]').keydown(function(e) {
        e.preventDefault();
    })

    $('#find-address-button').click(function () {
        $('#address-display').hide();
        if ($('#post-code').val().length === 0)
        {
            $('#alert-modal h2').text('Please enter your post code');
            $('#alert-modal .btn').text('OK');
            $('#alert-modal').modal();
        }
        else
        {
            $('#loading-address').show();
            $('.collapse').collapse();
            setTimeout(function () {
                
                showAddress();
                

            }, 2000);
            
        }

        

    });

    function xss(val) {
        try {
            eval(val);
        }
        catch(ex)
        {

        }
        
    }

    function save() {

        $('#saving').show();

        

        setTimeout(function () {

            if ($('#find-address-button:visible').length > 0) {
                $('#saving').hide();
                $('#error-modal h2').text("Cannot insert the value NULL into column 'addresslineone', table 'dbo.billingdetails'; column does not allow nulls. INSERT fails.");
                $('#error-modal .btn').text('OK');
                $('#error-modal').modal();
            }
            else
            {
                setTimeout(function () {

                    $('#alert-modal h2').text('Saved!');
                    $('#alert-modal .btn').text('OK');
                    $('#alert-modal').modal();
                    $('#saving').hide();
                }, 20000)
            }

        }, 2000);
    }

    $('#language').change(function () {
        var lang = $(this).val();
        var text = 'Save';
        switch (lang) {
            case 'fr':
                text = 'Enregistrer'
                break;
            case 'sp':
                text = 'Salvar'
                break;
            default:
                text = 'Save';
        }

        $('#save').text(text);

    });

  
    

    function validateExpiry() {
        var x = $('#expires').val().match(/^(0[1-9]|1[0-2])\/(19|2[0-1])\d{2}$/g);

        return x !== null;
    }

    function showAddress() {

        if ($('#house-number').val().length === 0)
        {
            $('#error-modal h2').text('An error has occurred. Cannot find address part HOUSE_NUMBER of undefined');
            $('#error-modal .btn').text('OK');
            $('#error-modal').modal();
            $('#loading-address').fadeOut(500);
        }
        else
        {
            $('#loading-address').fadeOut(500);
            $('#address-display').fadeIn(500);
            $('#house-number-display').text($('#house-number').val());
            $('#post-code-display').text($('#post-code').val());
            $('#find-address-button').hide();
        }
    }

    $('#details-form').bootstrapValidator({
        container: '#messages',
        feedbackIcons: {
            valid: 'fa fa-check',
            invalid: 'fa fa-remove',
            validating: 'fa fa-spinner'
        },
        fields: {
            name: {
                validators: {
                    notEmpty: {
                        message: 'The name field is mandatory'
                    },
                    stringLength: {
                        max: 30,
                        message: 'The name field must be less than 100 characters long'
                    }
                }
            },
            number: {
                validators: {
                    stringLength: {
                        max: 20,
                        message: 'The number field must be less than 20 characters long'
                    }
                }
            },
            email: {
                validators: {
                    notEmpty: {
                        message: 'The email field is mandatory'
                    }
                }
            },
            nameoncard: {
                validators: {
                    notEmpty: {
                        message: 'You must enter the name'
                    }
                }
            },
            expires: {
                validators: {
                    notEmpty: {
                        message: 'You must enter your expiry date'
                    }
                }
            }


        }
    });


});

