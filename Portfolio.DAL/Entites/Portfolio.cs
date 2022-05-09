using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.Entites
{
    public class Portfolio
    {
        public Guid Id { get; set; }

        public string projectName { get; set; }
        public string projectPic { get; set; }

        public string projectDesc { get; set; }
    }
}
