Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Afirmar() As ActionResult
        Return View()
    End Function
    Function About() As ActionResult
        Return View()
    End Function
    Function Index() As ActionResult
        Return View()
    End Function

    Function Nuevas() As ActionResult
        Return View()
    End Function
    Function Consulta() As ActionResult
        Return View()
    End Function
    Function Evaluacion() As ActionResult
        Return View()
    End Function
    Function Sesion() As ActionResult
        Return View()
    End Function
    Function Botones() As ActionResult
        Return View()
    End Function
    Function SesionAdmin() As ActionResult
        Return View()
    End Function
    Function Status() As ActionResult
        Return View()
    End Function
    Function Firmas() As ActionResult
        Return View()
    End Function
    Function NewUser() As ActionResult
        Return View()
    End Function
    Function TabPay() As ActionResult
        Return View()
    End Function
    <HttpPost>
    Function ButtonClicked() As ActionResult
        ' Aquí puedes poner el código para manejar el evento de clic del botón en el servidor
        Return RedirectToAction("SesionAdmin")
    End Function

End Class
