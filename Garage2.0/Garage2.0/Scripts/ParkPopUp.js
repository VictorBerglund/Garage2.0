function isEmpty(el) {
    return $.trim(el.html())
}
if (isEmpty($('#alertBox'))) {
    $("#alertBox").slideDown().delay(3000).slideUp();
}