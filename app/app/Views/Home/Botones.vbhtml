﻿@Code
    ViewData("Title") = "Botones"
End Code

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="~/Content/MenuAdmin.css" rel="stylesheet" />
    <title></title>
</head>

<body>
    <h1 class="titulo_sesion">¿Que tipo de empleado eres?</h1>
    <div class="Botones_sesion">

        <a class="boton1" href="@Url.Action("Sesion")">Supervisor</a>
        <a class="boton2" href="@Url.Action("SesionAdmin")">RH</a>
    </div>
</body>
</html>