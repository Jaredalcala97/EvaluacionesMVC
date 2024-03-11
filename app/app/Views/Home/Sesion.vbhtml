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
    <title>Bombardier</title>
</head>

<body>

    <nav>
        <a href="@Url.Action("Sesion")">

            <img src="~/images/logo.png" alt="Alternate Text" />

        </a>
        <ul>

            <li>
                <a class="start" href="#">Sesion Activa de Jared Alcalá</a>
            </li>
            <li>
                <a href="#infopopup">
                    <i class="bi bi-info-circle-fill info"></i>
                </a>
            </li>
            <li>
                <a href="#" id="Sesion" class="bi bi-house-door-fill home"></a>
            </li>
            <li>
                <a href="#" id="Index" class="bi bi-box-arrow-right logout"></a>
            </li>
        </ul>
    </nav>

    <!-- Perfil del usuario -->
    <div class="message">
        <h1>BIENVENIDO AL SISTEMA DE EVALUACIÓN DE EMPLEADOS</h1>
    </div>
    <div class="profile-body">
        <article class="profile">
            <div class="profile-image">
                <img src="https://media.licdn.com/dms/image/D5603AQFf70ZxP3K7iw/profile-displayphoto-shrink_800_800/0/1696526156806?e=1712188800&v=beta&t=w3lZeExFKMsihW9XXZhP43L94aRfXpsbVJxRTLT7Bfo" alt="imagen" />
            </div>
            <h2 class="Profile-username">Jared Alcalá</h2>
            <small class="profile-user-rol">Practicánte</small>

            <div class="profile-links">
                <a href="#" id="Afirmar" class="link1 ph-revisar-btn">Por Firmar</a>
                <a href="#" id="NuevaE" class="link2 ph-empezar-btn">Por Realizar</a>
                <a href="#" id="Consulta" class="link3 ph-finalizadas-btn">Finalizadas</a>
            </div>
        </article>
        <div id="infopopup" class="overlay">
            <div id="popupBody">
                <h2>esta es la seccion de información</h2>
                <a href="#" id="Sesion">OK</a>
            </div>
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

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            // Selecciona todos los enlaces con la clase 'sesion-link'
            var links = document.querySelectorAll(".start");

            // Añade un manejador de eventos a cada enlace
            links.forEach(function (link) {
                link.addEventListener("click", function (event) {
                    event.preventDefault(); // Previene la navegación predeterminada del enlace

                    // Redirige a la página 'Index'
                    window.location.href = "Index";
                });
            });
        });
    </script>
    <script src="~/Scripts/RouteNav.js"></script>
</body>
</html>
