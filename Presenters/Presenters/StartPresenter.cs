using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Presenters.IViews;
using Presenters.Common;
using Models.Services;

namespace Presenters.Presenters
{
    public class StartPresenter : BasePresenter<IStartView>
    {
        private readonly IConfigurationService _configurationService;
        private readonly IFloorService _floorService;
        private readonly IElevatorsManager _elevatorsService;

        public StartPresenter(IApplicationController controller, IStartView view, IConfigurationService configurationService,
            IFloorService floorService, IElevatorsManager elevatorsService) : base(controller, view)
        {
            _configurationService = configurationService;
            _floorService = floorService;
            _elevatorsService = elevatorsService;

            View.StartConfiguration += StartConfiguration;
            View.StrategyChoosing += StrategyChoosing;
            View.StartSimulation += StartSimulation;
            View.Exit += Exit;
        }

        private void StartConfiguration() => Controller.Run<StartConfigurationPresenter>();

        private void StrategyChoosing() => Controller.Run<StrategyChoosingPresenter>();

        private void StartSimulation()
        {
            if (_configurationService.IsConfigurationSet())
            {
                View.HideError();
                _floorService.InitializeFloorRepository();
                _elevatorsService.InitializeElevatorRepository();
                View.Hide();
                Controller.Run<SimulationPresenter, IStartView>(this.View);

            }
            else
                View.ShowError("Конфигурация не задана либо задана некорректно");

        }

        private void Exit() => View.Close();
    }
}
