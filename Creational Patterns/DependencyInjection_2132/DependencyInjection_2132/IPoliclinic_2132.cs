using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public interface IPoliclinic_2132
    {
        void AddPoliklinik(string poliklinikName);
        void RemovePoliklinik(string poliklinikName);
        public void PoliklinikNotFound(string poliklinikName);
    }
}
