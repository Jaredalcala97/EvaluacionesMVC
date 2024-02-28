@Code
    ViewData("Title") = "TabPay"
End Code

<!DOCTYPE html>
<html lang="es">
<head>
    <title>Calculadora de Sueldo</title>
    <meta charset="UTF-8">
    <link href="~/Content/Menu.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/TabPay.css" rel="stylesheet" />
</head>

<body>

    <nav>
        <img src="~/images/logo.png" alt="Alternate Text" />
        <ul>
            <li>
                <a href="#infopopup">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>
            <li>
                <a href="@Url.Content("SesionAdmin")">
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
    <div class="message">
        <h1>tabulador de sueldos</h1>
        <div id="infopopup" class="overlay">
            <div id="popupBody">
                <a id="cerrar" href="#">&times;</a>
                <h2>esta es la seccion de informacion</h2>
                <a href=@Url.Action("SesionAdmin")>OK</a>
            </div>
        </div>
    </div>



    <!--comienza la calculadora-->

    <table>
        <tr>
            <th></th>
            <th>DESDE</th>
            <th>HASTA </th>
            <th>% A APLICAR</th>
            <th>SOBRE EL EXCESO DE</th>
            <th> MÁS CUOTA FIJA DE</th>
        </tr>
        <tr>
            <td>I TRAMO</td>
            <td>$0.01</td>
            <td>$472.00</td>
            <td colspan="3">SIN RETENCIÓN</td>

        <tr>
            <td>II TRAMO</td>
            <td>$472.01</td>
            <td>$895.24</td>
            <td>10%</td>
            <td>$472.00</td>
            <td>$17.67</td>
        </tr>
        <tr>
            <td>III TRAMO</td>
            <td>$895.25</td>
            <td>$2,038.10</td>
            <td>20%</td>
            <td>$895.24</td>
            <td>$60.00</td>
        </tr>
        <tr>
            <td>IV TRAMO</td>
            <td>$2,038.11</td>
            <td>En adelante</td>
            <td>30%</td>
            <td>$2,038.11</td>
            <td>$288.57</td>

    </table>

    <h2>Calculadora de Sueldo</h2>
    <form id="formularioSueldo">
        <label for="nombre">Nombre:</label>
        <input type="text" id="nombre" name="nombre" required><br><br>
        <label for="sueldo">Sueldo:</label>
        <input type="number" id="sueldo" name="sueldo" required><br><br>
        <button type="submit" onclick="calcularSueldo()">Calcular Sueldo</button>


    </form>
    @Using Html.BeginForm("ButtonClicked", "Home", FormMethod.Post)
        @<button type="submit" class="btn btn-primary" style="max-width: 200px; display: flex; justify-content:center;
            align-items: center">Volver al inicio</button>
    End Using
    <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
    <script src="~/Scripts/TabPay.js"></script>


</body>
</html>
