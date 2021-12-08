using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.Common;
using Presenters.Presenters;
using Presenters.IViews;
using Models.Services;
using Models.Repositories;


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
                .RegisterView<IStartConfigurationView, StartConfigurationForm>()
                .RegisterView<ICheckPeopleStatusView, CheckPeopleStatusForm>()
                .RegisterView<ICreatePeopleView, CreatePeopleForm>()
                .RegisterView<ISetConfigurationView, SetConfigurationForm>()
                .RegisterView<ISetElevatorsConfigurationView, SetElevatorsConfigurationForm>()
                .RegisterView<ISimulationView, SimulationForm>()
                .RegisterView<IStatisticsView, StatisticsForm>()
                .RegisterView<IStrategyChoosingView, StrategyChoosingForm>()
                .RegisterService<IConfigurationService, ConfigurationService>()
                .RegisterService<IPeopleService, PeopleService>()
                .RegisterService<IPeopleRepository, PeopleRepository>()
                .RegisterService<IFloorRepository, FloorRepository>()
                .RegisterService<IElevatorRepository, ElevatorRepository>();

            controller.Run<StartPresenter>();
            

        }
    }
}
