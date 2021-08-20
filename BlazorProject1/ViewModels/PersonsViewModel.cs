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
        public event Action CounterChange;

        
        public PersonsViewmodel()
        {
            InitializePersonViewModel().GetAwaiter().GetResult();
        }


        public async Task InitializePersonViewModel()
        {
            await Task.Delay(0);
            LoadPerson();

        }

        public void Save(PersonBase person)
        {

            PersonList.Add(person);
            Console.WriteLine("unet je novi element");
            PersonListChange(); 
        }

        void PersonListChange() => CounterChange.Invoke();

        public int PresonListNumber 
        {
            get
            {
                return PersonList.Count();

            }
            set { } }

        
        
        

        public PersonBase SelectPerson()
        {
            return new PersonBase();
        }

        public void EditPerson()
        {

        }

        
        public List<PersonBase> PersonList { get; set; } = new List<PersonBase>();

        public void LoadPerson()
        {

            PersonBase p1 = new PersonBase
            {
                PersonId = 1,
                Name = "Milan Milanovic",
                PhoneNumber = "063111222",
                Email = "milanmilanovc@gmail.com"
            };


            PersonBase p2 = new PersonBase
            {
                PersonId = 2,
                Name = "Goran Goranovic",
                PhoneNumber = "063222333",
                Email = "gorangoranovic@gmail.com"

            };

            PersonBase p3 = new PersonBase
            {
                PersonId = 3,
                Name = "Milana Srdjanovic",
                PhoneNumber = "063444222",
                Email = "milansrdjanovic@gmail.com"

            };

            PersonList = new List<PersonBase> { p1, p2, p3 };

        }

        
    }
}
