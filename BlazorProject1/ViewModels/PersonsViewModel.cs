using BlazorProject1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorProject1.ViewModels
{
    public class PersonsViewmodel : ComponentBase, IPersonsViewmodel
    {
        PersonBase person=new PersonBase();

        public PersonsViewmodel()
        {
            InitializePersonViewModel().GetAwaiter().GetResult();
        }

         public async Task InitializePersonViewModel()
        {
            await Task.Delay(0);
            person.LoadPerson();

        }
       

        public List<PersonBase> PersonList
        {
            get
            {
                return person.GetPersons();
            }
            set { }
        }

        public PersonBase SelectPerson()
        {
            return new PersonBase();
        }

        public void EditPerson()
        {

        }

    }
}
