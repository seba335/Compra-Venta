
function valFoto(sender, args){


    var i = document.getElementById('btnVerFoto');

    if (i.value == 'Cargar imagen') {
        arguments[1].IsValid = false;

    }

    else {
        arguments[1].IsValid = true;
    }

}