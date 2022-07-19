using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Models
{
    class ModelClass : BaseClass
    {
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tabela"></param>
        public ModelClass(Model.MD_Tabela tabela) : base(tabela)
        {

        }

        /// <summary>
        /// Método que cria a base da classe
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CriarBaseClasse()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using DevtoolsAPI.Entity.Entidades.$[NAMESPACEENTIDADE];");
            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Data.Common;");
            builder.AppendLine("");
            builder.AppendLine("namespace DevtoolsAPI.Entity.Models.$[NAMESPACE]");
            builder.AppendLine("{");
            builder.AppendLine("    /// <summary>");
            builder.AppendLine("    /// [$[TABELACLASSE]] $[DESCRICAOTABELACLASSE]");
            builder.AppendLine("    /// </summary>");
            builder.AppendLine("    public class $[NOMECLASSE] ");
            builder.AppendLine("    {");
            builder.AppendLine("        #region Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// DAO que representa a classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        public Utils.DAO.$[NOMESPACEDAO].$[NOMECLASSE] baseDao = null;");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("        #region Construtores");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Construtor principal da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"nome\"></param>");
            builder.AppendLine("        public $[NOMECLASSE]($[CONSTRUTORPARAMETROS])");
            builder.AppendLine("        {");
            builder.AppendLine("            Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("            this.baseDao = new Utils.DAO.$[NOMESPACEDAO].$[NOMECLASSE]($[CONSTRUTORPARAMETROSPASSAGEM]);");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Construtor secundário da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        public $[NOMECLASSE]()");
            builder.AppendLine("        {");
            builder.AppendLine("            Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("            this.baseDao = new Utils.DAO.$[NOMESPACEDAO].$[NOMECLASSE]();");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Construtores");
            builder.AppendLine("");
            builder.AppendLine("        #region Métodos");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz inserção");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"novo\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public static bool Insere($[NOMEENTIDADE] novo)");
            builder.AppendLine("        {");
            builder.AppendLine("            Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]().Insere()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("");
            builder.AppendLine("            $[NOMECLASSE] resultado = new $[NOMECLASSE]();");
            builder.AppendLine("            resultado.baseDao = new Utils.DAO.$[NOMESPACEDAO].$[NOMECLASSE]()");
            builder.AppendLine("            {");
            builder.AppendLine("                $[ATRIBUICAOINSERCAO]");
            builder.AppendLine("            };");
            builder.AppendLine("");
            builder.AppendLine("            return resultado.baseDao.Insert();");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz atualização");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"novo\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public static bool Atualiza($[NOMEENTIDADE] novo)");
            builder.AppendLine("        {");
            builder.AppendLine("            Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]().Atualiza()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("");
            builder.AppendLine("            $[NOMECLASSE] resultado = new $[NOMECLASSE]($[CONSTRUTORPARAMETROSPASSAGEMNOVO]);");
            builder.AppendLine("            resultado.baseDao = new Utils.DAO.$[NOMESPACEDAO].$[NOMECLASSE]()");
            builder.AppendLine("            {");
            builder.AppendLine("                $[ATRIBUICAOINSERCAO]");
            builder.AppendLine("            };");
            builder.AppendLine("");
            builder.AppendLine("            return resultado.baseDao.Update();");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz exclusão");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"nome\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public static bool Deleta($[CONSTRUTORPARAMETROS])");
            builder.AppendLine("        {");
            builder.AppendLine("            Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]().Deleta()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("");
            builder.AppendLine("            $[NOMECLASSE] resultado = new $[NOMECLASSE]($[CONSTRUTORPARAMETROSPASSAGEM]);");
            builder.AppendLine("");
            builder.AppendLine("            return resultado.baseDao.Delete();");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz a busca");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"nome\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public static $[NOMEENTIDADE] BuscaResultado($[CONSTRUTORPARAMETROS])");
            builder.AppendLine("        {");
            builder.AppendLine("			Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]().BuscaResultado()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("            $[NOMECLASSE] resultados = new $[NOMECLASSE]($[CONSTRUTORPARAMETROSPASSAGEM]);");
            builder.AppendLine("");
            builder.AppendLine("            if (!resultados.baseDao.Empty)");
            builder.AppendLine("            {");
            builder.AppendLine("                return new $[NOMEENTIDADE]()");
            builder.AppendLine("                {");
            builder.AppendLine("                    $[DEDAOPARAENTIDADE]");
            builder.AppendLine("                };");
            builder.AppendLine("            }");
            builder.AppendLine("");
            builder.AppendLine("            return null;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que retorna a lista");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public static List<$[NOMEENTIDADE]> RetornaLista()");
            builder.AppendLine("        {");
            builder.AppendLine("            Utils.Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE]().RetornaLista()\", Utils.Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("");
            builder.AppendLine("            string sentenca = new Utils.DAO.$[NOMESPACEDAO].$[NOMECLASSE]().table.CreateCommandSQLTable();");
            builder.AppendLine("");
            builder.AppendLine("            List<$[NOMEENTIDADE]> lista = new List<$[NOMEENTIDADE]>();");
            builder.AppendLine("            DbDataReader reader = Utils.DataBase.Connection.Select(sentenca);");
            builder.AppendLine("");
            builder.AppendLine("            while (reader.Read())");
            builder.AppendLine("            {");
            builder.AppendLine("                $[NOMEENTIDADE] dao = new $[NOMEENTIDADE]();");
            builder.AppendLine("                $[DAOTOENTIDADE]");
            builder.AppendLine("                lista.Add(dao);");
            builder.AppendLine("            }");
            builder.AppendLine("            reader.Close();");
            builder.AppendLine("");
            builder.AppendLine("            return lista;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Métodos");
            builder.AppendLine("");
            builder.AppendLine("    }");
            builder.AppendLine("}");
            builder.AppendLine("");

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

                retorno = base.SalvaArquivo(Util.Global.app_classes_api_model_directory, RetornaNomeClasse(), texto, out mensagemErro);
            }
            catch (Exception e)
            {
                mensagemErro = $"Erro: {e.Message}";
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que retorna o nome da classe
        /// </summary>
        /// <returns></returns>
        public override string RetornaNomeClasse()
        {
            return "MD_" + base.RetornaNomeClasse();
        }

        /// <summary>
        /// Método que cria o namespace
        /// </summary>
        /// <returns></returns>
        public override string CriarNameSpace()
        {
            return base.RetornaNomePropriedade(base.Tabela.DAO.Projeto.Nome);
        }

        /// <summary>
        /// Método que monta o nome da variavel
        /// </summary>
        /// <param name="nomeCampo"></param>
        /// <returns></returns>
        public override string RetornaNomeVariavel(string nomeCampo)
        {
            return RemoveSpecialCharacters(nomeCampo).ToLower();
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
                Parametro = "$[NAMESPACEENTIDADE]",
                Valor = this.CriarNameSpace()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NAMESPACE]",
                Valor = this.CriarNameSpace()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[TABELACLASSE]",
                Valor = this.Tabela.DAO.Nome.ToUpper()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[DESCRICAOTABELACLASSE]",
                Valor = this.Tabela.DAO.Descricao.ToUpper()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMECLASSE]",
                Valor = this.RetornaNomeClasse()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMESPACEDAO]",
                Valor = this.CriarNameSpace()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CONSTRUTORPARAMETROS]",
                Valor = this.CriarParametrosConstrutor()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CONSTRUTORPARAMETROSPASSAGEM]",
                Valor = this.CriarParametrosConstrutorPassagem()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CONSTRUTORPARAMETROSPASSAGEMNOVO]",
                Valor = this.CriarParametrosConstrutorNovoPassagem()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[ATRIBUICAOINSERCAO]",
                Valor = this.CriarAtribuicaoCamposInsercao()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMEENTIDADE]",
                Valor = base.RetornaNomeClasse()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[DEDAOPARAENTIDADE]",
                Valor = this.MontaDeEntidadeParaDAO()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[DAOTOENTIDADE]",
                Valor = this.MontaDeDAOParaEntidade()
            });

            return retorno;
        }

        /// <summary>
        /// Método que cria os parâmetros do construtor
        /// </summary>
        /// <returns></returns>
        private string CriarParametrosConstrutor()
        {
            string retorno = new DAO.Construtor(this).MontaParametrosConstrutor();

            return retorno;
        }

        /// <summary>
        /// Método que cria o nome dos parâmetros de passagem para o DAO
        /// </summary>
        /// <returns></returns>
        private string CriarParametrosConstrutorPassagem()
        {
            string retorno = string.Empty;

            this.Tabela.CamposDaTabela().Where(c => c.DAO.PrimaryKey).ToList().ForEach(campo => retorno += ", " + this.RetornaNomeVariavel(campo.DAO.Nome));
            retorno = retorno.Count() > 1 ? retorno.Substring(1).Trim() : string.Empty;

            return retorno;
        }

        /// <summary>
        /// Método que cria o nome dos parâmetros de passagem para o DAO
        /// </summary>
        /// <returns></returns>
        private string CriarParametrosConstrutorNovoPassagem()
        {
            string retorno = string.Empty;

            this.Tabela.CamposDaTabela().Where(c => c.DAO.PrimaryKey).ToList().ForEach(campo => retorno += ", novo." + this.RetornaNomePropriedade(campo.DAO.Nome));
            retorno = retorno.Count() > 1 ? retorno.Substring(1).Trim() : string.Empty;

            return retorno;
        }

        /// <summary>
        /// Método que cria os campos de atribuição no insert
        /// </summary>
        /// <returns></returns>
        private string CriarAtribuicaoCamposInsercao()
        {
            string retorno = new MontaParametrosInsert(this).CriaParametrosInsert().ToString();

            return retorno;
        }

        /// <summary>
        /// Método que monta de Entidade para DAO
        /// </summary>
        /// <returns></returns>
        private string MontaDeEntidadeParaDAO()
        {
            string sentenca = new MontaDeEntidadeParaDAO(this).CriaParametros().ToString();

            return sentenca;
        }

        /// <summary>
        /// Método que monta de DAO para Entidade
        /// </summary>
        /// <returns></returns>
        private string MontaDeDAOParaEntidade()
        {
            string sentenca = new MontaDeDAOParaEntidade(this).CriaParametros().ToString();

            return sentenca;
        }
    }
}
