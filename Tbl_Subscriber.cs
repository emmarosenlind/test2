using System;
using System.ComponentModel.DataAnnotations;

namespace lab2_web.Models
{
    public class Tbl_Subscriber
    {
        [Key]
        public int Su_Id { get; set; }

        public int Su_Securitynr { get; set; }

        public string Su_Firstname { get; set; }

        public string Su_Surname { get; set; }

        public string Su_Address { get; set; }

        public int Su_Postalcode { get; set; }
    }
}
