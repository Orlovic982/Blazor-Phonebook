using BlazorProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject1.ViewModels
{
    public class PersonEditModel : IPersonEditModel
    {
        private readonly IPersonsViewmodel _persons;
        PersonBase person = new PersonBase();
        
        public PersonEditModel(IPersonsViewmodel persons)
        {
            _persons = persons;
        }


        public int PersonId 
        {
            get
            {
                return person.PersonId;
            }
            set
            {
                person.PersonId = value;
            }
        }
        
        public string PhoneNumber
        {
            get
            {
                return person.PhoneNumber;
            }
            set
            {
                person.PhoneNumber = value;
            }
        }
        
        public string Name 
        { 
            get {
                return person.Name;
            } 
            set {
                person.Name = value;
            } 
        }
        
        public string Email
        {
            get
            {
                return person.Email;
            }
            set {
                person.Email = value;
            }
        }
        
        public void LoadPerson (int i)
        {
            person=_persons.PersonList[i -1];
        }

        public void Save(PersonBase person)
        {
            _persons.Save(person);
        }
        
        public void Close() { }

        public List<PersonBase> PersonList
        {
            get {
                return _persons.PersonList;
                    }

            set { }
        }

      
    }
}
