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
    /// [TABELASMODULOS] Tabela TABELASMODULOS
    /// </summary>
    public class MD_TabelasModulos : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigotabela;
        /// <summary>
        /// [CODIGOTABELA] 
        /// <summary>
        public int Codigotabela
        {
            get
            {
                return this.codigotabela;
            }
            set
            {
                this.codigotabela = value;
            }
        }

        private int codigocampo;
        /// <summary>
        /// [CODIGOCAMPO] 
        /// <summary>
        public int Codigocampo
        {
            get
            {
                return this.codigocampo;
            }
            set
            {
                this.codigocampo = value;
            }
        }

        private int codigomodulo;
        /// <summary>
        /// [CODIGOMODULO] 
        /// <summary>
        public int Codigomodulo
        {
            get
            {
                return this.codigomodulo;
            }
            set
            {
                this.codigomodulo = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_TabelasModulos()
            : base()
        {
            base.table = new MDN_Table("TABELASMODULOS");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOTABELA", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOCAMPO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOMODULO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGOTABELA">
        /// <param name="CODIGOCAMPO">
        /// <param name="CODIGOMODULO">
        public MD_TabelasModulos(int codigotabela, int codigocampo, int codigomodulo)
            :this()
        {
            this.codigotabela = codigotabela;
            this.codigocampo = codigocampo;
            this.codigomodulo = codigomodulo;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Tabelasmodulos.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGOTABELA = '" + Codigotabela + "' AND CODIGOCAMPO = " + Codigocampo + " AND CODIGOMODULO = " + Codigomodulo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {

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
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE CODIGOTABELA = '" + Codigotabela + "' AND CODIGOCAMPO = " + Codigocampo + " AND CODIGOMODULO = " + Codigomodulo + "";
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
                              " VALUES ( '" + this.codigotabela + "', " + this.codigocampo + ", " + this.codigomodulo + ")";
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
                        "CODIGOTABELA = '" + Codigotabela + "', CODIGOCAMPO = " + Codigocampo + ", CODIGOMODULO = " + Codigomodulo + "" +
                        " WHERE CODIGOTABELA = '" + Codigotabela + "' AND CODIGOCAMPO = " + Codigocampo + " AND CODIGOMODULO = " + Codigomodulo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
