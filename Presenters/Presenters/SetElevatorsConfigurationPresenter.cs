using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;
using Presenters.IViews;
using Models.Services;

namespace Presenters.Presenters
{
    public class SetElevatorsConfigurationPresenter : BasePresenter<ISetElevatorsConfigurationView, ISetConfigurationView>
    {
        private ISetConfigurationView _previousView;
        private readonly IConfigurationService _configurationService;

        public SetElevatorsConfigurationPresenter(IApplicationController controller, ISetElevatorsConfigurationView view, IConfigurationService service)
           : base(controller, view)
        {
            _configurationService = service;
            View.EndLiftsConfiguration += EndLiftsConfiguration;
            View.SetElevatorsConfigurationClosing += SetElevatorsConfigurationClosing;
            View.AddElevator += () => AddElevator(View.MaxSpeed, View.MaxAcceleration, View.Capacity, View.IsTemplate);
        }

        private void EndLiftsConfiguration() => View.Close();

        private void AddElevator(string maxSpeed, string maxAcceleration, string capacity, bool isTemplate)
        {
            if (maxSpeed != string.Empty && maxAcceleration != string.Empty && capacity != string.Empty)
            {
                View.HideError();
                var maxSpeedInt = float.Parse(maxSpeed);
                var maxAccelerationInt = float.Parse(maxAcceleration);
                var capacityInt = int.Parse(capacity);

                if (!_configurationService.SetElevatorsConfiguration(maxSpeedInt, maxAccelerationInt, capacityInt, isTemplate))
                    View.ShowError("Превышено количество лифтов");
            }
            else
                View.ShowError("Некорректные данные");

        }

        private void SetElevatorsConfigurationClosing() => _previousView.Close();

        public override void Run(ISetConfigurationView previousView)
        {
            _previousView = previousView;
            View.Show();
        }
    }
}