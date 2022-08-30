using System.IO;

namespace Alura.ListaLeitura.App.Html
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHTML(string nomeArquivo)
        {
            var pathFile = $"Html/{nomeArquivo}.html";
            using (var file = File.OpenText(pathFile))
            {
                return file.ReadToEnd();
            }
        }
    }
}
