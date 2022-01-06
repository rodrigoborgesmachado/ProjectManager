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
    /// [VERSOES] Tabela VERSOES
    /// </summary>
    public class MD_Versoes : MDN_Model
    {
        #region Atributos e Propriedades

        private string versao;
        /// <summary>
        /// [VERSAO] Versão do sistema
        /// <summary>
        public string Versao
        {
            get
            {
                return this.versao;
            }
            set
            {
                this.versao = value;
            }
        }

        private int codigoprojeto;
        /// <summary>
        /// [CODIGOPROJETO] Código do projeto
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

        private string caminhoorigem;
        /// <summary>
        /// [CAMINHOORIGEM] Caminho de origem do instalador
        /// <summary>
        public string Caminhoorigem
        {
            get
            {
                return this.caminhoorigem;
            }
            set
            {
                this.caminhoorigem = value;
            }
        }

        private string caminhodestino;
        /// <summary>
        /// [CAMINHODESTINO] Caminho de destino do instalador
        /// <summary>
        public string Caminhodestino
        {
            get
            {
                return this.caminhodestino;
            }
            set
            {
                this.caminhodestino = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Versoes()
            : base()
        {
            base.table = new MDN_Table("VERSOES");
            this.table.Fields_Table.Add(new MDN_Campo("VERSAO", true, Util.Enumerator.DataType.STRING, "0.0.0.0", true, false, 8, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOPROJETO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CAMINHOORIGEM", true, Util.Enumerator.DataType.STRING, "", false, false, 800, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CAMINHODESTINO", true, Util.Enumerator.DataType.STRING, "", false, false, 800, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="VERSAO">Versão do sistema
        /// <param name="CODIGOPROJETO">Código do projeto
        public MD_Versoes(string versao, int codigoprojeto)
            :this()
        {
            this.versao = versao;
            this.codigoprojeto = codigoprojeto;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Versoes.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE VERSAO = '" + Versao + "' AND CODIGOPROJETO = " + Codigoprojeto + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Caminhoorigem = reader["CAMINHOORIGEM"].ToString();
                this.Caminhodestino = reader["CAMINHODESTINO"].ToString();

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
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE VERSAO = '" + Versao + "' AND CODIGOPROJETO = " + Codigoprojeto + "";
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
                              " VALUES ( '" + this.versao + "', " + this.codigoprojeto + ",  '" + this.caminhoorigem + "',  '" + this.caminhodestino + "')";
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
                        "VERSAO = '" + Versao + "', CODIGOPROJETO = " + Codigoprojeto + ", CAMINHOORIGEM = '" + Caminhoorigem + "', CAMINHODESTINO = '" + Caminhodestino + "'" + 
                        " WHERE VERSAO = '" + Versao + "' AND CODIGOPROJETO = " + Codigoprojeto + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
