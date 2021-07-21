using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject1.ViewModels
{
    public class PersonEditModel : IPersonEditModel
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Save() { }
        public void Close() { }
    }
}
