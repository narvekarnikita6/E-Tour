using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ETourProject1.Models
{
    public class Customer_Master
    {
        [Key]
        public int? CustId { get; set; }

        public String? FirstName { get; set; }


        public String? LastName { get; set; }


        public int? Age { get; set; }

        public String? Gender { get; set; }

        public int? CountryCode { get; set; }


        public long? MobileNumber { get; set; }

        public String? Address { get; set; }

        public String? Email { get; set; }

 
        public long? AdharNumber { get; set; }


        public String? UserName { get; set; }

        public String? PassWord { get; set; }


        public ICollection<Booking_Header>? BookingHeaders { get; set; }
    }
}
