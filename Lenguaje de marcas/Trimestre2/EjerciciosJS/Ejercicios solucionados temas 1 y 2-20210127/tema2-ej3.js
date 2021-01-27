'use strict';

function generaLista (num1, num2) {
    document.write("<ul>")

    for (let i = 1;i <= num2;i++) {
        document.write("<li>");
        document.write(num1 + " x " + i + " = " + (num1 * i));
        document.write("</li>");
    }

    document.write("</ul>")
}

function generaTabla (num1, num2) {
    document.write("<table border=1>")

    for (let i = 1;i <= num2;i++) {
        document.write("<tr>");
        document.write("<td>" + num1 + " x " + i + "</td><td> = </td><td>" + (num1 * i) + "</td>");
        document.write("</tr>");
    }

    document.write("</table>")
}

let num1, num2;

num1 = Number(prompt("Introduce primer número"));
num2 = Number(prompt("Introduce segundo número"));

if (isNaN(num1) || isNaN(num2))
    alert("Tienes que introdiucir datos numéricos");
else {
    let modo = prompt("Introduce modo: ");

    switch(modo) {
        case "LISTA":
            generaLista(num1, num2);
            break;
        case "TABLA":
            generaTabla(num1, num2);
            break;
        default:
            alert("modo erróneo");
    }
}