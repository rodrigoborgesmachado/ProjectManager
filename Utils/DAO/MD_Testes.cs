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
    /// [TESTES] Tabela TESTES
    /// </summary>
    public class MD_Testes : MDN_Model
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

        private int codigoProjeto;
        /// <summary>
        /// [codigoProjeto] Código do projeto
        /// <summary>
        public int CodigoProjeto
        {
            get
            {
                return this.codigoProjeto;
            }
            set
            {
                this.codigoProjeto = value;
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

        private int codigomodulo;
        /// <summary>
        /// [CODIGOMODULO] Código do módulo vinculado ao teste
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

        private string notas;
        /// <summary>
        /// [NOTAS] Notas dos testes feitos
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

        private string datateste;
        /// <summary>
        /// [DATATESTE] Data que o teste foi criado
        /// <summary>
        public string Datateste
        {
            get
            {
                return this.datateste;
            }
            set
            {
                this.datateste = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Testes()
            : base()
        {
            base.table = new MDN_Table("TESTES");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DESCRICAO", true, Util.Enumerator.DataType.STRING, "", false, false, 1000, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOMODULO", false, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOPROJETO", false, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOTAS", false, Util.Enumerator.DataType.STRING, "", false, false, 1000, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DATATESTE", false, Util.Enumerator.DataType.STRING, "", false, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">Código do teste
        public MD_Testes(int codigo, int codigoProjeto)
            :this()
        {
            this.codigo = codigo;
            this.CodigoProjeto = codigoProjeto;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Testes.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + " AND CODIGOPROJETO = " + this.CodigoProjeto;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Descricao = reader["DESCRICAO"].ToString();
                this.Codigomodulo = int.Parse(reader["CODIGOMODULO"].ToString());
                this.Notas = reader["NOTAS"].ToString();
                this.Datateste = reader["DATATESTE"].ToString();

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
                              " VALUES (" + this.codigo + ",  '" + this.descricao + "', " + this.codigomodulo +"," + this.CodigoProjeto + ",  '" + this.notas + "',  '" + this.datateste + "')";
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
                        "CODIGO = " + Codigo + ", DESCRICAO = '" + Descricao + "', CODIGOMODULO = " + Codigomodulo + ", CODIGOPROJETO = " + this.CodigoProjeto + ", NOTAS = '" + Notas + "', DATATESTE = '" + Datateste + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
