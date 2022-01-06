using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// [VERSAO] Tabela VERSAO
    /// </summary>
    public class MD_Versao
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Versao DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores
        
		/// <summary>
        /// Construtor principal da classe
        /// </summary>
        public MD_Versao(string versao)
        {
            this.DAO = new DAO.MD_Versao(versao);
        }

		#endregion Construtores

        #region Métodos
        
		#endregion Métodos
    }
}
