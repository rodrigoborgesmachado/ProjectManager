using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    /// <summary>
    /// [PROJETO] Classe referente à tabela projeto
    /// </summary>
    public class MD_Projeto : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo = 0;
        /// <summary>
        /// [CODIGO] Código do projeto
        /// </summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        private string nome = string.Empty;
        /// <summary>
        /// [NOME] Nome do projeto
        /// </summary>
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        private string descricao = string.Empty;
        /// <summary>
        /// [DESCRICAO] Descrição do projeto
        /// </summary>
        public string Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }

        private Util.Enumerator.Status status = Util.Enumerator.Status.ATIVO;
        /// <summary>
        /// [STATUS] Status do projeto (1 - Ativado; 2 - Desativado)
        /// </summary>
        public Util.Enumerator.Status StatusProjeto
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        private string git = "-";
        /// <summary>
        /// [GIT] Repositório Git onde o projeto está colocado.
        /// </summary>
        public string Git
        {
            get
            {
                return this.git;
            }
            set
            {
                this.git = value;
            }
        }

        #endregion Atributos e Propriedades

        #region Constutores

        /// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Projeto()
            : base()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto()", Util.Global.TipoLog.DETALHADO);

            base.table = new MDN_Table("PROJETO");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, null, true, false, 15, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOME", true, Util.Enumerator.DataType.STRING, null, false, false, 50, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DESCRICAO", false, Util.Enumerator.DataType.STRING, null, false, false, 400, 0));
            this.table.Fields_Table.Add(new MDN_Campo("STATUS", false, Util.Enumerator.DataType.CHAR, null, false, false, 1, 0));
            this.table.Fields_Table.Add(new MDN_Campo("GIT", true, Util.Enumerator.DataType.STRING, "-", false, false, 200, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

        /// <summary>
        /// Construtor secundário da classe
        /// </summary>
        /// <param name="codigo">Código da projeto</param>
        public MD_Projeto(int codigo)
            : this()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto()", Util.Global.TipoLog.DETALHADO);

            this.codigo = codigo;
            this.Load();
        }

        #endregion Constutores

        #region Métodos

        /// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);
            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.nome = reader["NOME"].ToString();
                this.Descricao = reader["DESCRICAO"].ToString();
                this.status = reader["STATUS"].ToString().Equals("1") ? Util.Enumerator.Status.ATIVO : Util.Enumerator.Status.DESATIVADO;
                this.Git = reader["GIT"].ToString();

                this.Empty = false;
                reader.Close();
            }
            else
            {
                this.Empty = true;
                reader.Close();
            }
        }

        /// <summary>
        /// Método que faz o delete da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Delete()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.Delete()", Util.Global.TipoLog.DETALHADO);

            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE CODIGO = " + this.codigo;
            return DataBase.Connection.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz o insert da classe
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.Insert()", Util.Global.TipoLog.DETALHADO);

            string sentenca = string.Empty;

            sentenca = "INSERT INTO " + table.Table_Name + " (" + table.TodosCampos() + ") " +
                              " VALUES (" + this.Codigo + ", '" + this.Nome  + "', '" + this.Descricao + "', '" + (this.StatusProjeto == Util.Enumerator.Status.ATIVO ? "1" : "0" ) +"', '" + this.Git +"')";
            if (DataBase.Connection.Insert(sentenca))
            {
                Empty = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método que faz o update da classe
        /// </summary>
        /// <returns></returns>
        public override bool Update()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.Update()", Util.Global.TipoLog.DETALHADO);

            string sentenca = string.Empty;

            sentenca = "UPDATE " + table.Table_Name + " SET " +
                        " NOME = '" + this.Nome + "', " +
                        " DESCRICAO = '" + this.Descricao + "', " +
                        " STATUS = '" + (this.StatusProjeto == Util.Enumerator.Status.ATIVO ? "1" : "0") + "', " +
                        " GIT = '" + this.Git + "' " +
                        "WHERE CODIGO = " + this.Codigo;

            return DataBase.Connection.Update(sentenca);
        }

        /// <summary>
        /// Método que retorna as tabelas do projeto
        /// </summary>
        /// <returns>Lista com todas as tabelas associadas com o projeto</returns>
        public List<MD_Tabela> GetTabelasProjeto()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.GetTabelasProjeto()", Util.Global.TipoLog.DETALHADO);

            List<MD_Tabela> tabelas = new List<MD_Tabela>();
            string sentenca = "SELECT CODIGO FROM " + new MD_Tabela().table.Table_Name + " WHERE PROJETO = " + this.codigo;

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            while (reader.Read())
            {
                MD_Tabela table = new MD_Tabela(int.Parse(reader["CODIGO"].ToString()), this.codigo);
                tabelas.Add(table);
                table = null;
            }

            return tabelas;
        }

        #endregion Métodos
    }
}
