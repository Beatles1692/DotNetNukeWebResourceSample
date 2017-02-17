function buttonclicked() {
    var name = $("[name='name']").val();
    $('#nameError').hide();
    if (!name) {
        $('#nameError').show();
        return;
    }
    $('#nameSpan').text(name);

}

$(document).ready(function() {
    $('#nameError').hide();
    $('#applicationName').text(window.GLOB.getApplicationName());
});