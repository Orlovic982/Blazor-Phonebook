using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorProject1.Models
{
    public class PersonBase : ComponentBase 
    {
        public int PersonId;
        public string FirstName;
        public string LastName;

        public List<PersonBase> Persons = new List<PersonBase>();



        public void LoadPerson()
        {

            PersonBase p1 = new PersonBase
            {
                PersonId = 1,
                FirstName = "Milan",
                LastName = "Milanovic"
            };


            PersonBase p2 = new PersonBase
            {
                PersonId = 2,
                FirstName = "Goran",
                LastName = "Goranovic"

            };

            PersonBase p3 = new PersonBase
            {
                PersonId = 3,
                FirstName = "Milana",
                LastName = "Srdjanovic"

            };

            Persons = new List<PersonBase> { p1, p2, p3 };

        }


         public List<PersonBase> GetPersons()
         {

             return Persons;
        }
        


    }
}
