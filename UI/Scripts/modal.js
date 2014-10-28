
$(function () {
    $("body").append('<div id="modal" class="modal hide fade"></div>');
});

function hideModal() {
    $('#modal').modal('hide');
}

function showModal(message) {

    
    if (message == undefined)
        message = 'Loading';

    $('#modal').empty(); //clear the contents (from previous use)

    $('#modal').append("<div style='width: 80%; margin: 0 auto 0 auto;'><br/>" + message + "...<br/><div class='progress progress-striped active'><div class='bar' style='width: 100%;'></div></div><br/></div>");
    
    $('#modal').modal({
        backdrop: 'static'
    });

}

function blockModal() {

    $('#modal').block({
        message: "<div style='width: 80%; margin: 0 auto 0 auto;'><br/>Processing...<br/><div class='progress progress-striped active'><div class='bar' style='width: 100%;'></div></div><br/></div>",
        css: {
            width: '80%'
        }
    });

}

function unblockModal() {
    $('#modal').unblock();
}


