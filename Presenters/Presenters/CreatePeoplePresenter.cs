using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;
using Models.Services;

namespace Presenters.Presenters
{
    class CreatePeoplePresenter : BasePresenter<ICreatePeopleView>
    {
        private IPeopleService _peopleService;
        public CreatePeoplePresenter(IApplicationController controller, ICreatePeopleView view, IPeopleService peopleService)
            : base(controller, view)
        {
            _peopleService = peopleService;
            View.Create += () => Create(View.peopleCount, View.currentFloor, View.destinationFloor);
        }
        public void Create(string countPeople, string currentFloor, string destinationFloor)
        {
            if (countPeople != "" && currentFloor != "" && destinationFloor != "" && currentFloor != destinationFloor)
            {
                View.HideError();
                int countPeopleInt = int.Parse(countPeople);
                int currentFloorInt = int.Parse(currentFloor);
                int destinationFloorInt = int.Parse(destinationFloor);

                if (!_peopleService.CreatePeople(countPeopleInt, currentFloorInt, destinationFloorInt))
                    View.ShowError("Этаж введен неверно");
            }
            else
                View.ShowError("Данные введены некорректно");

        }
    }
}
