using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Entities;
using Presenters.Common;
using Presenters.Presenters;
using Presenters.IViews;
using Models.Services;
using Models.Repositories;


namespace WinFormsAppSimulation
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<IStartView, StartForm>()
                .RegisterView<IStartConfigurationView, StartConfigurationForm>()
                .RegisterView<ICheckPeopleStatusView, CheckPeopleStatusForm>()
                .RegisterView<ICreatePeopleView, CreatePeopleForm>()
                .RegisterView<ISetConfigurationView, SetConfigurationForm>()
                .RegisterView<ISetElevatorsConfigurationView, SetElevatorsConfigurationForm>()
                .RegisterView<ISimulationView, SimulationForm>()
                .RegisterView<IStatisticsView, StatisticsForm>()
                .RegisterView<IStrategyChoosingView, StrategyChoosingForm>()
                .RegisterView<ICreateEventsListView, CreateEventsListForm>()
                .RegisterService<IConfigurationService, ConfigurationService>()
                .RegisterService<IPeopleService, PeopleService>()
                .RegisterService<IFloorService, FloorService>()
                .RegisterService<IElevatorsManager, ElevatorsManager>()
                .RegisterService<IPeopleRepository, PeopleRepository>()
                .RegisterService<IFloorRepository, FloorRepository>()
                .RegisterService<IElevatorRepository, ElevatorRepository>()
                .RegisterService<IStatisticsService, StatisticsService>()
                .RegisterService<ITimer, WinFormTimer>()
                .RegisterService<ILoadService<ConfigurationData>, LoadStartConfigurationService>()
                .RegisterService<ILoadService<EventItem>, LoadEventsListService>()
                .RegisterService<IEventsListService, EventsListService>();

            controller.Run<StartPresenter>();
        }
        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }
    }
}
