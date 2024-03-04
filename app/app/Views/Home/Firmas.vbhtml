@Code
    ViewData("Title") = "Firmas"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="~/Content/Firmas.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popupF.css" rel="stylesheet" type="text/css" />
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
                <th>CALIFICACION</th>
                <th>SIGUIENTE EVALUACION</th>
                <th>STATUS</th>
                <th>FIRMAS FALTANTES</th>
            </tr>
            <tr>
                <td>Javier Hernandez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td>Aprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Cristiano Ronaldo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td>Reprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Alfredo Bustillo</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td>Aprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Marco Fabian</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
                <td>Reprobado</td>
                <td><a href="#popupF">Revisar</a></td>
            </tr>
            <tr>
                <td>Marcelo Lopez</td>
                <td>Inspector de calidad</td>
                <td>12-06-2020</td>
                <td>26/35</td>
                <td>12-06-2024</td>
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
                <h1>Fixed Table header</h1>
                <div class="tbl-header">
                    <table cellpadding="0" cellspacing="0" border="0">
                        <thead>
                            <tr>
                                <th>Code</th>
                                <th>Company</th>
                                <th>Price</th>
                                <th>Change</th>
                                <th>Change %</th>
                            </tr>
                        </thead>
                    </table>
                </div>
                <div class="tbl-content">
                    <table cellpadding="0" cellspacing="0" border="0">
                        <tbody>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                            <tr>
                                <td>AAC</td>
                                <td>AUSTRALIAN COMPANY </td>
                                <td>$1.38</td>
                                <td>+2.01</td>
                                <td>-0.36%</td>
                            </tr>
                            <tr>
                                <td>AAD</td>
                                <td>AUSENCO</td>
                                <td>$2.38</td>
                                <td>-0.01</td>
                                <td>-1.36%</td>
                            </tr>
                            <tr>
                                <td>AAX</td>
                                <td>ADELAIDE</td>
                                <td>$3.22</td>
                                <td>+0.01</td>
                                <td>+1.36%</td>
                            </tr>
                            <tr>
                                <td>XXD</td>
                                <td>ADITYA BIRLA</td>
                                <td>$1.02</td>
                                <td>-1.01</td>
                                <td>+2.36%</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </section>

            <a href="#popup2">Enviar Recordatorios</a>
        </div>
    </div>
    <div id="popup2" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>se enviara(n) 1 recordatorio(s)</h2>
            <a href="#popup3">Enviar Recordatorios</a>
        </div>
    </div>
    <div id="popup3" class="overlay">
        <div id="popupBody">
            <a id="cerrar" href="#">&times;</a>
            <h2>Envio de recordatorio(s) exitoso</h2>
            <a href="@Url.Action("SesionAdmin")">volver al menu</a>
        </div>
    </div>
    <script src="~/Scripts/RouteNav.js"></script>
</body>

</html>
