@Code
    ViewData("Title") = "Info"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<p>Use this area to provide additional information.</p>


<div class="button">
    <a href="@Url.Action("Sesion")">back</a>
    <button type="button" id="btnLogin">
        
    </button>

</div>