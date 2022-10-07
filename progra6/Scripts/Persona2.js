$().ready(function () {

    $("#frmPersona2").validate({
        rules: {
            nombre: {
                required: true,
                minlength: 2
            },
            apellido: {
                required: true,
                minlength: 2
            },
            password1: {
                required: true,
                minlength: 5
            },
            password2: {
                required: true,
                minlength: 5,
                equalTo: "#password1"
            },
            email: {
                required: true,
                email: true
            },
            fechaN: {
                required: true
            }
        },
        messages: {
            nombre: {
                required: "El nombre es requerido",
                minlength: "Minimo 2 caracteres"
            },
            apellido: {
                required: "El nombre es requerido",
                minlength: "Minimo 2 caracteres"
            },
            password1: {
                required: "El password es requerido",
                minlength: "Digite minimo 5 caracteres"
            },
            password2: {
                required: "la confirmacion de password es requerido",
                minlength: "Digite minimo 5 caracteres",
                equalTo: " Debe ser igual al password"
            },
            email: {
                required: "Mail es requerido",
                email: "Valor no cumple con formato de email"
            },
            fechaN: {
                required: "Ingrese fecha"
            }
        }
    })
})