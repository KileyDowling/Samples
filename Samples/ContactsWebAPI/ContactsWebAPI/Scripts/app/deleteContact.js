
function clickDelete(contactID) {

    $.ajax({
        url: '/api/contacts/' + contactID,
        type: 'DELETE',
        success: function(data, status, xhr) {
            loadContacts();
        },
        error: function(xhr, status, err) {
            alert('error: ' + err);
        }
    });
}