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
    class SetElevatorsConfigurationPresenter : BasePresenter<ISetElevatorsConfigurationView,ISetConfigurationView>
    {
        private ISetConfigurationView _previousView;
        private IConfigurationService _configurationService;
        public SetElevatorsConfigurationPresenter(IApplicationController controller, ISetElevatorsConfigurationView view, IConfigurationService service )
           : base(controller, view)
        {
            _configurationService = service;
            View.EndLiftsConfiguration += () => EndLiftsConfiguration();
            View.SetElevatorsConfigurationClosing += () => SetElevatorsConfigurationClosing();
            View.AddElevator += () => AddElevator(View.maxSpeed, View.maxAcceleration, View.capacity, View.isTemplate);
        }

        private void EndLiftsConfiguration()
        {
            View.Close();
        }

        private void AddElevator(string maxSpeed, string maxAcceleration, string capacity, bool isTemplate)
        {
            if (maxSpeed != "" && maxAcceleration != "" && capacity != "")
            {
                View.HideError();
                float maxSpeedInt = float.Parse(maxSpeed);
                float maxAccelerationInt = float.Parse(maxAcceleration);
                int capacityInt = int.Parse(capacity);

                if(!_configurationService.SetElevatorsConfiguration(maxSpeedInt, maxAccelerationInt, capacityInt, isTemplate))
                    View.ShowError("Превышено количество лифтов");
            }
            else
            {
                View.ShowError("Некорректные данные");
            }
            
        }

        private void SetElevatorsConfigurationClosing()
        {
            _previousView.Close();
        }

        public override void Run(ISetConfigurationView previousView)
        {
            _previousView = previousView;
            View.Show();
        }

    } 
}

