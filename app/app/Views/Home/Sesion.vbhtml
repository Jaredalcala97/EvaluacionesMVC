@Code
    ViewData("Title") = "Sesion"
End Code

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <link href="~/Content/Menu.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="~/Content/popup.css" rel="stylesheet" type="text/css" />
    <link href="~/Scripts/Menu.js" rel="stylesheet" />
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
                <i href="#" id="Sesion" class="bi bi-house-door-fill home"></i>
            </li>
            <li>
                <i href="#" id="Index" class="bi bi-box-arrow-right logout"></i>
            </li>
        </ul>
    </nav>

    <!-- Perfil del usuario -->
    <div class="message">
        <h1>BIENVENIDO AL SISTEMA DE EVALUACION DE EMPLEADOS</h1>
    </div>
    <div class="profile-body">
        <article class="profile">
            <div class="profile-image">
                <img src="https://media.licdn.com/dms/image/D5603AQFf70ZxP3K7iw/profile-displayphoto-shrink_800_800/0/1696526156806?e=1712188800&v=beta&t=w3lZeExFKMsihW9XXZhP43L94aRfXpsbVJxRTLT7Bfo" alt="imagen" />
            </div>
            <h2 class="Profile-username">Jared Alcalá</h2>
            <small class="profile-user-rol">practicante</small>

            <div class="profile-links">
                <a href="#" id="Afirmar" class="link1 ph-revisar-btn">Por Firmar</a>
                <a href="#" id="NuevaE"  class="link2 ph-empezar-btn">Por Realizar</a>
                <a href="#" id="Consulta"class="link3 ph-finalizadas-btn">Finalizadas</a>
            </div>
        </article>
        <div id="infopopup" class="overlay">
            <div id="popupBody">
                <h2>esta es la seccion de informacion</h2>
                <a href="#" id="Sesion">OK</a>
            </div>
        </div>
    </div>
    <script src="~/Scripts/RouteNav.js"></script>
</body>
</html>
