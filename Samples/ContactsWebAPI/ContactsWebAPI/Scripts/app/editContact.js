function clickEdit(contactID) {
    $('#editContactModal').modal('show');

    $('#btnEditSaveContact').click(function() {
        var contact = {};
        contact.Name = $('#editname').val();
        contact.PhoneNumber = $('#editphonenumber').val();
        contact.ContactID = contactID;

        $.ajax({
            url: '/api/contacts/',
            type: 'PUT',
            dataType: 'json',
            data: contact,
            success: function (data, status, xhr) {
                $('#editContactModal').modal('hide');
                loadContacts();
            },
            error: function(xhr, status, err) {
                alert('error: ' + err);
            }
        });
    });
}
