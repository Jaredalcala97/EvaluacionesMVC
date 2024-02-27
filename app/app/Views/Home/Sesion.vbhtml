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

    /* Perfil del usuario */
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

                <a href=@Url.Action("Afirmar")
                   class="link1">
                    <i class="ph-revisar-btn">Por Firmar</i>
                </a>
                <a href=@Url.Action("Nuevas") class="link2">
                    <i class="ph-empezar-btn">Por Realizar</i>
                </a>
                <a href=@Url.Action("Consulta") class="link3">
                    <i class="ph-finalizadas-btn">Finalizadas</i>
                </a>

            </div>

        </article>
        <div id="infopopup" class="overlay">
            <div id="popupBody">
                <h2>esta es la seccion de informacion</h2>
                <a href=@Url.Action("Sesion")>OK</a>
            </div>
        </div>
    </div>   
</body>
</html>
