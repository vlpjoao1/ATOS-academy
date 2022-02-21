var ul = document.getElementById("elements");
var lista = [
    "Joao se registró: 20 / 2 / 2021 11: 22 33",
    "Juan se registró: 20 / 2 / 2022 21: 33: 15",
    "Luis se registró: 20 / 2 / 2012 09: 22: 12",
    "Ramon se registró: 20 / 2 / 2012 22: 51: 15",
    "Alfredo se registró: 20 / 2 / 2014 11: 51: 42",
    "Angel se registró: 20 / 2 / 2015 20: 16: 33",
    "María se registró: 20 / 2 / 2019 20: 12: 45",
    "Emmanuel se registró: 20 / 2 / 2020 11: 51: 54",
    "Veronica se registró: 20 / 2 / 2021 20: 51: 22",
    "Wilmer se registró: 20 / 2 / 2021 16: 51: 23"
]
for (var i = 0; i < lista.length; i++) {
    ul.innerHTML += "<li>"+lista[i]+"</li>"
}