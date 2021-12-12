using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Models.Services;
using Presenters.Common;
using Presenters.IViews;

namespace Presenters.Presenters
{
    public class StartConfigurationPresenter : BasePresenter<IStartConfigurationView>
    {
        private readonly ILoadService<ConfigurationData> _service;
        public StartConfigurationPresenter(IApplicationController controller, IStartConfigurationView view, ILoadService<ConfigurationData> service)
            : base(controller, view)
        {
            _service = service;
            View.Ok += Ok;
            View.StartConfiguration += StartConfiguration;
            View.Export += Export;
        }

        private void Export() => _service.Export(View.ExportAddress());

        private void Ok() => View.Close();

        private void StartConfiguration() => Controller.Run<SetConfigurationPresenter>();

    }
}
