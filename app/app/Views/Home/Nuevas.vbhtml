@Code
    ViewData("Title") = "Nuevas"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="~/Content/Consulta.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <nav>
        <img src="~/images/logo.png" alt="Alternate Text" />
        <ul>
            <li>
                <a href="@Url.Action("Info", "Home")">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>
            <li>
                <a href="@Url.Content("Sesion")">
                    <i class="bi bi-house-door-fill home"></i>
                </a>
            </li>
            <li>
                <a href="@Url.Action("Index", "Home")">
                    <i class="bi bi-box-arrow-right logout"></i>
                </a>
            </li>
        </ul>
    </nav>
    <div class="titulo">
        <h2>
            EVALUACIONES SIN REALIZAR
        </h2>
    </div>
    <div class="Tabla">
        <table style="width:100%">
            <tr>
                <th>NOMBRE</th>
                <th>PUESTO</th>
                <th>FECHA DE INGRESO</th>
                <th>ULTIMA EVALUACION</th>

            </tr>
            <tr>
                <td><a href="#InfoUser">Alfredo Bustillo</a></td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="@Url.Action("Evaluacion")">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td><a href="#InfoUser">Alfredo Bustillo</a></td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="@Url.Action("Evaluacion")">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td><a href="#InfoUser">Alfredo Bustillo</a></td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="@Url.Action("Evaluacion")">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td><a href="#InfoUser">Alfredo Bustillo</a></td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="@Url.Action("Evaluacion")">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td><a href="#InfoUser">Alfredo Bustillo</a></td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="@Url.Action("Evaluacion")">INICIAR EVALUACION</a></td>
            </tr>
        </table>
        <div id="InfoUser" class="overlay">
            <div id="popupBody">
                <a id="cerrar" href="#">&times;</a>
                <table style="width:100%">
                    <tr>
                        <th></th>
                        <th>N1</th>
                        <th>N2</th>
                        <th>N3</th>
                        <th>N4</th>
                        <th>N5</th>

                    </tr>
                    <tr>
                        <th>INITIAL</th>
                        <th>3 months</th>
                        <th>6 months</th>
                        <th>12 months / 1 year</th>
                        <th>24 months / 2 year</th>
                        <th>36 months / 3 year</th>
                    </tr>
                </table>
                <a href=@Url.Action("Nuevas")>OK</a>
            </div>
        </div>
    </div>   
</body>
</html>
