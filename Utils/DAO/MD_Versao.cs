using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    /// <summary>
    /// [VERSAO] Tabela VERSAO
    /// </summary>
    public class MD_Versao : MDN_Model
    {
        #region Atributos e Propriedades

        private string dercreator;
        /// <summary>
        /// [DERCREATOR] Versão que o sistema está
        /// <summary>
        public string Dercreator
        {
            get
            {
                return this.dercreator;
            }
            set
            {
                this.dercreator = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Versao()
            : base()
        {
            base.table = new MDN_Table("VERSAO");
            this.table.Fields_Table.Add(new MDN_Campo("DERCREATOR", false, Util.Enumerator.DataType.STRING, "", false, false, 10, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        public MD_Versao(string versao)
            : this()
        {
            this.Dercreator = versao;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Versao.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable();
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Dercreator = reader["DERCREATOR"].ToString();

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
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE ";
            return DataBase.Connection.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz o insert da classe
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            string sentenca = string.Empty;

            sentenca = "INSERT INTO " + table.Table_Name + " (" + table.TodosCampos() + ") " +
                              " VALUES ( '" + this.dercreator + "' )";
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
                        " DERCREATOR = '" + Dercreator + "' ";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
