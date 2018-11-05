
function validarTodo() {


}

function validarEmail(email) {
    var partesEmail = email.split('@');
    if(partesEmail.length>2) {
        throw new Error('El email no es valido');
    }
    if(partesEmail[1] && partesEmail[1].length > 1) {
        var partesDominio = partesEmail[1].split('.');
        if(partesDominio.length > 3) {
            throw new Error('El email no es valido');
        }
    }
    return true;
}

function validarNombre(nombre) {
    if(nombre.length>15) {
        throw new Error('El nombre debe tener 15 caracteres como maximo');
    }

}

function validarContrasena(contrasena) {
    if(contrasena.length<8) {
        throw new Error('La contrasena debe tener minimo 8 caracteres');
    }
}

