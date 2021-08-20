using BlazorProject1.Models;
using System.Collections.Generic;

namespace BlazorProject1.ViewModels
{
    public interface IPersonEditModel
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        int PersonId { get; set; }
        List<PersonBase> PersonList { get; set; }
        public void LoadPerson(int i);
        public void Save(PersonBase person);
        public void Close();
    }
}