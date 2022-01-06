using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [VERSOES] Tabela da classe
    /// </summary>
    public class MD_Versoes 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Versoes DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Versoes(string versao, int codigoprojeto)
        {
            Util.CL_Files.WriteOnTheLog("MD_Versoes()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Versoes( versao,  codigoprojeto);
        }


        #endregion Construtores

        #region Métodos

        #endregion Métodos

    }
}
