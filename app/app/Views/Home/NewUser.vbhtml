@Code
    ViewData("Title") = "NewUser"
End Code

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <link href="~/Content/Menu.css" rel="stylesheet" />
    <link href="~/Content/NewUser.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    <title>Bombardier</title>
</head>

<body>

    <nav>
        <a href="#" class="session">

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
                <a href="#" id="SesionAdmin" class="bi bi-house-door-fill home"></a>
            </li>
            <li>
                <a href="#" id="Index" class="bi bi-box-arrow-right logout"></a>
            </li>
        </ul>
    </nav>
    <h1>Formulario de nuevo usuario</h1>
    <div>
        <form action="action_page.php">
            <div class="container">
                <h1>Register</h1>
                <p>Please fill in this form to create an account.</p>
                <hr>

                <label for="email"><b>Email</b></label>
                <input type="text" placeholder="Enter Email" name="email" id="email" required>

                <label for="psw"><b>Password</b></label>
                <input type="password" placeholder="Enter Password" name="psw" id="psw" required>

                <label for="psw-repeat"><b>Repeat Password</b></label>
                <input type="password" placeholder="Repeat Password" name="psw-repeat" id="psw-repeat" required>
                <hr>

                <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.</p>
                <button type="submit" class="registerbtn">Register</button>
            </div>

            <div class="container signin">
                <p>Already have an account? <a href="#">Sign in</a>.</p>
            </div>
        </form>
    </div>
    <div class="alert alert-success seAgregaUser" id="elementoParaMostrar">
        <span class="closebtn" onclick="this.parentElement.style.display='none';">X</span>
        <h3>Usuario Agregado Exitosamente</h3>
    </div>

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
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            // Selecciona todos los enlaces con la clase 'sesion-link'
            var links = document.querySelectorAll(".session");

            // Añade un manejador de eventos a cada enlace
            links.forEach(function (link) {
                link.addEventListener("click", function (event) {
                    event.preventDefault(); // Previene la navegación predeterminada del enlace

                    // Redirige a la página 'Index'
                    window.location.href = "SesionAdmin";
                });
            });
        });
    </script>
    <script src="~/Scripts/NewUser.js"></script>
    <script src="~/Scripts/RouteNav.js"></script>
    <div>
        <footer>

            <div class="finale">
                <div class="centered">
                    <h2>Servicio de Evaluación de Empleados</h2>
                    <p>Derechos reservados Bombardier mexico</p>
                    <p>autor Jared Helaman Alcalá Alvarado</p>
                </div>
            </div>

        </footer>
    </div>
</body>
</html>
