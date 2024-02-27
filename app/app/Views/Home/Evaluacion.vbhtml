@Code
    ViewData("Title") = "Evaluacion"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="~/Content/Consulta.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/alerts.css" rel="stylesheet" />
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
                <a href="#Alertpopup">
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
    <button type="reset" style="z-index:999"> <a href="#propro">Finalizar</a></button>
    <div class="propro">
        <section>
            <div class="square_box box_three"></div>
            <div class="square_box box_four"></div>
            <div class="container mt-5">
                <div class="row">

                    <div class="col-sm-12">
                        <div class="alert fade alert-simple alert-success alert-dismissible text-left font__family-montserrat font__size-16 font__weight-light brk-library-rendered rendered show">
                            <button type="button" class="close font__size-18" data-dismiss="alert">
                                <span aria-hidden="true">
                                    <a>
                                        <i class="fa fa-times greencross"></i>
                                    </a>
                                </span>
                                <span class="sr-only">Close</span>
                            </button>
                            <i class="start-icon far fa-check-circle faa-tada animated"></i>
                            <strong class="font__weight-semibold">Well done!</strong> You successfullyread this important.
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <div id="Alertpopup" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>Si sales ahora tu progreso en la evaluacion se perdera</h2>
            <h3>¿Estas seguro de continuar?</h3>
            <a href=@Url.Action("Sesion")>CONTINUAR</a>
            <a id="cerrar" href="#">&times;</a>
        </div>
    </div>


</body>
</html>
