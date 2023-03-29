using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DbContext
    {
        public static List<Class> Classes = new List<Class>
        {
            new Class
            {
                Id=1,
                Name = "Public",
                Events=new List<Event>
                {
                    new Event
                    {
                        Id = 1,
                        Name = "Concert",
                        Class = new Class
                        {
                            Id = 1,
                            Name = "Public"
                        }
                    },
                    new Event
                    {
                        Id = 2,
                        Name = "Birthday Party",
                        Class = new Class
                        {
                            Id = 1,
                            Name = "Public"
                        }
                    },
                    new Event
                    {
                        Id = 3,
                        Name = "Other",
                        Class = new Class
                        {
                            Id = 1,
                            Name = "Public"
                        }
                    }
                }
            }
        };
        public static List<Event> Events = Classes.SelectMany(x => x.Events).ToList();

    }

}
