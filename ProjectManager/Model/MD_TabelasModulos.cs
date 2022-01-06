using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class MD_TabelasModulos
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_TabelasModulos DAO = null;

        #endregion Atributos e Propriedades

        #region Contrutor

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="codigo">Código do campo</param>
        /// <param name="codigoTabela">Código da tabela</param>
        public MD_TabelasModulos(int tabela, int campo, int modulo)
        {
            this.DAO = new DAO.MD_TabelasModulos(tabela, campo, modulo);
        }

        #endregion Contrutor

        #region Métodos

        /// <summary>
        /// Método que retorna uma lista com todos os relacionamentos
        /// </summary>
        /// <param name="codigoModulo"></param>
        public static List<Model.MD_TabelasModulos> RetornaRelacoes(int codigoModulo)
        {
            List<Model.MD_TabelasModulos> relacoes = new List<MD_TabelasModulos>();

            string sentenca = new DAO.MD_TabelasModulos().table.CreateCommandSQLTable() + " WHERE CODIGOMODULO = " + codigoModulo;

            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                Model.MD_TabelasModulos relacao = new MD_TabelasModulos(int.Parse(reader["CODIGOTABELA"].ToString()), int.Parse(reader["CODIGOCAMPO"].ToString()), int.Parse(reader["CODIGOMODULO"].ToString()));
                relacoes.Add(relacao);
            }
            reader.Close();

            return relacoes;
        }

        /// <summary>
        /// Método que efetua a exclusão das relações com o módulo
        /// </summary>
        /// <param name="codigo">Módulo a excluir as relações</param>
        /// <returns>True - sucesso; False - erro</returns>
        public static bool ExcluiRelacoes(int codigo)
        {
            bool retorno = true;

            try
            {
                DataBase.Connection.Delete("DELETE FROM " + new DAO.MD_TabelasModulos().table.Table_Name + " WHERE CODIGOMODULO = " + codigo);
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        #endregion Métodos
    }
}
