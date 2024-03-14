@Code
    ViewData("Title") = "Firmas"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Bombardier</title>
    <link href="~/Content/Firmas.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popupF.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <nav>
        <a href="#" class="session">

            <img src="~/images/logo.png" alt="Alternate Text" />

        </a>
        <ul>

            <li>
                <a class="start" href="#">Sesion Activa de Jared Alcalá</a>
            </li>
            <li>
                <a href="#infopopup">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>

            <li>
                <a href="#" id="SesionAdmin" class="bi bi-house-door-fill home"></a>
            </li>
            <li>
                <a href="#" id="Index" class="bi bi-box-arrow-right logout"></a>
            </li>
        </ul>
    </nav>
    <div class="titulo">
        <h2>
            FIRMAS REALIZADAS DE LAS ENCUESTAS
        </h2>
    </div>
    <div class="Tabla">
        <table style="width:100%">
            <tr class="titulos" style="justify-content:center; align-items:center; margin-left:auto;">
                <th>NOMBRE</th>
                <th>PUESTO</th>
                <th>FECHA DE INGRESO</th>
                <th>CALIFICACIÓN</th>
                <th>ULTIMA EVALUACIÓN</th>
                <th>SIGUIENTE EVALUACIÓN</th>
                <th>VENCIMIENTO DE EVALUACIÓN</th>
                <th>STATUS</th>
                <th>FIRMAS FALTANTES</th>
            </tr>
            <tr>
                <td>Javier Hernandez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Cristiano Ronaldo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Reprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Marco Fabian</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Reprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Marcelo Lopez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
        </table>
    </div>
    <div id="popupF" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>FIRMAS PENDIENTES</h2>
            <section>
                <!--for demo wrap-->
                <h1>Lista de evaluaciones pendientes de firmar</h1>
                <div class="tbl-header">
                    <table cellpadding="0" cellspacing="0" border="0">
                        <thead>
                            <tr>
                                <th>NOMBRE</th>
                                <th>PUESTO</th>
                                <th>FECHA DE INGRESO</th>
                                <th>CALIFICACIÓN</th>
                                <th>ULTIMA EVALUACIÓN</th>
                                <th>SIGUIENTE EVALUACIÓN</th>
                                <th>VENCIMIENTO DE EVALUACIÓN</th>
                                <th>STATUS</th>
                            
                            </tr>
                        </thead>
                    </table>
                </div>
                <div class="tbl-content">
                    <table cellpadding="0" cellspacing="0" border="0">
                        <tbody>
                        <tr class="head">
                            <td>Javier Hernandez</td>
                            <td>Inspector de calidad</td>
                            <td>12-06-2020</td>
                            <td>26/35</td>
                            <td>12-12-2023</td>
                            <td>12-06-2024</td>
                            <td>09-05-2024</td>
                            <td>Aprobado</td>
                        </tr>
                        <tr class="body">
                            <td>Cristiano Ronaldo</td>
                            <td>Inspector de calidad</td>
                            <td>12-06-2020</td>
                            <td>26/35</td>
                            <td>12-12-2023</td>
                            <td>12-06-2024</td>
                            <td>09-05-2024</td>
                            <td>Reprobado</td>
                        </tr>
                        <tr class="body">
                            <td>Alfredo Bustillo</td>
                            <td>Inspector de calidad</td>
                            <td>12-06-2020</td>
                            <td>26/35</td>
                            <td>12-12-2023</td>
                            <td>12-06-2024</td>
                            <td>09-05-2024</td>
                            <td>Aprobado</td>
                        </tr>
                        <tr class="body">
                            <td>Marco Fabian</td>
                            <td>Inspector de calidad</td>
                            <td>12-06-2020</td>
                            <td>26/35</td>
                            <td>12-12-2023</td>
                            <td>12-06-2024</td>
                            <td>09-05-2024</td>
                            <td>Reprobado</td>
                        </tr>
                        <tr class="body">
                            <td>Marcelo Lopez</td>
                            <td>Inspector de calidad</td>
                            <td>12-06-2020</td>
                            <td>26/35</td>
                            <td>12-12-2023</td>
                            <td>12-06-2024</td>
                            <td>09-05-2024</td>
                            <td>Aprobado</td>
                        </tr>
                        </tbody>
                    </table>
                </div>
            </section>

            <a href="#popup2" id="botonx">Enviar Recordatorios</a>
        </div>
    </div>
    <div id="popup2" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>se enviara(n) 1 recordatorio(s)</h2>
            <a href="#popup3" id="botonx">Enviar Recordatorios</a>
        </div>
    </div>
    <div id="popup3" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>Envio de recordatorio(s) exitoso</h2>
            <a href="#" id="botonx" class="okay">volver al menu</a>
        </div>
    </div>
    <footer>

        <div class="finale">
            <div class="centered">
                <h2>Servicio de Evaluación de Empleados</h2>
                <p>Derechos reservados Bombardier mexico</p>
                <p>autor Jared Helaman Alcalá Alvarado</p>
            </div>
        </div>

    </footer>

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            // Selecciona todos los enlaces con la clase 'sesion-link'
            var links = document.querySelectorAll(".start");

            // Añade un manejador de eventos a cada enlace
            links.forEach(function (link) {
                link.addEventListener("click", function (event) {
                    event.preventDefault(); // Previene la navegación predeterminada del enlace

                    // Redirige a la página 'Index'
                    window.location.href = "Index";
                });
            });
        });
    </script>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            // Selecciona todos los enlaces con la clase 'sesion-link'
            var links = document.querySelectorAll(".session");

            // Añade un manejador de eventos a cada enlace
            links.forEach(function (link) {
                link.addEventListener("click", function (event) {
                    event.preventDefault(); // Previene la navegación predeterminada del enlace

                    // Redirige a la página 'Index'
                    window.location.href = "SesionAdmin";
                });
            });
        });
    </script>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            // Selecciona todos los enlaces con la clase 'sesion-link'
            var links = document.querySelectorAll(".okay");

            // Añade un manejador de eventos a cada enlace
            links.forEach(function (link) {
                link.addEventListener("click", function (event) {
                    event.preventDefault(); // Previene la navegación predeterminada del enlace

                    // Redirige a la página 'Index'
                    window.location.href = "Firmas";
                });
            });
        });
    </script>
    <script src="~/Scripts/RouteNav.js"></script>
</body>

</html>
