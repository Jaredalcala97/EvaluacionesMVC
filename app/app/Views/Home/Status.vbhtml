@Code
    ViewData("Title") = "Status"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Bombardier</title>
    <link href="~/Content/Status.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popupF.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <nav>
        <a href="@Url.Action("SesionAdmin")">

            <img src="~/images/logo.png" alt="Alternate Text" />

        </a>
        <ul>
            <li>
                <a href="#infopopup">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>

            <li><a href="#" id="SesionAdmin" class="bi bi-house-door-fill home"></a></li>
            <li><a href="#" id="Index" class="bi bi-box-arrow-right logout"></a></li>
        </ul>
    </nav>
    <div class="titulo">
        <h2>
            STATUS DE LAS EVALUACIONES
        </h2>
    </div>
    <div class="Tabla">
        <table style="width:100%">
            <tr class="titulos" style="justify-content:center; align-items:center; margin-left:auto;">
                <th>NOMBRE</th>
                <th>PUESTO</th>
                <th>FECHA DE INGRESO</th>
                <th>CALIFICACION</th>
                <th>SIGUIENTE EVALUACIÓN</th>
                <th>STATUS</th>
            </tr>
            <tr>
                <td>Juan Perez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td class="Status1">Pendiente</td>
            </tr>
            <tr>
                <td>Juan charrasqueado</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td class="Status3"><a href="#" id="Firmas">Sin Firmar</a></td>
            </tr>
            <tr>
                <td>Frank Sapa</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td class="Status4">Finalizada</td>
            </tr>
            <tr>
                <td>Luis Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td class="Status1">Pendiente</td>
            </tr>
        </table>
    </div>
    <script src="~/Scripts/RouteNav.js"></script>
</body>

</html>
