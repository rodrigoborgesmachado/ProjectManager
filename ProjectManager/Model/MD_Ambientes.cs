using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [AMBIENTES] Tabela da classe
    /// </summary>
    public class MD_Ambientes 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Ambientes DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Ambientes(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Ambientes()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Ambientes( codigo);
        }


        #endregion Construtores

        #region Métodos

        #endregion Métodos

    }
}
