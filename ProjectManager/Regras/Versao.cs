using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public class Versao
    {
        private static Model.MD_Versao version = new Model.MD_Versao("");

        /// <summary>
        /// Versão que o sistema está
        /// </summary>
        public static Model.MD_Versao Version
        {
            get
            {
                return version;
            }
        }

        /// <summary>
        /// Método que atualiza a versão do sistema
        /// </summary>
        /// <param name="versao"></param>
        public static void AtualizaVersao(string versao)
        {
            version.DAO.Dercreator = versao;

            if (version.DAO.Empty)
                version.DAO.Insert();
            else
                version.DAO.Update();
        }
    }
}
