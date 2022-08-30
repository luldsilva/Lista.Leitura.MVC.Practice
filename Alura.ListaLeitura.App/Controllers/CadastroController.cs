using Alura.ListaLeitura.App.Html;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class CadastroController
    {
        public IActionResult ExibeFormulario()
        {
            //var html = HtmlUtils.CarregaArquivoHTML("formulario");
            var html = new ViewResult { ViewName = "formulario" };    
            return html;
        }
        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return "Livro adicionado com sucesso.";
        }
    }
}
