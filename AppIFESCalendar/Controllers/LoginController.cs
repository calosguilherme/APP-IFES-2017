using System;

public class LoginController
{
    public ActionResult Logar(Usuario u){
        if (nome == "admin" && senha == 123)
        {
            return RedirecionarAcao("Inicio");
        }
        else
            return RedirecionarAcao("ErroLogin");
}

}
