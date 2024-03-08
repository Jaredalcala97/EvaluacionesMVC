@Code
    ViewData("Title") = "Consulta"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Bombardier</title>
    <link href="~/Content/Consulta.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <nav>
        <a href="@Url.Action("Sesion")">

            <img src="~/images/logo.png" alt="Alternate Text" />

        </a>
        <ul>
            <li>
                <a href="#infopopup">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>

            <li><a href="#" id="Sesion" class="bi bi-house-door-fill home"></a></li>
            <li><a href="#" id="Index" class="bi bi-box-arrow-right logout"></a></li>
        </ul>
    </nav>
    <div class="titulo">
        <h2>
            EVALUACIONES YA REALIZADAS
        </h2>
    </div>
    <div class="Tabla">
        <input id="searchbar" onkeyup="search_nombre()" type="text"
               name="search" placeholder="buscar empleado...">
        <table style="width:100%">
            <tr class="titulos" style="justify-content:center; align-items:center; margin-left:auto;">
                <th>NOMBRE</th>
                <th>PUESTO</th>
                <th>FECHA DE INGRESO</th>
                <th>CALIFICACIÓN</th>
                <th>ULTIMA EVALUACION</th>
                <th>SIGUIENTE EVALUACIÓN</th>
                <th>VENCIMIENTO DE EVALUACIÓN</th>
                <th>STATUS</th>

            </tr>
            <tr>
                <td class="Empleado">Lorenzo Hernandez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
            </tr>
            <tr>
                <td class="Empleado">Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
            </tr>
            <tr>
                <td class="Empleado">Marco Herrera</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
            </tr>
            <tr>
                <td class="Empleado">Luis Suarez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
            </tr>
            <tr>
                <td class="Empleado">Leonel Messi</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-12-2023</td>
                <td>12-06-2024</td>
                <td>09-05-2024</td>
                <td>Aprobado</td>
            </tr>
        </table>
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
    <script src="~/Scripts/buscador.js"></script>
    <script src="~/Scripts/RouteNav.js"></script>
</body>

</html>
