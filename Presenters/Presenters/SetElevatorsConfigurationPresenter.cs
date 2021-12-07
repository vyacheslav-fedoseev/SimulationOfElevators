using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;
using Presenters.IViews;

namespace Presenters.Presenters 
{
    class SetElevatorsConfigurationPresenter : BasePresenter<ISetElevatorsConfigurationView,ISetConfigurationView>
    {
        private ISetConfigurationView _previousView;
        public SetElevatorsConfigurationPresenter(IApplicationController controller, ISetElevatorsConfigurationView view)
           : base(controller, view)
        {

            View.EndLiftsConfiguration += () => EndLiftsConfiguration();
            View.SetElevatorsConfigurationClosing += () => SetElevatorsConfigurationClosing();
        }

        private void EndLiftsConfiguration()
        {
            View.Close();
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

