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
    public class SetConfigurationPresenter : BasePresenter<ISetConfigurationView>
    {
        private readonly IConfigurationService _configurationService;

        public SetConfigurationPresenter(IApplicationController controller, ISetConfigurationView view, IConfigurationService service)
            : base(controller, view)
        {
            _configurationService = service;
            View.Next += () => Next(View.ElevatorsCount, View.FloorsCount);
        }

        private void Next(string floorsCount, string elevatorsCount)
        {
            if (floorsCount != string.Empty && elevatorsCount != string.Empty)
            {
                View.HideError();
                var floorsCountInt = int.Parse(floorsCount);
                var elevatorsCountInt = int.Parse(elevatorsCount);
                if (!_configurationService.SetConfiguration(floorsCountInt, elevatorsCountInt))
                    View.ShowError("Некорректные данные");
                else
                    Controller.Run<SetElevatorsConfigurationPresenter, ISetConfigurationView>(this.View);
            }
            else
                View.ShowError("Некорректные данные");
        }
    }
}
