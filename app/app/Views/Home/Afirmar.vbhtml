@Code
    ViewData("Title") = "Afirmar"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="~/Content/Afirmar.css" rel="stylesheet" />
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
            FIRMAS SIN REALIZAR
        </h2>
    </div>
    <div class="Tabla">
        <table style="width:100%">
            <tr>
                <th>NOMBRE</th>
                <th>PUESTO</th>
                <th>FECHA DE INGRESO</th>
                <th>CALIFICACION</th>
                <th>STATUS</th>
                <th>GENERAR FIRMA</th>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>Aprobado</td>
                <td> <a href="#popup">FIRMAR</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>Aprobado</td>
                <td> <a href="#popup">FIRMAR</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>Aprobado</td>
                <td> <a href="#popup">FIRMAR</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>Aprobado</td>
                <td> <a href="#popup">FIRMAR</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>Aprobado</td>
                <td> <a href="#popup">FIRMAR</a></td>
            </tr>
        </table>
        <div id="popup" class="overlay">
            <div id="popupBody">
                <h2>POR FAVOR INGRESA TU FIRMA</h2>
                <a id="cerrar" href="#">&times;</a>
                <div class="popupContent">
                    <input type="text" name="name" value="" />

                </div>
                <a href="#pupop">enviar</a>
            </div>
        </div>
        <div id="pupop" class="overlay">
            <div id="popupBody">
                <h2>FIRMAS ENVIADAS CON EXITO</h2>
                <a href=@Url.Action("Sesion")>regresar al inicio</a>
            </div>
        </div>
    </div>
    
</body>
</html>
