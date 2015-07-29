using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerContactForm.Classes
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)] 
        public string Name { get; set; }
        
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public virtual List<CustomerContact> Contacts { get; set; }

    }
}
