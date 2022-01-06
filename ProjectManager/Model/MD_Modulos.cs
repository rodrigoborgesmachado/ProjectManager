using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MD_Modulos
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Modulos DAO = null;

        /// <summary>
        /// relações de tabelas do módulo
        /// </summary>
        List<Model.MD_TabelasModulos> relacoes = new List<MD_TabelasModulos>();

        #endregion Atributos e Propriedades

        #region Contrutor

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="codigo">Código do campo</param>
        /// <param name="codigoTabela">Código da tabela</param>
        public MD_Modulos(int codigo, int projeto)
        {
            this.DAO = new DAO.MD_Modulos(codigo, projeto);
            relacoes = MD_TabelasModulos.RetornaRelacoes(codigo);
        }

        #endregion Contrutor

        #region Métodos

        /// <summary>
        /// Método que captura os campos pertencente ao módulo
        /// </summary>
        /// <returns></returns>
        public List<Model.MD_Campos> Campos()
        {
            List<Model.MD_Campos> campos = new List<MD_Campos>();

            foreach(Model.MD_TabelasModulos tabela in this.relacoes)
            {
                Model.MD_Campos campo = new MD_Campos(tabela.DAO.Codigocampo, tabela.DAO.Codigotabela, this.DAO.Codigoprojeto);
                campos.Add(campo);
            }

            return campos;
        }

        #endregion Métodos
    }
}
