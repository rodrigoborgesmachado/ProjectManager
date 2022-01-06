using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [PROJETO] Classe referente à tabela projeto
    /// </summary>
    public class MD_Projeto
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Projeto DAO = null;

        #endregion Atributos e Propriedades

        #region Constutores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="codigo">Código da projeto</param>
        public MD_Projeto(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto()", Util.Global.TipoLog.DETALHADO);

            this.DAO = new DAO.MD_Projeto(codigo);
        }

        #endregion Constutores

        #region Métodos

        /// <summary>
        /// Método que retorna as tabelas do projeto
        /// </summary>
        /// <returns>Lista com todas as tabelas associadas com o projeto</returns>
        public List<MD_Tabela> GetTabelasProjeto()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.GetTabelasProjeto()", Util.Global.TipoLog.DETALHADO);

            List<MD_Tabela> tabelas = new List<MD_Tabela>();
            string sentenca = "SELECT CODIGO FROM " + new DAO.MD_Tabela().table.Table_Name + " WHERE PROJETO = " + this.DAO.Codigo;

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            while (reader.Read())
            {
                MD_Tabela table = new MD_Tabela(int.Parse(reader["CODIGO"].ToString()), this.DAO.Codigo);
                tabelas.Add(table);
                table = null;
            }
            reader.Close();

            return tabelas;
        }

        /// <summary>
        /// Método que monta uma lista dos módulos pertencentes ao projeto
        /// </summary>
        /// <returns>Lista com todos os módulos do projeto</returns>
        public List<Model.MD_Teste> GetTestesProjeto()
        {
            List<Model.MD_Teste> lista = new List<MD_Teste>();

            string sentenca = new DAO.MD_Testes().table.CreateCommandSQLTable() + " WHERE CODIGOPROJETO = " + this.DAO.Codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                Model.MD_Teste teste = new MD_Teste(int.Parse(reader["CODIGO"].ToString()), this);
                lista.Add(teste);
            }
            reader.Close();

            return lista;
        }

        /// <summary>
        /// Método que monta uma lista dos módulos pertencentes ao projeto
        /// </summary>
        /// <returns>Lista com todos os módulos do projeto</returns>
        public List<Model.MD_Modulos> GetModulosProjeto()
        {
            List<Model.MD_Modulos> lista = new List<MD_Modulos>();

            string sentenca = new DAO.MD_Modulos().table.CreateCommandSQLTable() + " WHERE CODIGOPROJETO = " + this.DAO.Codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                Model.MD_Modulos mod = new MD_Modulos(int.Parse(reader["CODIGO"].ToString()), this.DAO.Codigo);
                lista.Add(mod);
            }
            reader.Close();

            return lista;
        }

        /// <summary>
        /// Método que retorna os projetos
        /// </summary>
        /// <returns>Lista com os projetos</returns>
        public static List<MD_Projeto> GetProjetos()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.GetProjetos()", Util.Global.TipoLog.DETALHADO);

            List<MD_Projeto> projeto = new List<MD_Projeto>();
            string sentenca = new DAO.MD_Projeto().table.CreateCommandSQLTable();

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            while (reader.Read())
            {
                projeto.Add(new MD_Projeto(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return projeto;
        }

        #endregion Métodos
    }
}
