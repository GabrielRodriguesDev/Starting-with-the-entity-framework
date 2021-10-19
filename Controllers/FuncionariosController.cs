using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Starting_with_the_entity_framework.Models;

namespace Starting_with_the_entity_framework.Controllers
{
    public class FuncionariosController: Controller
    {
        public IActionResult Cadastrar() { // Método que retorna uma view, no caso a mesma com o nome do método View - Cadastrar
            return View();
        }

        [HttpPost] // Método POST que será chamado pela view Cadastrar, e receberá um formulario (Objeto Funcionario já está sendo tipado direto na view)
        public IActionResult Salvar(Funcionario funcionario) {
            return Content(funcionario.Nome + " " + funcionario.Salario + " " + funcionario.Cpf);
        }
    }
}