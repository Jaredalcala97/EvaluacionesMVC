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
    <div class="container">
        <div class="text">
            Registro de Nuevo Empleado
        </div>
        <form action="#">
            <div class="form-row">
                <div class="input-data">
                    <input type="text" required>
                    <div class="underline"></div>
                    <label for="">First Name</label>
                </div>
                <div class="input-data">
                    <input type="text" required>
                    <div class="underline"></div>
                    <label for="">Last Name</label>
                </div>
            </div>
            <div class="form-row">
                <div class="input-data">
                    <input type="text" required>
                    <div class="underline"></div>
                    <label for="">Knumber</label>
                </div>

                <div class="input-data">
                    <input type="text" required>
                    <div class="underline"></div>
                    <label for="">Rol</label>
                </div>
            </div>
            <div class="form-row">
                <div class="input-data">
                    <input type="text" required>
                    <div class="underline"></div>
                    <label for="">Departamento</label>
                </div>
                <div class="input-data">
                    <input type="text" required>
                    <div class="underline"></div>
                    <label for="">Supervisor</label>
                </div>

            </div>
            <div class="form-row">
                <div class="input-data textarea">
                    <div class="form-row submit-btn">
                        <div class="input-data">
                            <div class="inner"></div>
                            <input type="submit" value="submit" onclick="mostrarElemento()">

                        </div>
                    </div>
                </div>
            </div>
            <div class="form-row" id="Salir">
                <button type="button" id="SesionAdminButton">
                    volver al inicio
                </button>
            </div>
        </form>
    </div>



    <div class="seAgregaUser" id="elementoParaMostrar">
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
