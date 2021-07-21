using BlazorProject1.Models;
using System.Collections.Generic;

namespace BlazorProject1.ViewModels
{
    public interface IPersonsViewmodel
    {
        List<PersonBase> PersonList { get; set; }

        void EditPerson();
        PersonBase SelectPerson();
    }
}