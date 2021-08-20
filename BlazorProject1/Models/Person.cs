using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorProject1.Models
{
    public class PersonBase : ComponentBase 
    {
        
        public int PersonId { get; set; }
        [Required(ErrorMessage ="Ime je obavezno.")]
        [StringLength(20,ErrorMessage ="Max 20 char.")]
        public string Name { get; set; }
       
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        


        
        

    }
}
