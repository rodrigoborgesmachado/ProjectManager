using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public static class ClassesGenericas
    {
        /// <summary>
        /// Tabela base para pegar objeto genérico
        /// </summary>
        public static Model.MD_Tabela tabelaBase = new Model.MD_Tabela(-1, -1);

        /// <summary>
        /// Campo base para pegar objeto genérico
        /// </summary>
        public static Model.MD_Campos camposBase = new Model.MD_Campos(-1, -1, -1);

        /// <summary>
        /// Projeto base para pegar objeto genérico
        /// </summary>
        public static Model.MD_Projeto projetoBase = new Model.MD_Projeto(-1);

        /// <summary>
        /// Relação base para pegar objeto genérico
        /// </summary>
        public static Model.MD_Relacao relacaoBase = new Model.MD_Relacao(-1, projetoBase.DAO, tabelaBase.DAO, tabelaBase.DAO, camposBase.DAO, camposBase.DAO);
    }
}
