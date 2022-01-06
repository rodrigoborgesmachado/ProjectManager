using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    static class Parametros
    {
        private static Model.MD_Parametros corPrimariaDER = null;
        /// <summary>
        /// Parâmetro da cor primária do sistema
        /// </summary>
        public static Model.MD_Parametros CorPrimariaDER
        {
            get
            {
                if (corPrimariaDER == null)
                {
                    corPrimariaDER = new Model.MD_Parametros("Cor Primária do sistema");
                }
                return corPrimariaDER;
            }
            set
            {
                corPrimariaDER = value;
            }
        }

        private static Model.MD_Parametros corSecundariaDER = null;
        /// <summary>
        /// Parâmetro da cor secundária do sistema (DER)
        /// </summary>
        public static Model.MD_Parametros CorSecundariaDER
        {
            get
            {
                if (corSecundariaDER == null)
                {
                    corSecundariaDER = new Model.MD_Parametros("Cor Secundária do sistema");
                }
                return corSecundariaDER;
            }
            set
            {
                corSecundariaDER = value;
            }
        }

        private static Model.MD_Parametros apresentaQuantidades = null;
        /// <summary>
        /// Parâmetro da cor secundária do sistema (DER)
        /// </summary>
        public static Model.MD_Parametros ApresentaQuantidades
        {
            get
            {
                if (apresentaQuantidades == null)
                {
                    apresentaQuantidades = new Model.MD_Parametros("Apresenta configura~ção de quantidade na tela principal");
                }
                return apresentaQuantidades;
            }
            set
            {
                apresentaQuantidades = value;
            }
        }

        /// <summary>
        /// Método que atualiza os parâmetros do sistema
        /// </summary>
        public static void AtualizaParametros()
        {
            Model.MD_Parametros parametro = new Model.MD_Parametros("Cor Primária do sistema");

            if (parametro.DAO.Empty)
            {
                parametro.DAO.Valor = "rgb(0,0,255)";
                parametro.DAO.Insert();
            }

            parametro = new Model.MD_Parametros("Cor Secundária do sistema");
            if (parametro.DAO.Empty)
            {
                parametro.DAO.Valor = "rgb(232,80,12)";
                parametro.DAO.Insert();
            }

            parametro = new Model.MD_Parametros("Apresenta configura~ção de quantidade na tela principal");
            if (parametro.DAO.Empty)
            {
                parametro.DAO.Valor = "0";
                parametro.DAO.Insert();
            }
        }

        /// <summary>
        /// Método que atualizaos parâmetros para o valor padrão
        /// </summary>
        public static void SetaValoresPadrao()
        {
            // Cor Primária do sistema
            Model.MD_Parametros parametro = new Model.MD_Parametros("Cor Primária do sistema");
            parametro.DAO.Valor = "rgb(0,0,255)";
            parametro.DAO.Update();

            // Cor Secundária do sistema
            parametro = new Model.MD_Parametros("Cor Secundária do sistema");
            parametro.DAO.Valor = "rgb(232,80,12)";
            parametro.DAO.Update();
            
        }
    }
}
