using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        //Navigation Property
        public MembershipType MembershipType { get; set; }
        //Ac as forien key
        public byte MembershipTypeId { get; set; }
    }
}