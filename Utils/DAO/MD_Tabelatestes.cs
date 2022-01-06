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
    /// [TABELATESTES] Tabela TABELATESTES
    /// </summary>
    public class MD_Tabelatestes : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo;
        /// <summary>
        /// [CODIGO] Código do teste
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

        private int codigoteste;
        /// <summary>
        /// [CODIGOTESTE] Código do teste ao qual o teste unitário está vinculado
        /// <summary>
        public int Codigoteste
        {
            get
            {
                return this.codigoteste;
            }
            set
            {
                this.codigoteste = value;
            }
        }

        private string descricao;
        /// <summary>
        /// [DESCRICAO] Descrição do teste
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

        private string notas;
        /// <summary>
        /// [NOTAS] Observações do teste
        /// <summary>
        public string Notas
        {
            get
            {
                return this.notas;
            }
            set
            {
                this.notas = value;
            }
        }

        private string status;
        /// <summary>
        /// [STATUS] Status do teste (0- Erro; 1- Sucesso)
        /// <summary>
        public string Status
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


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Tabelatestes()
            : base()
        {
            base.table = new MDN_Table("TABELATESTES");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOTESTE", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DESCRICAO", true, Util.Enumerator.DataType.STRING, "", false, false, 800, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOTAS", false, Util.Enumerator.DataType.STRING, "", false, false, 500, 0));
            this.table.Fields_Table.Add(new MDN_Campo("STATUS", true, Util.Enumerator.DataType.CHAR, "1", false, false, 1, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">Código do teste
        public MD_Tabelatestes(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Tabelatestes.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Codigoteste = int.Parse(reader["CODIGOTESTE"].ToString());
                this.Descricao = reader["DESCRICAO"].ToString();
                this.Notas = reader["NOTAS"].ToString();
                this.Status = reader["STATUS"].ToString();

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
                              " VALUES (" + this.codigo + ", " + this.codigoteste + ",  '" + this.descricao + "',  '" + this.notas + "',  '" + this.status + "')";
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
                        "CODIGO = " + Codigo + ", CODIGOTESTE = " + Codigoteste + ", DESCRICAO = '" + Descricao + "', NOTAS = '" + Notas + "', STATUS = '" + Status + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
