using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.Entites
{
    public class Profile
    {
        // GUID (Global Unique IDentifier)
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public string JobTitle { get; set; }

        public Address Address { get; set; }
    }
}
