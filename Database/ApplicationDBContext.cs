using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Starting_with_the_entity_framework.Database
{
    public class ApplicationDBContext: DbContext  // Ao herdar de DbContext eu deixo indico ao ASP.NET que essa é a minha classe de configuração do Entity FrameWork
    { 
        /*O EF Core precisa que ao criar essa classe em que estamos seja carregado as opções de conexão.
            E após carregarmos essas opções de conexão temos que passar elas para a classe Pai.
            Que é DbContext no qual estamos herdando.
            Essa operação está sendo feito através do : base(options) que passa o parametro do construtor.
            Para a classe pai que no caso é DbContext
        */
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 
            
        }
    }
}