@Code
    ViewData("Title") = "NuevaE"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="~/Content/Nuevas.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popupPF.css" rel="stylesheet" type="text/css" />
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
                <td>Carlos Herrera</td>
                <td><a href="#InfoUser">Inspector de calidad</a></td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="#" id="Evaluacion">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td><a href="#InfoUser">Inspector de calidad</a></td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="#" id="Evaluacion">INICIAR EVALUACION</a></td>
    
            </tr>
            <tr>
                <td>Vicente Herrera</td>
                <td><a href="#InfoUser">Inspector de calidad</a></td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="#" id="Evaluacion">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td>Luis Capetillo</td>
                <td><a href="#InfoUser">Inspector de calidad</a></td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="#" id="Evaluacion">INICIAR EVALUACION</a></td>
            </tr>
            <tr>
                <td>Fernando Alonzo</td>
                <td><a href="#InfoUser">Inspector de calidad</a></td>
                <td>12-06-2020</td>
                <td>07-23-2023</td>
                <td> <a href="#" id="Evaluacion">INICIAR EVALUACION</a></td>
            </tr>
        </table>
        <div id="InfoUser" class="overlay">
            <div id="popupBody">
                <a id="cerrar" href="#">&times;</a>
                <div class="titulos">
                    <h3>
                        HABILIDADES TÉCNICAS POR ÁREA
                    </h3>
                    <h4>Seleccione la opción que corresponda en relación al dominio de la actividad del puesto</h4>
                </div>
                <table class="NuevoPopup" style="width:100%; position:initial; background-color:cornflowerblue; overflow-y:scroll; overflow-x: scroll;">
                    <tr class="titulo1">
                        <th></th>
                        <th>N1</th>
                        <th>N2</th>
                        <th>N3</th>
                        <th>N4</th>
                        <th>N5</th>

                    </tr>
                    <tr class="titulo2">
                        <th>INITIAL</th>
                        <th>3 months</th>
                        <th>6 months</th>
                        <th>12 months / 1 year</th>
                        <th>24 months / 2 year</th>
                        <th>36 months / 3 year</th>
                    </tr>
                    <tr class="campos">
                        <th>TECNICO DE LA INTEGRIDAD DE LA PLANEACIÓN MAESTRA</th>
                        <th>
                            "Realizar nesteos
                            Generar e imprimir ordenes de producción
                            Generar split (s)
                            Conciliar scrap
                            Revisión y modificación de PDLV y STO parciales
                            Emitir el shopload y dar seguimiento."

                        </th>
                        <th>
                            "Realizar nesteos 
                            Generar e imprimir ordenes de producción
                            Generar split (s)
                            Conciliar scrap
                            Revisión y modificación de PDLV y STO parciales
                            Emitir el shopload y dar seguimiento."
                        </th>
                        <th>
                            "Planeación detallada
                            Reservaciones
                            Cambio en tamaño de lotes
                            MRP overview
                            Conversión de ordenes planeadas firmes"

                        </th>
                        <th>
                            "MPS (Master Production Schedule).
                            CRP (Capacity Requirements Planning)
                            Notificaciones de cambio en IMP de proyectos"
                        </th>
                        <th>
                            "MPS (Master Production Schedule).
                            CRP (Capacity Requirements Planning)
                            Notificaciones de cambio en IMP de proyectos"
                        </th>
                    </tr>
                    <tr class="calificable1">
                        <th>
                            Ausentismo
                        </th>
                        <th>
                            0

                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                    </tr>

                    <tr class="calificable2">
                        <th>
                            Disciplina
                        </th>
                        <th>
                            0

                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                    </tr>
                    <tr class="calificable3">
                        <th>
                            SCRAP

                        </th>
                        <th>
                            0

                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                        <th>
                            0
                        </th>
                    </tr>
                    
                    
                </table>
                <a href="#" id="NuevaE">OK</a>
            </div>
        </div>
    </div>   
    <script src="~/Scripts/RouteNav.js"></script>
</body>
</html>
