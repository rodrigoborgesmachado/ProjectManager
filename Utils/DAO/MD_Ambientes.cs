using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [AMBIENTES] Tabela AMBIENTES
    /// </summary>
    public class MD_Ambientes : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo;
        /// <summary>
        /// [CODIGO] 
        /// <summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        private string nome;
        /// <summary>
        /// [NOME] 
        /// <summary>
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

        private string urldisponivel;
        /// <summary>
        /// [URLDISPONIVEL] 
        /// <summary>
        public string Urldisponivel
        {
            get
            {
                return this.urldisponivel;
            }
            set
            {
                this.urldisponivel = value;
            }
        }

        private string usuarioacesso;
        /// <summary>
        /// [USUARIOACESSO] 
        /// <summary>
        public string Usuarioacesso
        {
            get
            {
                return this.usuarioacesso;
            }
            set
            {
                this.usuarioacesso = value;
            }
        }

        private string senhaacesso;
        /// <summary>
        /// [SENHAACESSO] 
        /// <summary>
        public string Senhaacesso
        {
            get
            {
                return this.senhaacesso;
            }
            set
            {
                this.senhaacesso = value;
            }
        }

        private string urlservidorpublicacao;
        /// <summary>
        /// [URLSERVIDORPUBLICACAO] 
        /// <summary>
        public string Urlservidorpublicacao
        {
            get
            {
                return this.urlservidorpublicacao;
            }
            set
            {
                this.urlservidorpublicacao = value;
            }
        }

        private string caminhoservidor;
        /// <summary>
        /// [CAMINHOSERVIDOR] 
        /// <summary>
        public string Caminhoservidor
        {
            get
            {
                return this.caminhoservidor;
            }
            set
            {
                this.caminhoservidor = value;
            }
        }

        private int codigoprojeto;
        /// <summary>
        /// [CODIGOPROJETO] 
        /// <summary>
        public int Codigoprojeto
        {
            get
            {
                return this.codigoprojeto;
            }
            set
            {
                this.codigoprojeto = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Ambientes()
            : base()
        {
            base.table = new MDN_Table("AMBIENTES");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOME", false, Util.Enumerator.DataType.STRING, "", false, false, 500, 0));
            this.table.Fields_Table.Add(new MDN_Campo("URLDISPONIVEL", false, Util.Enumerator.DataType.STRING, "", false, false, 300, 0));
            this.table.Fields_Table.Add(new MDN_Campo("USUARIOACESSO", false, Util.Enumerator.DataType.STRING, "", false, false, 200, 0));
            this.table.Fields_Table.Add(new MDN_Campo("SENHAACESSO", false, Util.Enumerator.DataType.STRING, "", false, false, 200, 0));
            this.table.Fields_Table.Add(new MDN_Campo("URLSERVIDORPUBLICACAO", false, Util.Enumerator.DataType.STRING, "", false, false, 300, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CAMINHOSERVIDOR", false, Util.Enumerator.DataType.STRING, "", false, false, 300, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOPROJETO", false, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_Ambientes(int codigo)
            :this()
        {
            this.codigo = codigo;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Ambientes.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Nome = reader["NOME"].ToString();
                this.Urldisponivel = reader["URLDISPONIVEL"].ToString();
                this.Usuarioacesso = reader["USUARIOACESSO"].ToString();
                this.Senhaacesso = reader["SENHAACESSO"].ToString();
                this.Urlservidorpublicacao = reader["URLSERVIDORPUBLICACAO"].ToString();
                this.Caminhoservidor = reader["CAMINHOSERVIDOR"].ToString();
                this.Codigoprojeto = int.Parse(reader["CODIGOPROJETO"].ToString());

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
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE CODIGO = " + Codigo + "";
            return DataBase.Connection.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz o insert da classe
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            string sentenca = string.Empty;

            sentenca = "INSERT INTO " + table.Table_Name + " (" + table.TodosCampos() + ")" + 
                              " VALUES (" + this.codigo + ",  '" + this.nome + "',  '" + this.urldisponivel + "',  '" + this.usuarioacesso + "',  '" + this.senhaacesso + "',  '" + this.urlservidorpublicacao + "',  '" + this.caminhoservidor + "', " + this.codigoprojeto + ")";
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
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Update()
        {
            string sentenca = string.Empty;

            sentenca = "UPDATE " + table.Table_Name + " SET " + 
                        "CODIGO = " + Codigo + ", NOME = '" + Nome + "', URLDISPONIVEL = '" + Urldisponivel + "', USUARIOACESSO = '" + Usuarioacesso + "', SENHAACESSO = '" + Senhaacesso + "', URLSERVIDORPUBLICACAO = '" + Urlservidorpublicacao + "', CAMINHOSERVIDOR = '" + Caminhoservidor + "', CODIGOPROJETO = " + Codigoprojeto + "" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
