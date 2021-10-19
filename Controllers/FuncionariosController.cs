using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Starting_with_the_entity_framework.Database;
using Starting_with_the_entity_framework.Models;

namespace Starting_with_the_entity_framework.Controllers
{
    public class FuncionariosController: Controller
    {
        private readonly ApplicationDBContext _database;
        public FuncionariosController(ApplicationDBContext database)
        {
            this._database = database; //Injetando a DI do EF (Classe de configuração do EntityFramework) para que possamos manipular o bd nesse caso fazer um insert
        }


        public IActionResult Index(){
            var funcionarios = this._database.Funcionarios.ToList(); // Recebendo uma coleção de Funcionarios, tranformando em uma lista e armazenando na variavel
            return View(funcionarios);
        }
        public IActionResult Cadastrar() { // Método que retorna uma view, no caso a mesma com o nome do método View - Cadastrar
            return View();
        }

        [HttpPost] // Método POST que será chamado pela view Cadastrar, e receberá um formulario (Objeto Funcionario já está sendo tipado direto na view)
        public IActionResult Salvar(Funcionario funcionario) {
            this._database.Funcionarios.Add(funcionario); //Chamando o método add() que simula o insert, e como a classe é funcionarios como a Entidade no qual a tabela foi baseada passamos ela como data.
            this._database.SaveChanges(); //Salvando as mudanças, simulando o commit
            return RedirectToAction("Index");
        }
    }
}