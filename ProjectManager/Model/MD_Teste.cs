using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MD_Teste
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Testes DAO = null;

        public List<DAO.MD_Tabelatestes> tabelaTestes = new List<DAO.MD_Tabelatestes>();

        /// <summary>
        /// Projeto que o teste está associado
        /// </summary>
        Model.MD_Projeto projeto = null;
        
        #endregion Atributos e Propriedades

        #region Contrutor

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="codigo">Código do campo</param>
        /// <param name="codigoTabela">Código da tabela</param>
        public MD_Teste(int codigo, Model.MD_Projeto projeto)
        {
            this.DAO = new DAO.MD_Testes(codigo, projeto.DAO.Codigo);
            this.projeto = projeto;
            this.PreencheListaTeste();
        }

        #endregion Contrutor

        #region Métodos

        /// <summary>
        /// Método que preenche a lista de testes
        /// </summary>
        private void PreencheListaTeste()
        {
            string sentenca = new DAO.MD_Tabelatestes().table.CreateCommandSQLTable() + " WHERE CODIGOTESTE = " + this.DAO.Codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                DAO.MD_Tabelatestes tabela = new DAO.MD_Tabelatestes(int.Parse(reader["CODIGO"].ToString()));
                tabelaTestes.Add(tabela);
            }
        }

        /// <summary>
        /// Método que preenche a lista de testes
        /// </summary>
        public List<Model.MD_Tabelatestes> RetornaListaTestes()
        {
            string sentenca = new DAO.MD_Tabelatestes().table.CreateCommandSQLTable() + " WHERE CODIGOTESTE = " + this.DAO.Codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<Model.MD_Tabelatestes> tabelas = new List<MD_Tabelatestes>();

            while (reader.Read())
            {
                Model.MD_Tabelatestes tabela = new Model.MD_Tabelatestes(int.Parse(reader["CODIGO"].ToString()));
                tabelas.Add(tabela);
            }

            return tabelas;
        }

        /// <summary>
        /// Método que apaga os vínculos
        /// </summary>
        public void ApagarVinculos()
        {
            string sentenca = "DELETE FROM " + new DAO.MD_Tabelatestes().table.Table_Name + " WHERE CODIGOTESTE = " + this.DAO.Codigo;
            DataBase.Connection.Delete(sentenca);
        }

        #endregion Métodos


    }
}
