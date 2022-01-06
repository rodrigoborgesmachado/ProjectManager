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
    /// [MODULOS] Tabela MODULOS
    /// </summary>
    public class MD_Modulos : MDN_Model
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

        private string nomemodulo;
        /// <summary>
        /// [NOMEMODULO] 
        /// <summary>
        public string NomeModulo
        {
            get
            {
                return this.nomemodulo;
            }
            set
            {
                this.nomemodulo = value;
            }
        }

        private string descricao;
        /// <summary>
        /// [DESCRICAO] 
        /// <summary>
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

        private string sequenciaabertura;
        /// <summary>
        /// [SEQUENCIAABERTURA] 
        /// <summary>
        public string SequenciaAbertura
        {
            get
            {
                return this.sequenciaabertura;
            }
            set
            {
                this.sequenciaabertura = value;
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


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Modulos()
            : base()
        {
            base.table = new MDN_Table("MODULOS");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMEMODULO", true, Util.Enumerator.DataType.STRING, "", false, false, 100, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DESCRICAO", false, Util.Enumerator.DataType.STRING, "", false, false, 1000, 0));
            this.table.Fields_Table.Add(new MDN_Campo("SEQUENCIAABERTURA", false, Util.Enumerator.DataType.STRING, "", false, false, 1000, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOPROJETO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_Modulos(int codigo, int projeto)
            :this()
        {
            this.codigo = codigo;
            this.Codigoprojeto = projeto;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Modulos.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + " AND CODIGOPROJETO = " + this.Codigoprojeto;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.NomeModulo = reader["NOMEMODULO"].ToString();
                this.Descricao = reader["DESCRICAO"].ToString();
                this.SequenciaAbertura = reader["SEQUENCIAABERTURA"].ToString();
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
            List<DAO.MD_TabelasModulos> relacoes = new List<MD_TabelasModulos>();
            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_TabelasModulos().table.CreateCommandSQLTable() + " WHERE CODIGOMODULO = " + this.Codigo);

            while (reader.Read())
            {
                relacoes.Add(new MD_TabelasModulos(int.Parse(reader["CODIGOTABELA"].ToString()), int.Parse(reader["CODIGOCAMPO"].ToString()), int.Parse(reader["CODIGOMODULO"].ToString())));
            }
            reader.Close();

            foreach(DAO.MD_TabelasModulos tab in relacoes)
            {
                tab.Delete();
            }

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
                              " VALUES (" + this.codigo + ",  '" + this.nomemodulo + "',  '" + this.descricao + "',  '" + this.sequenciaabertura + "', " + this.codigoprojeto + ")";
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
                        "CODIGO = " + Codigo + ", NOMEMODULO = '" + NomeModulo + "', DESCRICAO = '" + Descricao + "', SEQUENCIAABERTURA = '" + SequenciaAbertura + "', CODIGOPROJETO = " + Codigoprojeto + "" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
