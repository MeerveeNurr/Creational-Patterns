using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    public class Doctor_2132 :IStaff_2132
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Specialization { get; set; }
        public override string ToString()
        {
            return $"Doctor Name: {Name}, Department: {Department}";
        }
    }
}
