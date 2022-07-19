using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class DAOClass : BaseClass
    {
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tabela"></param>
        public DAOClass(Model.MD_Tabela tabela) : base(tabela)
        {

        }

        /// <summary>
        /// Método que cria a classe
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

                retorno = base.SalvaArquivo(Util.Global.app_classes_api_dao_directory, RetornaNomeClasse(), texto, out mensagemErro);
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
        /// Método que cria a base da classe
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CriarBaseClasse()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("using System.Data.Common;");
            builder.AppendLine("");
            builder.AppendLine("namespace $[NAMESPACE]");
            builder.AppendLine("{");
            builder.AppendLine("");
            builder.AppendLine("    /// <summary>");
            builder.AppendLine("    /// [$[TABELACLASSE]] Tabela $[TABELACLASSE]");
            builder.AppendLine("    /// </summary>");
            builder.AppendLine("    public class $[NOMECLASSE] : MDN_Model");
            builder.AppendLine("    {");
            builder.AppendLine("        #region Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("$[ATRIBUTOSPROPRIEDADES]");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("        #region Construtores");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Construtor Principal da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        public $[NOMECLASSE]()");
            builder.AppendLine("            : base()");
            builder.AppendLine("        {");
            builder.AppendLine("            base.table = new MDN_Table(\"$[TABELACLASSE]\");");
            builder.AppendLine("$[CAMPOSTABELA]");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Construtor Secundário da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        public $[NOMECLASSE]($[CONSTRUTORPARAMETROS])");
            builder.AppendLine("            :this()");
            builder.AppendLine("        {");
            builder.AppendLine("            $[VALIDACAOPARAMETROSCONSTRUTOR]");
            builder.AppendLine("            this.Load();");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Construtores");
            builder.AppendLine("");
            builder.AppendLine("        #region Métodos");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz o load da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        public override void Load()");
            builder.AppendLine("        {");
            builder.AppendLine("            Util.CL_Files.WriteOnTheLog(\"$[NOMECLASSE].Load()\", Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("");
            builder.AppendLine("            string sentenca = base.table.CreateCommandSQLTable() + $\" WHERE $[WHERECONSULTA]\";");
            builder.AppendLine("            DbDataReader reader = DataBase.Connection.Select(sentenca);");
            builder.AppendLine("");
            builder.AppendLine("            if (reader == null)");
            builder.AppendLine("            {");
            builder.AppendLine("                this.Empty = true;");
            builder.AppendLine("            }");
            builder.AppendLine("            else if (reader.Read())");
            builder.AppendLine("            {");
            builder.AppendLine("                $[CAMPOSLOAD]");
            builder.AppendLine("");
            builder.AppendLine("                this.Empty = false;");
            builder.AppendLine("                reader.Close();");
            builder.AppendLine("            }");
            builder.AppendLine("            else");
            builder.AppendLine("            {");
            builder.AppendLine("                this.Empty = true;");
            builder.AppendLine("                reader.Close();");
            builder.AppendLine("            }");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz o delete da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns>True - sucesso; False - erro</returns>");
            builder.AppendLine("        public override bool Delete()");
            builder.AppendLine("        {");
            builder.AppendLine("            string sentenca = $\"DELETE FROM {base.table.Table_Name} WHERE $[WHERECONSULTA]\";");
            builder.AppendLine("");
            builder.AppendLine("            return DataBase.Connection.Delete(sentenca);");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz o insert da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        public override bool Insert()");
            builder.AppendLine("        {");
            builder.AppendLine("            string sentenca = $\"INSERT INTO {table.Table_Name} ({table.TodosCampos()})\" + ");
            builder.AppendLine("                       \" VALUES ( \" +");
            builder.AppendLine("                       $[CAMPOSINSERT]");
            builder.AppendLine("");
            builder.AppendLine("            if (DataBase.Connection.Insert(sentenca))");
            builder.AppendLine("            {");
            builder.AppendLine("                Empty = false;");
            builder.AppendLine("                return true;");
            builder.AppendLine("            }");
            builder.AppendLine("            return false;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que faz o update da classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns>True - sucesso; False - erro</returns>");
            builder.AppendLine("        public override bool Update()");
            builder.AppendLine("        {");
            builder.AppendLine("            string sentenca = $\"UPDATE {this.table.Table_Name} SET \" +");
            builder.AppendLine("                              $[CAMPOSUPDATE]");
            builder.AppendLine("                              $\" WHERE $[WHERECONSULTA]\";");
            builder.AppendLine("");
            builder.AppendLine("            return DataBase.Connection.Update(sentenca);");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("		#endregion Métodos");
            builder.AppendLine("    }");
            builder.AppendLine("}");
            builder.AppendLine("");

            return builder;
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
                Parametro = "$[TABELACLASSE]",
                Valor = this.Tabela.DAO.Nome.ToUpper()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMECLASSE]",
                Valor = this.RetornaNomeClasse()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[ATRIBUTOSPROPRIEDADES]",
                Valor = this.MontaAtributosPropriedades()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CAMPOSTABELA]",
                Valor = this.MontaCamposConstrutor()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CONSTRUTORPARAMETROS]",
                Valor = this.MontaParametrosConstrutor()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[VALIDACAOPARAMETROSCONSTRUTOR]",
                Valor = this.MontaIgualdadesConstrutor()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[WHERECONSULTA]",
                Valor = this.MontaWhereChavePrimaria()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CAMPOSLOAD]",
                Valor = this.MontaCamposLoad()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CAMPOSINSERT]",
                Valor = this.MontaCamposInsert()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CAMPOSUPDATE]",
                Valor = this.MontaCamposUpdate()
            });

            return retorno;
        }

        /// <summary>
        /// Método que cria o namespace
        /// </summary>
        /// <returns></returns>
        public override string CriarNameSpace()
        {
            return "Utils.DAO." + base.RetornaNomePropriedade(base.Tabela.DAO.Projeto.Nome);
        }

        /// <summary>
        /// Método que monta os atributos e as propriedades
        /// </summary>
        /// <returns></returns>
        private string MontaAtributosPropriedades()
        {
            StringBuilder builder = new AtributosPropriedades(this).MontaAtributosPropriedades();

            return builder.ToString();
        }

        /// <summary>
        /// Método que monsta os campos do construtor
        /// </summary>
        /// <returns></returns>
        private string MontaCamposConstrutor()
        {
            StringBuilder builder = new CamposConstrutorClasse(this).MontaCamposConstrutorPrincipal();

            return builder.ToString();
        }

        /// <summary>
        /// Método que monta os parâmetros de entrada do contrutor
        /// </summary>
        /// <returns></returns>
        private string MontaParametrosConstrutor()
        {
            string retorno = new Construtor(this).MontaParametrosConstrutor();

            return retorno;
        }

        /// <summary>
        /// Método que monta as igualdades dos parâmetros no construtor principal
        /// </summary>
        /// <returns></returns>
        private string MontaIgualdadesConstrutor()
        {
            string retorno = new Construtor(this).MontaIgualdadesConstrutor();

            return retorno;
        }

        /// <summary>
        /// Método que monta a consulta where da chave primaria
        /// </summary>
        /// <returns></returns>
        private string MontaWhereChavePrimaria()
        {
            string retorno = new WhereChavesPrimarias(this).MontaWhereChavePrimaria();

            return retorno;
        }

        /// <summary>
        /// Método que monta os campos load
        /// </summary>
        /// <returns></returns>
        private string MontaCamposLoad()
        {
            string retorno = new CamposLoad(this).MontaCampos().ToString();

            return retorno;
        }

        /// <summary>
        /// Método que monta os campos insert
        /// </summary>
        /// <returns></returns>
        private string MontaCamposInsert()
        {
            string retorno = new CamposInsert(this).MontaCamposInsert().ToString();

            return retorno;
        }

        /// <summary>
        /// Método que retorna os campos Update
        /// </summary>
        /// <returns></returns>
        private string MontaCamposUpdate()
        {
            string retorno = new CamposUpdate(this).MontaCamposUpdate().ToString();

            return retorno;
        }
    }
}
