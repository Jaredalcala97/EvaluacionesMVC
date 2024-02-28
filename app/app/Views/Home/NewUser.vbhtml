@Code
    ViewData("Title") = "SesionAdmin"
End Code

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <link href="~/Content/Menu.css" rel="stylesheet" />
    <link href="~/Content/NewUser.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
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
                <a href="@Url.Content("SesionAdmin")">
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
    <div class="container">
        <div class="text">
            Registro de Nuevo Empleado
        </div>
        <form action="#" >
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
                <a href="@Url.Action("SesionAdmin")">Salir</a>
            </div>
        </form>
    </div>

    <div class="seAgregaUser" id="elementoParaMostrar">
        <span class="closebtn" onclick="this.parentElement.style.display='none';">X</span>
        <h3>Usuario Agregado Exitosamente</h3>
    </div>
    <script src="~/Scripts/NewUser.js"></script>


</body>
</html>
