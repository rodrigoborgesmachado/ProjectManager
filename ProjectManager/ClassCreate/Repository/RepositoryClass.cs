using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Repository
{
    class RepositoryClass : BaseClass
    {
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tabela"></param>
        public RepositoryClass(Model.MD_Tabela tabela) : base(tabela)
        {

        }

        /// <summary>
        /// Método que cria a base da classe
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CriarBaseClasse()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using DevtoolsAPI.Entity.Entidades.$[NAMESPACE];");
            builder.AppendLine("using DevtoolsAPI.InterfaceRepository;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Configuration;");
            builder.AppendLine("");
            builder.AppendLine("namespace DevtoolsAPI.Repository");
            builder.AppendLine("{");
            builder.AppendLine("    public class $[NAMECLASS] : $[NAMECLASSINTERFACE]");
            builder.AppendLine("    {");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz atualização");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public $[ENTIDADE] Atualiza($[ENTIDADE] $[ENTIDADEVARIAVEL])");
            builder.AppendLine("        {");
            builder.AppendLine("            $[ENTIDADE] retorno = null;");
            builder.AppendLine("");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.OpenConection(ConfigurationManager.ConnectionStrings[\"LocalSqlServer\"].ConnectionString);");
            builder.AppendLine("                retorno = Entity.Models.$[NAMESPACE].$[CLASSEMODEL].Atualiza($[ENTIDADEVARIAVEL]) ? $[ENTIDADEVARIAVEL] : null;");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.CloseConnection();");
            builder.AppendLine("            }");
            builder.AppendLine("");
            builder.AppendLine("            return retorno;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz o delete");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public bool Deleta($[PARAMETROSBUSCA])");
            builder.AppendLine("        {");
            builder.AppendLine("            bool retorno = false;");
            builder.AppendLine("");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.OpenConection(ConfigurationManager.ConnectionStrings[\"LocalSqlServer\"].ConnectionString);");
            builder.AppendLine("                retorno = Entity.Models.$[NAMESPACE].$[CLASSEMODEL].Deleta($[CHAMADABUSCA]);");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.CloseConnection();");
            builder.AppendLine("            }");
            builder.AppendLine("");
            builder.AppendLine("            return retorno;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz a busca total");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public List<$[ENTIDADE]> Get()");
            builder.AppendLine("        {");
            builder.AppendLine("            List<$[ENTIDADE]> retorno = new List<$[ENTIDADE]>();");
            builder.AppendLine("");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.OpenConection(ConfigurationManager.ConnectionStrings[\"LocalSqlServer\"].ConnectionString);");
            builder.AppendLine("                retorno = Entity.Models.$[NAMESPACE].$[CLASSEMODEL].RetornaLista();");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.CloseConnection();");
            builder.AppendLine("            }");
            builder.AppendLine("");
            builder.AppendLine("            return retorno;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz a busca");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"nome\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public $[ENTIDADE] Get($[PARAMETROSBUSCA])");
            builder.AppendLine("        {");
            builder.AppendLine("            $[ENTIDADE] retorno = null;");
            builder.AppendLine("");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.OpenConection(ConfigurationManager.ConnectionStrings[\"LocalSqlServer\"].ConnectionString);");
            builder.AppendLine("                retorno = Entity.Models.$[NAMESPACE].$[CLASSEMODEL].BuscaResultado($[CHAMADABUSCA]);");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.CloseConnection();");
            builder.AppendLine("            }");
            builder.AppendLine("");
            builder.AppendLine("            return retorno;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que insere o registro");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"$[ENTIDADEVARIAVEL]\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public $[ENTIDADE] Insere($[ENTIDADE] $[ENTIDADEVARIAVEL])");
            builder.AppendLine("        {");
            builder.AppendLine("            $[ENTIDADE] retorno = null;");
            builder.AppendLine("");
            builder.AppendLine("            try");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.OpenConection(ConfigurationManager.ConnectionStrings[\"LocalSqlServer\"].ConnectionString);");
            builder.AppendLine("                retorno = Entity.Models.$[NAMESPACE].$[CLASSEMODEL].InsereResultado($[ENTIDADEVARIAVEL]) ? $[ENTIDADEVARIAVEL] : null;");
            builder.AppendLine("            }");
            builder.AppendLine("            catch");
            builder.AppendLine("            {");
            builder.AppendLine("                Utils.DataBase.Connection.CloseConnection();");
            builder.AppendLine("            }");
            builder.AppendLine("");
            builder.AppendLine("            return retorno;");
            builder.AppendLine("        }");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            return builder;
        }

        /// <summary>
        /// Método que cria a clase
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

                retorno = base.SalvaArquivo(Util.Global.app_classes_api_repository_directory, RetornaNomeClasse(), texto, out mensagemErro);
            }
            catch (Exception e)
            {
                mensagemErro = $"Erro: {e.Message}";
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o namspace
        /// </summary>
        /// <returns></returns>
        public override string CriarNameSpace()
        {
            return base.RetornaNomePropriedade(this.Tabela.DAO.Nome);
        }

        /// <summary>
        /// Método que cria o nome da classe
        /// </summary>
        /// <returns></returns>
        public override string RetornaNomeClasse()
        {
            return base.RetornaNomeClasse() + "Repository";
        }

        /// <summary>
        /// Método que cria os parâmetros
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
                Parametro = "$[NAMECLASS]",
                Valor = this.RetornaNomeClasse()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NAMECLASSINTERFACE]",
                Valor = this.MontaNomeClasseInterface()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[ENTIDADE]",
                Valor = this.MontaNomeClasseEntidade()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[ENTIDADEVARIAVEL]",
                Valor = this.RetornaNomeVariavel(this.MontaNomeClasseEntidade())
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CLASSEMODEL]",
                Valor = this.MontaNomeClasseModel()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[PARAMETROSBUSCA]",
                Valor = this.MontaNomeParametrosBusca()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CHAMADABUSCA]",
                Valor = this.MontaBuscaParametros()
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da classe da interface
        /// </summary>
        /// <returns></returns>
        private string MontaNomeClasseInterface()
        {
            string retorno = new InterfaceRepository.InterfaceRepositoryClass(this.Tabela).RetornaNomeClasse();

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da classe da entidade
        /// </summary>
        /// <returns></returns>
        private string MontaNomeClasseEntidade()
        {
            string retorno = new Entidade.EntidadeClass(this.Tabela).RetornaNomeClasse();

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da classe da model
        /// </summary>
        /// <returns></returns>
        private string MontaNomeClasseModel()
        {
            string retorno = new Models.ModelClass(this.Tabela).RetornaNomeClasse();

            return retorno;
        }

        /// <summary>
        /// Método que monta os parâmetros de busca
        /// </summary>
        /// <returns></returns>
        public string MontaNomeParametrosBusca()
        {
            string retorno = new DAO.Construtor(this).MontaParametrosConstrutor().ToString();

            return retorno;
        }

        /// <summary>
        /// Método que monta a busca pelos parâmetros
        /// </summary>
        /// <returns></returns>
        public string MontaBuscaParametros()
        {
            string retorno = string.Empty;

            this.Tabela.CamposDaTabela().Where(c => c.DAO.PrimaryKey).ToList().ForEach(campo => retorno += ", " + this.RetornaNomeVariavel(campo.DAO.Nome));
            retorno = retorno.Count() > 1 ? retorno.Substring(1).Trim() : string.Empty;

            return retorno;
        }
    }
}
