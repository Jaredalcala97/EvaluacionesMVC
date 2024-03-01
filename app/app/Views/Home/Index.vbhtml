@Code
    ViewData("Title") = "Home Page"
End Code


<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Evaluaciones</title>
    <link href="~/Content/Index.css" rel="stylesheet" />
    <link href="index.js" rel="stylesheet" />
    <link rel="manifest" href="/manifest.json">
    <link href="/" rel="stylesheet" />
</head>
<body>
    <article class="login">

        <img src="~/images/logo.png" alt="" />
        <h3>WELCOME TO THE EMPLOYEE EVALUATION SERVICE</h3>
        <h2> Please Login</h2>
        <form class="form" action="#" id=" formLogin">
            <div class="username">

                <input type="text" name="KeyNumber" id=" username " placeholder="Please introduce your Knumber" />
            </div>

            <div class="password">
                <input type="password" name="password" id="pass" placeholder="enter your password" />
            </div>

            <div class="button">
                <button type="button" id="Botones">
                    Login
                </button>

            </div>

        </form>

    </article>
    <script src="~/Scripts/RouteNav.js"></script>

</body>
</html>
