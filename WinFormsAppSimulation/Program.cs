using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.Common;
using Presenters.Presenters;
using Presenters.IViews;


namespace WinFormsAppSimulation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<IStartView, StartForm>()
                .RegisterView<IStartConfigurationView, StartConfigurationForm>();

            
            controller.Run<StartPresenter>();
            

        }
    }
}
