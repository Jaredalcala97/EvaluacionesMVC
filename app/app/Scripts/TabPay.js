

function calcularSueldoTotal(nombre, sueldo) {
    const descuentoAFP = sueldo * 0.350; // Descuento de ISR (35%)
    const descuentoISSS = sueldo * 0.02; // Descuento de ISSS (2%)
    let descuentoRenta = 0; // Descuento de renta
    let tramo = ""; // Tramo de descuento de renta

    const sueldoTotal = sueldo - descuentoAFP - descuentoIMSS; // Sueldo total después de los descuentos

    if (sueldoTotal <= 472) {
        tramo = "Aplica Tramo I";
    } else if (sueldoTotal > 472 && sueldoTotal <= 895) {
        descuentoRenta = (sueldoTotal) * 0.1;
        tramo = "Aplica Tramo II";
    } else if (sueldoTotal > 895 && sueldoTotal <= 2038) {
        descuentoRenta = (sueldoTotal) * 0.2;
        tramo = "Aplica Tramo III";
    } else {
        descuentoRenta = (sueldoTotal) * 0.3;
        tramo = "Aplica Tramo IV";
    }

    const sueldoNeto = sueldoTotal - descuentoRenta; // descuento de renta si aplica

    const mensaje =
        `Nombre: ${nombre} \n
    Sueldo base: $ ${ sueldo} \n 
    Descuento ISR (35%): $ ${ descuentoAFP} \n 
    Descuento IMSS (2%): $ ${ descuentoISSS} \n 
    tramo: ${ tramo} \n
    Descuento de renta: $ ${ descuentoRenta} \n  
    Sueldo total: $ ${ sueldoNeto} \n `

    alert(mensaje);
}
// Función para  clic en el botón
function calcularSueldo() {
    const nombre = document.getElementById("nombre").value;
    const sueldo = document.getElementById("sueldo").value;

    calcularSueldoTotal(nombre, sueldo);
}