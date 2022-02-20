var func = () => {
    var entrada = document.getElementById("inputMember");
    var text = document.getElementById("text-returned");
    text.innerHTML = "";

    if (entrada.name == "entrada") {
        text.innerHTML += "Entrada registrada para el miembro  <b>" + entrada.value + "</b>" + " a la hora: <b>" + moment(new Date()).format('hh:mm:ss') + "</b>";
    } else if (entrada.name == "salida") {
        text.innerHTML += "Salida registrada para el miembro  <b>" + entrada.value + "</b>" + " a la hora: <b>" + moment(new Date()).format('hh:mm:ss') + "</b>";
    }

    $("#exampleModal").show();

    setTimeout(function () {
        $("#exampleModal").hide();
    }, 3000);
}

document.querySelector('#register').addEventListener("click", function () {
    func();
});

document.querySelector('#btn-close').addEventListener("click", function () {
    $("#exampleModal").hide();
});

document.querySelector('#inputMember').addEventListener('keypress', function (e) {
    if (e.key === 'Enter') {
        func();
        e.preventDefault();
    }
});



