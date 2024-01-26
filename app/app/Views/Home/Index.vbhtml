@Code
    ViewData("Title") = "Home Page"
End Code
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link href="Site.css" rel="stylesheet" />
    <link href="index.js" rel="stylesheet" />
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
                <button type="button" id="btnLogin"> Login </button>

            </div>

        </form>

    </article>
</body>
</html>
