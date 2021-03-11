using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex9EnumComp.Entities.Enums;

namespace Ex9EnumComp.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department() 
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
