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
    public class CreatePeoplePresenter : BasePresenter<ICreatePeopleView>
    {
        private readonly IPeopleService _peopleService;

        public CreatePeoplePresenter(IApplicationController controller, ICreatePeopleView view, IPeopleService peopleService)
            : base(controller, view)
        {
            _peopleService = peopleService;
            View.Create += () => Create(View.PeopleCount, View.CurrentFloor, View.DestinationFloor);
        }

        public void Create(string countPeople, string currentFloor, string destinationFloor)
        {
            if (countPeople != string.Empty && currentFloor != string.Empty && 
                destinationFloor != string.Empty && currentFloor != destinationFloor)
            {
                View.HideError();
                var countPeopleInt = int.Parse(countPeople);
                var currentFloorInt = int.Parse(currentFloor);
                var destinationFloorInt = int.Parse(destinationFloor);
                if (!_peopleService.CreatePeople(countPeopleInt, currentFloorInt, destinationFloorInt))
                    View.ShowError("Этаж введен неверно");
            }
            else
                View.ShowError("Данные введены некорректно");
        }
    }
}
