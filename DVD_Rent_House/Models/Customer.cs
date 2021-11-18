using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVD_Rent_House.Models
{
    public class Customer
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubcribedToNewsLetter { get; set; }

        //Associate MenbershipType with Customer class - Navigation Property
        public MembershipType MembershipType { get; set; }

        //Adding Foreign Key
        public byte MembershipTypeId { get; set; }
    }
}