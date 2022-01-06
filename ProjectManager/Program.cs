using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataBase.Connection.OpenConection(Util.Global.app_base_file, Util.Enumerator.BancoDados.SQLite);

            Util.CL_Files.CreateMainDirectories();
            Util.CL_Files.WriteOnTheLog("--------------------------------------Iniciando sistema", Util.Global.TipoLog.SIMPLES);

            Regras.Versao.AtualizaVersao(Application.ProductVersion);
            Util.Global.InsereDadosIniciais();
            Util.Global.log_system = DataBase.Connection.GetLog();
            Util.Global.CarregarAutomaticamente = DataBase.Connection.GetAutomatico();
            Util.Global.ApresentaInformacao = DataBase.Connection.GetApresentaInformacao();
            Regras.Parametros.AtualizaParametros();

            // Chamadas das classes modelo para criação das tabelas
            DAO.MD_Campos campos = new DAO.MD_Campos();
            DAO.MD_Modulos modulos = new DAO.MD_Modulos();
            DAO.MD_Parametros param = new DAO.MD_Parametros();
            DAO.MD_Projeto project = new DAO.MD_Projeto();
            DAO.MD_Relacao rel = new DAO.MD_Relacao();
            DAO.MD_Tabela tab = new DAO.MD_Tabela();
            DAO.MD_TabelasModulos tabmod = new DAO.MD_TabelasModulos();
            DAO.MD_TipoCampo tipo = new DAO.MD_TipoCampo();
            DAO.MD_Versao versao = new DAO.MD_Versao();

            Visao.FO_Login login = new Visao.FO_Login();
            if(login.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Application.Run(new Visao.FO_Principal());

            DataBase.Connection.CloseConnection();
            Util.CL_Files.WriteOnTheLog("--------------------------------------Finalizando sistema", Util.Global.TipoLog.SIMPLES);
        }
    }
}
