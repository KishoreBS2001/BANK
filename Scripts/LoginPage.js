function lval() {

    var unip = $('#userName').val();
    var pwdip = $('#passWordtxt').val();


    $('#userName').keypress(function () {
        $('#unErr').text("");
    });


    $('#passWordtxt').keypress(function () {
        $('#passErr').text("");
    });


    if (unip == "") {
        $('#unErr').css("color", "red");

        $('#unErr').text("Username Is Empty");
        return false;
    }

    if (pwdip == "") {
        $('#passErr').css("color", "red");

        $('#passErr').text("Password Is Empty");
        return false;
    }
    else if (pwdip.length != 10) {
        $('#passErr').css("color", "red");

        $('#passErr').text("Invalid Password length");
        return false;

    }
    return true;
}