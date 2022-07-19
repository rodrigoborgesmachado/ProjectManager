using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Controller
{
    class ControllerClass : BaseClass
    {
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tabela"></param>
        public ControllerClass(Model.MD_Tabela tabela) : base(tabela)
        {

        }

        /// <summary>
        /// Método que cria a base da classe
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CriarBaseClasse()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Linq;");
            builder.AppendLine("using System.Web;");
            builder.AppendLine("using System.Web.Http;");
            builder.AppendLine("using DevtoolsAPI.Entity.Entidades;");
            builder.AppendLine("using DevtoolsAPI.Entity.Entidades.$[NAMESPACE];");
            builder.AppendLine("using DevtoolsAPI.InterfaceRepository;");
            builder.AppendLine("");
            builder.AppendLine("namespace DevToolsApi.Controllers");
            builder.AppendLine("{");
            builder.AppendLine("    [RoutePrefix(\"api/$[URL]\")]");
            builder.AppendLine("    public class $[NOMECLASSE] : ApiController");
            builder.AppendLine("    {");
            builder.AppendLine("        $[NOMEINTERFACEREPOSITORY] repository;");
            builder.AppendLine("");
            builder.AppendLine("        public $[NOMECLASSE]($[NOMEINTERFACEREPOSITORY] repository)");
            builder.AppendLine("        {");
            builder.AppendLine("            this.repository = repository;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        [HttpGet]");
            builder.AppendLine("        [Route(\"getAll\")]");
            builder.AppendLine("        public RetornoBaseLista<$[NOMEENTIDADE]> GetAll()");
            builder.AppendLine("        {");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoBaseLista<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Lista = repository.Get(),");
            builder.AppendLine("                    Mensagem = \"Busca realizada com sucesso\",");
            builder.AppendLine("                    Sucesso = true");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoBaseLista<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Lista = null,");
            builder.AppendLine("                    Mensagem = \"Erro ao buscar\",");
            builder.AppendLine("                    Sucesso = false");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        [HttpGet]");
            builder.AppendLine("        [Route(\"getItem\")]");
            builder.AppendLine("        public RetornoItem<$[NOMEENTIDADE]> GetItem($[CHAVEBUSCA])");
            builder.AppendLine("        {");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = repository.Get(nome),");
            builder.AppendLine("                    Mensagem = \"Busca realizada com sucesso\",");
            builder.AppendLine("                    Sucesso = true");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = null,");
            builder.AppendLine("                    Mensagem = \"Erro ao buscar\",");
            builder.AppendLine("                    Sucesso = false");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        [HttpPost]");
            builder.AppendLine("        [Route(\"insertItem\")]");
            builder.AppendLine("        public RetornoItem<$[NOMEENTIDADE]> InsertItem([FromBody]$[NOMEENTIDADE] $[NOMEVARIAVELENTIDADE])");
            builder.AppendLine("        {");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = repository.Insere($[NOMEVARIAVELENTIDADE]),");
            builder.AppendLine("                    Mensagem = \"Inserido com sucesso\",");
            builder.AppendLine("                    Sucesso = true");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = null,");
            builder.AppendLine("                    Mensagem = \"Erro ao inserir\",");
            builder.AppendLine("                    Sucesso = false");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        [HttpPost]");
            builder.AppendLine("        [Route(\"updateItem\")]");
            builder.AppendLine("        public RetornoItem<$[NOMEENTIDADE]> UpdateItem([FromBody] $[NOMEENTIDADE] $[NOMEVARIAVELENTIDADE])");
            builder.AppendLine("        {");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = repository.Atualiza($[NOMEVARIAVELENTIDADE]),");
            builder.AppendLine("                    Mensagem = \"Atualizado com sucesso\",");
            builder.AppendLine("                    Sucesso = true");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = null,");
            builder.AppendLine("                    Mensagem = \"Atualizado ao inserir\",");
            builder.AppendLine("                    Sucesso = false");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        [HttpDelete]");
            builder.AppendLine("        [Route(\"deleteItem\")]");
            builder.AppendLine("        public RetornoItem<$[NOMEENTIDADE]> DeleteItem($[CHAVEBUSCA])");
            builder.AppendLine("        {");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                bool retorno = repository.Deleta(nome);");
            builder.AppendLine("");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = null,");
            builder.AppendLine("                    Mensagem = (retorno ? \"Deletado com sucesso\" : \"Erro ao deletar\"),");
            builder.AppendLine("                    Sucesso = retorno");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                return new RetornoItem<$[NOMEENTIDADE]>()");
            builder.AppendLine("                {");
            builder.AppendLine("                    Objeto = null,");
            builder.AppendLine("                    Mensagem = \"Erro ao deletar\",");
            builder.AppendLine("                    Sucesso = false");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("        }");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            return builder;
        }

        /// <summary>
        /// Método que faz a criação da classe
        /// </summary>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public override bool CriarClasse(out string mensagemErro)
        {
            bool retorno = false;

            try
            {
                StringBuilder builder = this.CriarBaseClasse();
                List<KeyWords> parametros = this.CriarParametros();
                string texto = this.SubstituiParametros(builder.ToString(), parametros);

                retorno = base.SalvaArquivo(Util.Global.app_classes_api_controller_directory, RetornaNomeClasse(), texto, out mensagemErro);
            }
            catch (Exception e)
            {
                mensagemErro = $"Erro: {e.Message}";
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o nome do namespace
        /// </summary>
        /// <returns></returns>
        public override string CriarNameSpace()
        {
            return this.RetornaNomePropriedade(this.Tabela.DAO.Nome);
        }

        /// <summary>
        /// Método que cria o nome da classe
        /// </summary>
        /// <returns></returns>
        public override string RetornaNomeClasse()
        {
            return base.RetornaNomeClasse() + "Controller";
        }

        /// <summary>
        /// Método que cria o nome da variável
        /// </summary>
        /// <param name="nomeCampo"></param>
        /// <returns></returns>
        public override string RetornaNomeVariavel(string nomeCampo)
        {
            return RemoveSpecialCharacters(nomeCampo).ToLower();
        }

        /// <summary>
        /// Método que faz a criação dos parâmetros
        /// </summary>
        /// <returns></returns>
        public override List<KeyWords> CriarParametros()
        {
            List<KeyWords> retorno = new List<KeyWords>();

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NAMESPACE]",
                Valor = this.CriarNameSpace()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[URL]",
                Valor = this.RetornaNomeVariavel(this.Tabela.DAO.Nome)
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMECLASSE]",
                Valor = this.RetornaNomeClasse()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMEINTERFACEREPOSITORY]",
                Valor = this.RetornaNomeInterfaceRepository()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMEENTIDADE]",
                Valor = this.RetornaNomeEntidade()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CHAVEBUSCA]",
                Valor = this.RetornaChaveBusca()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMEVARIAVELENTIDADE]",
                Valor = this.RetornaNomeVariavel(this.RetornaNomeEntidade())
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da interface repository
        /// </summary>
        /// <returns></returns>
        private string RetornaNomeInterfaceRepository()
        {
            string retorno = new InterfaceRepository.InterfaceRepositoryClass(this.Tabela).RetornaNomeClasse();

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da interface repository
        /// </summary>
        /// <returns></returns>
        private string RetornaNomeEntidade()
        {
            string retorno = new Entidade.EntidadeClass(this.Tabela).RetornaNomeClasse();

            return retorno;
        }

        /// <summary>
        /// Método que retorna a chave de busca
        /// </summary>
        /// <returns></returns>
        private string RetornaChaveBusca()
        {
            string retorno = new DAO.Construtor(this).MontaParametrosConstrutor();

            return retorno;
        }
    }
}
