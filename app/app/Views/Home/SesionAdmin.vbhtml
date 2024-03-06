@Code
    ViewData("Title") = "SesionAdmin"
End Code

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <link href="~/Content/Menu.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
    <title>Barra lateral HTML</title>
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
                <a href="#" id="SesionAdmin" class="bi bi-house-door-fill home"> </a>
            </li>
            <li>
                <a href="#" id="Index" class="bi bi-box-arrow-right logout"></a>
            </li>
        </ul>
    </nav>
    <div class="message">
        <h1>BIENVENIDO AL SISTEMA DE EVALUACIÓN DE EMPLEADOS</h1>
    </div>
    <div class="profile-body">
        <article class="profile">
            <div class="profile-image">
                <img src="https://media.licdn.com/dms/image/D5603AQFf70ZxP3K7iw/profile-displayphoto-shrink_800_800/0/1696526156806?e=1712188800&v=beta&t=w3lZeExFKMsihW9XXZhP43L94aRfXpsbVJxRTLT7Bfo" alt="imagen" />
            </div>
            <h2 class="Profile-username">Jared Alcalá</h2>
            <small class="profile-user-rol">RH</small>

            <div class="profile-links">

                <a href="#" id="Firmas" class="link1">
                    Firmas Faltantes
                </a>
                <a href="#" id="Status" class="link2">
                    Status de las Evaluaciones
                </a>
                <a href="#" id="NewUser" class="link3">
                    Agregar Nuevos Empleados
                </a>
                <a href="#" id="TabPay" class="link4">
                    Tabulador de sueldos
                </a>
            </div>

        </article>
        <div id="infopopup" class="overlay">
            <div id="popupBody">
                <a id="cerrar" href="#">&times;</a>
                <h2>esta es la seccion de informacion</h2>
                <a href="#" id="SesionAdminPop">OK</a>
            </div>
        </div>
    </div>
    <script src="~/Scripts/RouteNav.js"></script>
    <footer>


    </footer>
</body>

</html>
