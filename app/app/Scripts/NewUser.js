function mostrarElemento() {
    var elemento = document.getElementById("elementoParaMostrar");
    if (elemento.style.display === "none") {
        elemento.style.display = "block";
    } else {
        elemento.style.display = "none";
    }
}
