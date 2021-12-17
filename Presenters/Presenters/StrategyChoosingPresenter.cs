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
    public class StrategyChoosingPresenter : BasePresenter<IStrategyChoosingView>
    {
        private readonly IConfigurationService _configurationService;
        public StrategyChoosingPresenter(IApplicationController controller, IStrategyChoosingView view, IConfigurationService configurationService) : base(controller, view)
        {
            _configurationService = configurationService;
            View.Ok += Ok;
        }

        private void Ok()
        {
            _configurationService.SetStrategy(View.Strategy);
            View.Close();
        } 
    }
}
