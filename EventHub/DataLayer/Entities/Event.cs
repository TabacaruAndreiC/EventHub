using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }
    }
}
