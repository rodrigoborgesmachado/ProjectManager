using DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Regras
{
    /// <summary>
    /// Classe responsável por criar as classes das tabelas com comunicação com o banco de dados
    /// </summary>
    public static class ClassCreater
    {

        /// <summary>
        /// Método que monta o data table 
        /// </summary>
        /// <param name="tabela">Tabela para montar a tabela do núcleo</param>
        /// <returns>Objeto da tabela do núcleo</returns>
        public static MDN_Table MontaTable(Model.MD_Tabela tabela)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaTable()", Util.Global.TipoLog.DETALHADO);

            MDN_Table table = new MDN_Table(tabela.DAO.Nome);

            foreach(Model.MD_Campos campo in tabela.CamposDaTabela())
            {
                table.Fields_Table.Add(new MDN_Campo(campo.DAO.Nome, campo.DAO.NotNull, campo.TipoNucleo(), campo.DAO.Default, campo.DAO.PrimaryKey, campo.DAO.Unique, campo.DAO.Tamanho, int.Parse(campo.DAO.Precisao.ToString())));
            }

            return table;
        }

        /// <summary>
        /// Método que gera a classe da tabela passada em referência
        /// </summary>
        /// <param name="tabela">tabela a ser criada a classe</param>
        /// <param name="mensagemErro">string de referência para descrição de erros</param>
        /// <returns>True - Criado sem erros; False - Erro ao criar</returns>
        public static bool Create(MDN_Table tabela, ref string mensagemErro)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.Create()", Util.Global.TipoLog.DETALHADO);

            try
            {
                MontaDAO(tabela, ref mensagemErro);

                MontaModel(tabela, ref mensagemErro);
            }
            catch(Exception e)
            {
                CL_Files.WriteOnTheLog("Erro: " + e.Message, Global.TipoLog.SIMPLES);
                mensagemErro = e.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que monta as classes do Model
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="mensagemErro"></param>
        private static void MontaModel(MDN_Table tabela, ref string mensagemErro)
        {
            StringBuilder classe = new StringBuilder();

            MontarTextoInicialClasseModel(ref classe);

            StringBuilder atributos = new StringBuilder();
            MontarAtibutosModel(ref atributos, tabela);

            StringBuilder construtores = new StringBuilder();
            MontarConstrutoresModel(ref construtores, tabela);

            MontaArquivoModel(tabela, ref classe, ref atributos, ref construtores);
        }

        /// <summary>
        /// Método que monta as classes DAO
        /// </summary>
        private static void MontaDAO(MDN_Table tabela, ref string mensagemErro)
        {
            StringBuilder classe = new StringBuilder();

            MontarTextoInicialClasseDAO(ref classe);

            StringBuilder atributos = new StringBuilder();
            MontarAtibutosDAO(ref atributos, tabela);

            StringBuilder construtores = new StringBuilder();
            MontarConstrutoresDAO(ref construtores, tabela);

            StringBuilder metodos = new StringBuilder();
            MontarMetodosDAO(ref metodos, tabela);

            MontaArquivoDAO(tabela, ref classe, ref atributos, ref construtores, ref metodos);
        }

        /// <summary>
        /// Método que monta o arquivo com a nova configuração
        /// </summary>
        /// <param name="atributos">Atributos da classe</param>
        /// <param name="construtores">Construtores da classe</param>
        /// <param name="metodos">Métodos da classe</param>
        private static void MontaArquivoModel(MDN_Table table, ref StringBuilder classe, ref StringBuilder atributos, ref StringBuilder construtores)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaArquivo()", Util.Global.TipoLog.DETALHADO);

            if (!Directory.Exists(Global.app_classes_directory + "Model\\"))
            {
                Directory.CreateDirectory(Global.app_classes_directory + "Model\\");
            }

            string diretorioArquivo = Global.app_classes_directory + "Model\\" + NomeClasse(table) + ".cs";
            string _classe = classe.ToString();

            _classe = _classe.Replace("#NOMETABELA", table.Table_Name);
            _classe = _classe.Replace("#NOMECLASSE", NomeClasse(table));
            _classe = _classe.Replace("#ATRIBUTO", atributos.ToString());
            _classe = _classe.Replace("#CONSTRUTORES", construtores.ToString());

            if (File.Exists(diretorioArquivo))
            {
                File.Delete(diretorioArquivo);
            }

            File.AppendAllText(diretorioArquivo, _classe);
        }

        /// <summary>
        /// Método que monta o arquivo com a nova configuração
        /// </summary>
        /// <param name="atributos">Atributos da classe</param>
        /// <param name="construtores">Construtores da classe</param>
        /// <param name="metodos">Métodos da classe</param>
        private static void MontaArquivoDAO(MDN_Table table, ref StringBuilder classe, ref StringBuilder atributos, ref StringBuilder construtores, ref StringBuilder metodos)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaArquivo()", Util.Global.TipoLog.DETALHADO);

            if(!Directory.Exists(Global.app_classes_directory + "DAO\\"))
            {
                Directory.CreateDirectory(Global.app_classes_directory + "DAO\\");
            }

            string diretorioArquivo = Global.app_classes_directory + "DAO\\" + NomeClasse(table) + ".cs";
            string _classe = classe.ToString();

            _classe = _classe.Replace("@NOMETABELA", table.Table_Name);
            _classe = _classe.Replace("@NOMECLASSE", NomeClasse(table));
            _classe = _classe.Replace("@ATRIBUTOS", atributos.ToString());
            _classe = _classe.Replace("@CONSTRUTORES", construtores.ToString());
            _classe = _classe.Replace("@METODOS", metodos.ToString());

            File.AppendAllText(diretorioArquivo, _classe);
        }

        /// <summary>
        /// Método que apaga os arquivos antigos
        /// </summary>
        private static void ApagarArquivos()
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.ApagarArquivos()", Util.Global.TipoLog.DETALHADO);

            foreach (string file in Directory.GetFiles(Global.app_classes_directory))
            {
                File.Delete(file);
            }
        }

        /// <summary>
        /// Método que monta o texto inicial da classe do model
        /// </summary>
        /// <param name="builder"></param>
        private static void MontarTextoInicialClasseModel(ref StringBuilder builder)
        {
            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Linq;");
            builder.AppendLine("using System.Text;");
            builder.AppendLine("using System.Threading.Tasks;");
            builder.AppendLine("");
            builder.AppendLine("namespace Model");
            builder.AppendLine("{");
            builder.AppendLine("    /// <summary>");
            builder.AppendLine("    /// [#NOMETABELA] Tabela da classe");
            builder.AppendLine("    /// </summary>");
            builder.AppendLine("    public class #NOMECLASSE ");
            builder.AppendLine("    {");
            builder.AppendLine("        #region Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// DAO que representa a classe");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        #ATRIBUTO");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("        #region Construtores");
            builder.AppendLine("");
            builder.AppendLine("        #CONSTRUTORES");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Construtores");
            builder.AppendLine("");
            builder.AppendLine("        #region Métodos");
            builder.AppendLine("");
            builder.AppendLine("        #endregion Métodos");
            builder.AppendLine("");
            builder.AppendLine("    }");
            builder.AppendLine("}");
        }


        /// <summary>
        /// Método que monta o texto inicial da classe
        /// </summary>
        /// <param name="builder"></param>
        private static void MontarTextoInicialClasseDAO(ref StringBuilder builder)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarTextoInicialClasse()", Util.Global.TipoLog.DETALHADO);

            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Data.SQLite;");
            builder.AppendLine("using System.Linq;");
            builder.AppendLine("using System.Text;");
            builder.AppendLine("using System.Threading.Tasks;");
            builder.AppendLine("using System.Data.Common;");
            builder.AppendLine("");
            builder.AppendLine("namespace DAO");
            builder.AppendLine("{");
            builder.AppendLine("");
            builder.AppendLine("    /// <summary>");
            builder.AppendLine("    /// [@NOMETABELA] Tabela @NOMETABELA");
            builder.AppendLine("    /// </summary>");
            builder.AppendLine("    public class @NOMECLASSE : MDN_Model");
            builder.AppendLine("    {");
            builder.AppendLine("        #region Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("@ATRIBUTOS");
            builder.AppendLine("		#endregion Atributos e Propriedades");
            builder.AppendLine("");
            builder.AppendLine("        #region Construtores");
            builder.AppendLine("");
            builder.AppendLine("@CONSTRUTORES");
            builder.AppendLine("		#endregion Construtores");
            builder.AppendLine("");
            builder.AppendLine("        #region Métodos");
            builder.AppendLine("@METODOS");
            builder.AppendLine("		#endregion Métodos");
            builder.AppendLine("    }");
            builder.AppendLine("}");
        }

        /// <summary>
        /// Método que monta o nome da classe
        /// </summary>
        /// <param name="table">Tabela para montar o nome da classe</param>
        /// <returns>Nome da classe</returns>
        private static string NomeClasse(MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.NomeClasse()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            retorno = "MD_" + table.Table_Name[0].ToString().ToUpper() + table.Table_Name.Substring(1).ToLower();
            return retorno;
        }

        #region Campos

        /// <summary>
        /// Método que monta o atributo da classe
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="table"></param>
        private static void MontarAtibutosModel(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarAtibutosModel()", Util.Global.TipoLog.DETALHADO);

            builder.AppendLine("public DAO." + NomeClasse(table) + " DAO = null;");
        }

        /// <summary>
        /// Método que preenche os atributos da classe
        /// </summary>
        /// <param name="builder">string com o texto</param>
        /// <param name="table">Tabela para pegar os parâmetros</param>
        private static void MontarAtibutosDAO(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarAtibutos()", Util.Global.TipoLog.DETALHADO);

            foreach (MDN_Campo campo in table.Fields_Table)
            {
                AdicionaComentario(ref builder, campo, table);
            }
        }

        /// <summary>
        /// Método que preenche o parâmetro
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="campo"></param>
        private static void AdicionaComentario(ref StringBuilder builder, MDN_Campo campo, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.AdicionaComentario()", Util.Global.TipoLog.DETALHADO);

            builder.Append("        private " + TipoDoCampo(campo) + " " + campo.Name_Field.ToLower() + ";" + Environment.NewLine);
            builder.Append("        /// <summary>" + Environment.NewLine);
            builder.Append("        /// [" + campo.Name_Field + "] " + Model.MD_Campos.BuscaComentario(table.Table_Name, campo.Name_Field) + Environment.NewLine);
            builder.Append("        /// <summary>" + Environment.NewLine);
            builder.Append("        public " + TipoDoCampo(campo) + " " + NomeAtributoCampo(campo) + Environment.NewLine);
            builder.Append("        {" + Environment.NewLine);
            builder.Append("            get" + Environment.NewLine);
            builder.Append("            {" + Environment.NewLine);
            builder.Append("                return this." + campo.Name_Field.ToLower() + ";" + Environment.NewLine);
            builder.Append("            }" + Environment.NewLine);
            builder.Append("            set" + Environment.NewLine);
            builder.Append("            {" + Environment.NewLine);
            builder.Append("                this." + campo.Name_Field.ToLower() + " = value;" + Environment.NewLine);
            builder.Append("            }" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine + Environment.NewLine);

        }

        /// <summary>
        /// Método que retorna a string do tipo de campo
        /// </summary>
        /// <param name="campo">Campo para análise</param>
        /// <returns>Tipo relativo do campo</returns>
        private static string TipoDoCampo(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.TipoDoCampo()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    retorno = "string";
                    break;
                case Enumerator.DataType.STRING:
                    retorno = "string";
                    break;
                case Enumerator.DataType.INT:
                    retorno = "int";
                    break;
                case Enumerator.DataType.DECIMAL:
                    retorno = "decimal";
                    break;
                case Enumerator.DataType.DATE:
                    retorno = "DateTime";
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que retorna a string do tipo de campo conforme enumerador
        /// </summary>
        /// <param name="campo">Campo para análise</param>
        /// <returns>Tipo relativo do campo</returns>
        private static string TipoDoCampoEnumerator(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.TipoDoCampoEnumerator()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    retorno = "CHAR";
                    break;
                case Enumerator.DataType.STRING:
                    retorno = "STRING";
                    break;
                case Enumerator.DataType.INT:
                    retorno = "INT";
                    break;
                case Enumerator.DataType.DECIMAL:
                    retorno = "DECIMAL";
                    break;
                case Enumerator.DataType.DATE:
                    retorno = "DATE";
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que retorna a string do tipo de campo conforme enumerador
        /// </summary>
        /// <param name="campo">Campo para análise</param>
        /// <returns>Tipo relativo do campo</returns>
        private static string ValorDefault(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.ValorDefault()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    if (campo.ValueDefault == null)
                        break;
                    retorno = "\"" + campo.ValueDefault.ToString() + "\"";
                    break;
                case Enumerator.DataType.STRING:
                    if (campo.ValueDefault == null)
                        break;
                    retorno = "\"" + campo.ValueDefault.ToString() + "\"";
                    break;
                case Enumerator.DataType.INT:
                    if (campo.ValueDefault == null)
                        retorno = 0.ToString();
                        break;
                    if (string.IsNullOrEmpty(campo.ValueDefault.ToString()))
                        retorno= 0.ToString();
                        break;
                    retorno = int.Parse(campo.ValueDefault.ToString()).ToString();
                    break;
                case Enumerator.DataType.DECIMAL:
                    if (campo.ValueDefault == null)
                        break;
                    if (string.IsNullOrEmpty(campo.ValueDefault.ToString()))
                        break;
                    retorno = decimal.Parse(campo.ValueDefault.ToString()).ToString();
                    break;
                case Enumerator.DataType.DATE:
                    if (campo.ValueDefault == null)
                        break;
                    retorno = "\"" + campo.ValueDefault.ToString() + "\"";
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que retorna o nome do atributo formatado
        /// </summary>
        /// <param name="campo">Campo para capturar o atributo</param>
        /// <returns>String com o nome configurado do atributo</returns>
        private static string NomeAtributoCampo(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.NomeAtributoCampo()", Util.Global.TipoLog.DETALHADO);

            return campo.Name_Field[0].ToString().ToUpper() + campo.Name_Field.Substring(1).ToLower();
        }

        #endregion Campos

        #region Construtores

        /// <summary>
        /// Método que preenche o construtor principal do model
        /// </summary>
        /// <param name="builder">string com o conteúdo</param>
        /// <param name="table">tabela para analisar</param>
        private static void MontarConstrutoresModel(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarConstrutoresModel()", Util.Global.TipoLog.DETALHADO);

            builder.AppendLine("public " + NomeClasse(table) + "(" + CamposChave(table) + ")");
            builder.AppendLine("        {");
            builder.AppendLine("            Util.CL_Files.WriteOnTheLog(\"" + NomeClasse(table) + "()\", Util.Global.TipoLog.DETALHADO);");
            builder.AppendLine("            this.DAO = new DAO." + NomeClasse(table) + "(" + CamposChave(table).Replace("int", "").Replace("char", "").Replace("string", "").Replace("decimal", "").Replace("DateTime", "") + ");");
            builder.AppendLine("        }");

        }

        /// <summary>
        /// Método que preenche os construtores da classe
        /// </summary>
        /// <param name="builder">string com o conteúdo</param>
        /// <param name="table">tabela para analisar</param>
        private static void MontarConstrutoresDAO(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarConstrutores()", Util.Global.TipoLog.DETALHADO);

            builder.Append("		/// <summary>" + Environment.NewLine);
            builder.Append("        /// Construtor Principal da classe" + Environment.NewLine);
            builder.Append("        /// </summary>" + Environment.NewLine);
            builder.Append("        public " + NomeClasse(table) + "()" + Environment.NewLine);
            builder.Append("            : base()" + Environment.NewLine);
            builder.Append("        {" +  Environment.NewLine);
            builder.Append("            base.table = new MDN_Table(\"" + table.Table_Name + "\");" + Environment.NewLine);

            foreach(MDN_Campo campo in table.Fields_Table)
            {
                builder.Append("            this.table.Fields_Table.Add(new MDN_Campo(\"" + campo.Name_Field + "\"");
                builder.Append(", " + (campo.NotNull ? "true" : "false") + ", Util.Enumerator.DataType." + TipoDoCampoEnumerator(campo));
                builder.Append(", " + (campo.ValueDefault == null ? "null" : ValorDefault(campo)) + ", " + (campo.PrimaryKey ? "true" : "false"));
                builder.Append(", " + (campo.Unique ? "true" : "false") + ", " + campo.Size + ", " + campo.Precision + "));" + Environment.NewLine);

            }

            builder.Append(Environment.NewLine);
            builder.Append("            if (!base.table.ExistsTable())" + Environment.NewLine);
            builder.Append("                base.table.CreateTable(false);" + Environment.NewLine);
            builder.Append(Environment.NewLine);
            builder.Append("            base.table.VerificaColunas();" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine);

            builder.Append(Environment.NewLine);
            builder.Append("		/// <summary>" + Environment.NewLine);
            builder.Append("        /// Construtor Secundário da classe" + Environment.NewLine);
            builder.Append("        /// </summary>" + Environment.NewLine);
            PreencheComentarioPKsContrutor(ref builder, table);
            builder.Append("        public " + NomeClasse(table) + "(" + CamposChave(table) + ")" + Environment.NewLine);
            builder.Append("            :this()" + Environment.NewLine);
            builder.Append("        {" + Environment.NewLine);
            PreenchePKsContrutor(ref builder, table);
            builder.Append("            this.Load();" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine);
            builder.Append(Environment.NewLine);
        }

        /// <summary>
        /// Método que preenche o comentário das chaves da tabela no construtor
        /// </summary>
        /// <param name="builder">string de referência</param>
        /// <param name="table">objeto de análise</param>
        private static void PreencheComentarioPKsContrutor(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.PreencheComentarioPKsContrutor()", Util.Global.TipoLog.DETALHADO);

            foreach (MDN_Campo campo in table.Fields_Table)
            {
                if (!campo.PrimaryKey)
                    continue;

                builder.Append("        /// <param name=\"" + campo.Name_Field + "\">" + Model.MD_Campos.BuscaComentario(table.Table_Name, campo.Name_Field) + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método que preenche as chaves da classe no construtor
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="table"></param>
        private static void PreenchePKsContrutor(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.PreenchePKsContrutor()", Util.Global.TipoLog.DETALHADO);

            foreach (MDN_Campo campo in table.Fields_Table)
            {
                if (!campo.PrimaryKey)
                    continue;

                builder.Append("            this." + campo.Name_Field.ToLower() + " = " + campo.Name_Field.ToLower() + ";" + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método que monta a linha com os campos chave
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private static string CamposChave(MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.CamposChave()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;
            bool first = true;

            foreach(MDN_Campo campo in table.Fields_Table)
            {
                if (!campo.PrimaryKey)
                    continue;

                if (!first)
                {
                    retorno += ", ";
                }

                retorno += TipoDoCampo(campo) + " " + campo.Name_Field.ToLower();
                first = false;
            }

            return retorno;
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que monta os métodos
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="table"></param>
        private static void MontarMetodosDAO(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarMetodos()", Util.Global.TipoLog.DETALHADO);

            builder.AppendLine("");
            MontarLoad(ref builder, table);

            builder.AppendLine("");
            MontarDelete(ref builder, table);

            builder.AppendLine("");
            MontaInsert(ref builder, table);

            builder.AppendLine("");
            MontaUpdate(ref builder, table);
        }

        /// <summary>
        /// Método que preenche o método DELETE
        /// </summary>
        /// <param name="builder">string para construção do método</param>
        /// <param name="table">Tabela para criar o delete</param>
        private static void MontaInsert(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaInsert()", Util.Global.TipoLog.DETALHADO);

            builder.Append("        /// <summary>" + Environment.NewLine);
            builder.Append("        /// Método que faz o insert da classe" + Environment.NewLine);
            builder.Append("        /// </summary>" + Environment.NewLine);
            builder.Append("        /// <returns></returns>" + Environment.NewLine);
            builder.Append("        public override bool Insert()" + Environment.NewLine);
            builder.Append("        {" + Environment.NewLine);
            builder.Append("            string sentenca = string.Empty;" + Environment.NewLine);
            builder.Append("" + Environment.NewLine);
            builder.Append("            sentenca = \"INSERT INTO \" + table.Table_Name + \" (\" + table.TodosCampos() + \")\" + " + Environment.NewLine);
            builder.Append("                              \" VALUES (" + ListaAtributos(table) + ")\";" + Environment.NewLine);
            builder.Append("            if (DataBase.Connection.Insert(sentenca))" + Environment.NewLine);
            builder.Append("            {" + Environment.NewLine);
            builder.Append("                Empty = false;" + Environment.NewLine);
            builder.Append("                return true;" + Environment.NewLine);
            builder.Append("            }" + Environment.NewLine);
            builder.Append("            return false;" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine);
        }

        /// <summary>
        /// Método que monta a lista dos atributos para o insert
        /// </summary>
        /// <param name="table">tabela para montar a lista</param>
        /// <returns>string com a lista dos atributos</returns>
        private static string ListaAtributos(MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.ListaAtributos()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;
            bool first = true;

            foreach(MDN_Campo campo in table.Fields_Table)
            {
                if (!first)
                    retorno += ", ";
                first = false;

                retorno += RetornaAtributoInsert(campo);
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a string para insert
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        private static string RetornaAtributoInsert(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.RetornaAtributoInsert()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    retorno = " '\" + this." + campo.Name_Field.ToLower() + " + \"'";
                    break;
                case Enumerator.DataType.STRING:
                    retorno = " '\" + this." + campo.Name_Field.ToLower() + " + \"'";
                    break;
                case Enumerator.DataType.INT:
                    retorno = "\" + this." + campo.Name_Field.ToLower() + " + \"";
                    break;
                case Enumerator.DataType.DECIMAL:
                    retorno = "\" + this." + campo.Name_Field.ToLower() + ".ToString().Replace(',', '.') + \"";
                    break;
                case Enumerator.DataType.DATE:
                    retorno = "\" + DataBase.Connection.Date_to_Int(this." + campo.Name_Field.ToLower() + ") + \"";
                    
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que preenche o método delete 
        /// </summary>
        /// <param name="builder">construtor da string de comando</param>
        /// <param name="table">tabela para montar o método</param>
        private static void MontarDelete(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarDelete()", Util.Global.TipoLog.DETALHADO);

            builder.Append("        /// <summary>" + Environment.NewLine);
            builder.Append("        /// Método que faz o delete da classe" + Environment.NewLine);
            builder.Append("        /// </summary>" + Environment.NewLine);
            builder.Append("        /// <returns>True - sucesso; False - erro</returns>" + Environment.NewLine);
            builder.Append("        public override bool Delete()" + Environment.NewLine);
            builder.Append("        {" + Environment.NewLine);
            builder.Append("            string sentenca = \"DELETE FROM \" + this.table.Table_Name + \" WHERE " + MontaClasulaWhereLoad(table) + "\";"+ Environment.NewLine);
            builder.Append("            return DataBase.Connection.Delete(sentenca);" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine);
        }

        /// <summary>
        /// Método que monta o método Load()
        /// </summary>
        /// <param name="builder">builder para construir a string</param>
        /// <param name="table">table para verificação</param>
        private static void MontarLoad(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarLoad()", Util.Global.TipoLog.DETALHADO);

            builder.Append("		/// <summary>" + Environment.NewLine);
            builder.Append("        /// Método que faz o load da classe" + Environment.NewLine);
            builder.Append("        /// </summary>" + Environment.NewLine);
            builder.Append("        public override void Load()" + Environment.NewLine);
            builder.Append("        {" + Environment.NewLine);
            builder.Append("            Util.CL_Files.WriteOnTheLog(\"" + NomeClasse(table) + ".Load()\", Util.Global.TipoLog.DETALHADO);" + Environment.NewLine);
            builder.Append("" + Environment.NewLine);
            builder.Append("            string sentenca = base.table.CreateCommandSQLTable() + \" WHERE " + MontaClasulaWhereLoad(table)  + "\";"+ Environment.NewLine);
            builder.Append("            DbDataReader reader = DataBase.Connection.Select(sentenca);" + Environment.NewLine);
            builder.Append("" + Environment.NewLine);
            builder.Append("            if (reader == null)" + Environment.NewLine);
            builder.Append("            {" + Environment.NewLine);
            builder.Append("                this.Empty = true;" + Environment.NewLine);
            builder.Append("            }" + Environment.NewLine);
            builder.Append("            else if (reader.Read())" + Environment.NewLine);
            builder.Append("            {" + Environment.NewLine);
            builder.Append("" + MontarAtibuidoresLoad(table) + Environment.NewLine);
            builder.Append("                this.Empty = false;" + Environment.NewLine);
            builder.Append("                reader.Close();" + Environment.NewLine);
            builder.Append("            }" + Environment.NewLine);
            builder.Append("            else" + Environment.NewLine);
            builder.Append("            {" + Environment.NewLine);
            builder.Append("                this.Empty = true;" + Environment.NewLine);
            builder.Append("                reader.Close();" + Environment.NewLine);
            builder.Append("            }" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine);
        }

        /// <summary>
        /// Método que monta a cláusula where do método load
        /// </summary>
        /// <param name="table"></param>
        /// <returns>string com a cláusula de busca do load montada</returns>
        private static string MontaClasulaWhereLoad(MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaClasulaWhereLoad()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;
            bool first = true;

            foreach(MDN_Campo campo in table.Fields_Table)
            {
                if (!campo.PrimaryKey)
                    continue;

                if (!first)
                    retorno += " AND ";

                retorno += campo.Name_Field + " = " + SentencaCampo(campo);

                first = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria a sentenca do campo para busca no banco
        /// </summary>
        /// <param name="campo">campo a ser montado a sentenca</param>
        /// <returns>string com a sentenca do campo</returns>
        private static string SentencaCampo(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.SentencaCampo()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    retorno = "'\" + " + NomeAtributoCampo(campo) + " + \"'";
                    break;
                case Enumerator.DataType.STRING:
                    retorno = "'\" + " + NomeAtributoCampo(campo) + " + \"'";
                    break;
                case Enumerator.DataType.INT:
                    retorno = "\" + " + NomeAtributoCampo(campo) + " + \"";
                    break;
                case Enumerator.DataType.DECIMAL:
                    retorno = "\" + " + NomeAtributoCampo(campo) + " + \"";
                    break;
                case Enumerator.DataType.DATE:
                    retorno = "'\" + " + NomeAtributoCampo(campo) + " + \"'";
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria as atibuições do método load da classe
        /// </summary>
        /// <param name="table">Tabela para captura dos campos</param>
        /// <returns></returns>
        private static string MontarAtibuidoresLoad(MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontarAtibuidoresLoad()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            foreach(MDN_Campo campo in table.Fields_Table)
            {
                if (campo.PrimaryKey)
                    continue;

                retorno += "                " + TipoAtribuicao(campo) + Environment.NewLine;
            }

            return retorno;
        }

        /// <summary>
        /// Método que retorna o tipo de atribuição do campo
        /// </summary>
        /// <param name="campo">Campo para se pegar as informações</param>
        /// <returns>string com a atribuição</returns>
        private static string TipoAtribuicao(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.TipoAtribuicao()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    retorno += "this." + NomeAtributoCampo(campo) + " = " + "reader[\"" + campo.Name_Field + "\"].ToString();";
                    break;
                case Enumerator.DataType.STRING:
                    retorno += "this." + NomeAtributoCampo(campo) + " = " + "reader[\"" + campo.Name_Field + "\"].ToString();";
                    break;
                case Enumerator.DataType.INT:
                    retorno += "this." + NomeAtributoCampo(campo) + " = " + "int.Parse(reader[\"" + campo.Name_Field + "\"].ToString());";
                    break;
                case Enumerator.DataType.DECIMAL:
                    retorno += "this." + NomeAtributoCampo(campo) + " = " + "decimal.Parse(reader[\"" + campo.Name_Field + "\"].ToString());";
                    break;
                case Enumerator.DataType.DATE:
                    retorno += "this." + NomeAtributoCampo(campo) + " = " + "DataBase.Connection.Int_to_Date(int.Parse(reader[\"" + campo.Name_Field + "\"].ToString()));";
                    
                    break;
            }

            return retorno;
        }

        #endregion Métodos

        #region Update

        /// <summary>
        /// Método que monta o método update
        /// </summary>
        /// <param name="builder">builder para construção da string</param>
        /// <param name="table">table para montar o update</param>
        private static void MontaUpdate(ref StringBuilder builder, MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaUpdate()", Util.Global.TipoLog.DETALHADO);

            builder.Append("        /// <summary>" + Environment.NewLine);
            builder.Append("        /// Método que faz o update da classe" + Environment.NewLine);
            builder.Append("        /// </summary>" + Environment.NewLine);
            builder.Append("        /// <returns>True - sucesso; False - erro</returns>" + Environment.NewLine);
            builder.Append("        public override bool Update()" + Environment.NewLine);
            builder.Append("        {" + Environment.NewLine);
            builder.Append("            string sentenca = string.Empty;" + Environment.NewLine);
            builder.Append("" + Environment.NewLine);
            builder.Append("            sentenca = \"UPDATE \" + table.Table_Name + \" SET \" + " + Environment.NewLine);
            builder.Append("                        " + CamposUpdate(table) + Environment.NewLine);
            builder.Append("                        \" WHERE " + MontaClasulaWhereLoad(table) + "\";" +  Environment.NewLine);
            builder.Append("" + Environment.NewLine);
            builder.Append("            return DataBase.Connection.Update(sentenca);" + Environment.NewLine);
            builder.Append("        }" + Environment.NewLine);
        }

        /// <summary>
        /// Método que monta a string de atualização dos campos
        /// </summary>
        /// <param name="table"> tabela para montar os campos</param>
        /// <returns>string com o comando</returns>
        private static string CamposUpdate(MDN_Table table)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.CamposUpdate()", Util.Global.TipoLog.DETALHADO);

            string retorno = string.Empty;
            bool first = true;

            foreach(MDN_Campo campo in table.Fields_Table)
            {
                if (!first)
                    retorno += ", ";
                else
                    retorno += "\"";

                first = false;
                retorno += MontaCampoUpdate(campo);
            }
            retorno += "\" + ";

            return retorno;
        }

        /// <summary>
        /// Método que monta o campo update
        /// </summary>
        /// <returns>comando com os campos</returns>
        private static string MontaCampoUpdate(MDN_Campo campo)
        {
            Util.CL_Files.WriteOnTheLog("ClassCreater.MontaCampoUpdate()", Util.Global.TipoLog.DETALHADO);

            string retorno = campo.Name_Field;

            switch (campo.Type)
            {
                case Enumerator.DataType.CHAR:
                    retorno = campo.Name_Field + " = '\" + " + NomeAtributoCampo(campo) + " + \"'";
                    break;
                case Enumerator.DataType.STRING:
                    retorno = campo.Name_Field + " = '\" + " + NomeAtributoCampo(campo) + " + \"'";
                    break;
                case Enumerator.DataType.INT:
                    retorno = campo.Name_Field + " = \" + " + NomeAtributoCampo(campo) + " + \"";
                    break;
                case Enumerator.DataType.DECIMAL:
                    retorno = campo.Name_Field + " = \" + " + NomeAtributoCampo(campo) + ".ToString().Replace(',', '.') + \"";
                    break;
                case Enumerator.DataType.DATE:
                    retorno = campo.Name_Field + " = '\" + " + NomeAtributoCampo(campo) + " + \"'";
                    break;
            }

            return retorno;
        }

        #endregion Update

    }
}
