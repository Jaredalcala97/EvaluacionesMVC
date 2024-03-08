@Code
    ViewData("Title") = "Evaluacion"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Bombardier</title>
    <link href="~/Content/Consulta.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/alerts.css" rel="stylesheet" />
</head>
<body>
    <nav>
        <a href="@Url.Action("Sesion")">

            <img src="~/images/logo.png" alt="Alternate Text" />

        </a>        <ul>
            <li>
                <a href="#infopopup">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>

            <li><a href="#" id="#Alertpopup" class="bi bi-house-door-fill home"></a></li>
            <li><a href="#" id="Index" class="bi bi-box-arrow-right logout"></a></li>
        </ul>
    </nav>
    <div class="titulo">
        <h2>
            EVALUACION DEL DESEMPEÑO DEL EMPLEADO
        </h2>
    </div>
    <div class="Tabla">
        <table style="width:100%">
            <tr>
                <th></th>
                <th>5 Excelente</th>
                <th>4 Muy bueno</th>
                <th>3 Bueno </th>
                <th>2 Regular</th>
                <th>1 Deficiente</th>
            </tr>
            <tr>
                <td>Productividad / *Lleva acabo las actividades programadas en tiempo y con las especificaciones requeridas</td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>

            </tr>
            <tr>
                <td>Conocimiento/dominio de la operación / *Acorde a su nivel, habilidad en la operación que desempeña</td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>

            </tr>
            <tr>
                <td>Respuesta ante la supervisión / *Respeto por las reglas, instrucciones de trabajo</td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>

            </tr>
            <tr>
                <td>Iniciativa y creatividad / *Se anticipa a los requerimientos, muestra participación y/o ideas que mejoren las actividades</td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>

            </tr>
            <tr>
                <td>Trabajo con otros / *Trabajo en equipo, colaboración </td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>

            </tr>
            <tr>
                <td>Actitud / *Desenvolvimiento,  postura ante la operación, acercamiento hacia otros. </td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>
                <td><input id="Checkbox1" type="checkbox" /></td>

            </tr>

        </table>

    </div>
    <button type="reset" style="z-index:999" id="Alert"> </button>

    <div id="Alertpopup" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>Si sales ahora tu progreso en la evaluacion se perdera</h2>
            <h3>¿Estas seguro de continuar?</h3>
            <a href="#" id="Sesion">CONTINUAR</a>
            <a id="cerrar" href="#">&times;</a>
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
    <script src="~/Scripts/RouteNav.js"></script>
</body>
</html>
