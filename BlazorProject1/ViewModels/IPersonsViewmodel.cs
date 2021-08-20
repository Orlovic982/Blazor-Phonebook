using BlazorProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject1.ViewModels
{
    public interface IPersonsViewmodel
    {
        List<PersonBase> PersonList { get; set; }
        public void Save(PersonBase person);
        public event Action CounterChange;
        void EditPerson();
        public int PresonListNumber { get; set; }
        
        PersonBase SelectPerson();
    }
}