using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MD_Tabelatestes
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Tabelatestes DAO = null;

        #endregion Atributos e Propriedades

        #region Contrutor

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="codigo">Código do campo</param>
        /// <param name="codigoTabela">Código da tabela</param>
        public MD_Tabelatestes(int codigo)
        {
            this.DAO = new DAO.MD_Tabelatestes(codigo);
        }

        #endregion Contrutor

    }
}
